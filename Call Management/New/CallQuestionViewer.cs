using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker.Call_Management
{
    public partial class CallQuestionViewer : UserControl
    {
        private const int DEFAULTX = 8;
        private const int DEFAULTINDENT = 6;
        private const int STARTY = 8;
        private const int SPACER = 0;
        private const int CATEGORYSPACER = 3;
        private Control lastAdded;
        private int controlCount = 0;
        private Dictionary<int, int> categories = new Dictionary<int, int>();
        private int questionCount = 0;
        private Dictionary<int, List<Control>> formControls = new Dictionary<int,List<Control>>();
        private question currentParentCategory;
        public call CurrentCall;
        private int _questionsAnsweredCount;
        public event EventHandler<QuestionAnsweredEventArgs> QuestionAnswered;
        public event EventHandler QuestionCleared;
        private List<choice> _choices = new List<choice>();
        private bool _thinMode = false;

        int displayDepth;
        public bool HasCategory
        { get { return categories.Count > 0; } }
        public int QuestionsAnsweredCount
        { get { return _questionsAnsweredCount; } }
        public List<choice> Choices
        { get { return _choices; } }
        public question CurrentParentCategory
        { get { return currentParentCategory; } }

        public bool ThinMode
        { get { return _thinMode; }
            set
            {
                _thinMode = value;
                if (_thinMode)
                    pnlTop.Height = 18;
                else
                    pnlTop.Height = 36;
            }
        }

        public CallQuestionViewer()
        {
            InitializeComponent();
        }
        

        public void AddCategory(question q)
        {
            if (categories.ContainsKey(q.id))
            {
                MessageBox.Show(this, "Programmer error: Attempting to view the same category more than once.");
            }
            else
            {
                List<question> questionsToAdd = q.GetCategoryQuestions();
                List<int> requiredAnswerParentIDs = new List<int>() ;
                question qToUse = q;
                string categoryText = ""; ;
                List<string> categoryTree = new List<string>();
                categoryTree.Add(q.text);
                while (qToUse.parent > 0)
                {
                    qToUse = qToUse.ParentQuestion;
                    categoryTree.Add(qToUse.text);
                }

                for (int i = categoryTree.Count - 1; i >= 0; i--)
                {
                    if (i < categoryTree.Count - 1)
                        categoryText += " - ";
                    categoryText += categoryTree[i];
                }
                if (lblCategoryInfo.Text == "")
                    categoryText = "Claim Status: " + categoryText;
                else
                    categoryText = " - " + categoryText;

                lblCategoryInfo.Text += categoryText;


                bool isRoot = true;

                pnlControls.AutoScroll = false;
                pnlControls.SuspendLayout();

                currentParentCategory = q;
                categories.Add(q.id, 0);
                formControls.Add(q.id, new List<Control>());
                AddCategoryLabel(q, false);
                foreach (question aQuestion in questionsToAdd)
                {
                    bool hideQuestion = false;
                    if (aQuestion.required_answer != "")
                    {
                        // Need to not show this entire tree of questions
                        requiredAnswerParentIDs.Add(aQuestion.id);
                        hideQuestion = true;
                    }
                    else
                    {
                        if (requiredAnswerParentIDs.Contains(aQuestion.parent))
                        {
                            requiredAnswerParentIDs.Add(aQuestion.id);
                            hideQuestion = true;
                        }
                        else if (aQuestion.parent > 0)
                        {
                            if (aQuestion.ParentQuestion.required_answer != "")
                            {
                                requiredAnswerParentIDs.Add(aQuestion.parent);
                                requiredAnswerParentIDs.Add(aQuestion.id);
                                hideQuestion = true;
                            }
                            else
                            {
                                List<int> allParentIDs = aQuestion.GetParentIDs();
                                foreach (int aParentID in allParentIDs)
                                {
                                    // Loop through all parent IDs and verify nothing is "banned"
                                    if (requiredAnswerParentIDs.Contains(aParentID))
                                    {
                                        requiredAnswerParentIDs.Add(aQuestion.id);
                                        requiredAnswerParentIDs.Add(aQuestion.parent);
                                        hideQuestion = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    AddQuestion(aQuestion, isRoot, hideQuestion);
                    isRoot = false;

                }
                pnlControls.ResumeLayout();
                pnlControls.AutoScroll = true;
            }
        }

        /// <summary>
        /// Removes all stored information from the control
        /// </summary>
        public void ClearAllCategories()
        {
            categories.Clear();
            formControls.Clear();
            pnlControls.Controls.Clear();
            lblCategoryInfo.Text = "";
            displayDepth = 0;
            controlCount = 0;
            lastAdded = null;
            _choices.Clear();
        }


        /// <summary>
        /// Was working when these were used to display multiple categories
        /// </summary>
        /// <param name="q"></param>
        public void RemoveCategory(question q)
        {
            int top = 10000;
            int controlsRemoved = formControls[q.id].Count;

            foreach (Control toRemove in formControls[q.id])
            {
                if (toRemove.Top < top)
                    top = toRemove.Top;
                if (lastAdded == toRemove)
                    lastAdded = null;

                if (toRemove is LabelWithCategory)
                {
                    categories.Remove(((LabelWithCategory)toRemove).Category.id);
                }
                
                Controls.Remove(toRemove);
                toRemove.Dispose();
            }

            formControls.Remove(q.id);
            MoveControlsUp(top, controlsRemoved);

            if (lastAdded == null)
            {
                foreach (Control c in Controls)
                {
                    if ((c is LabelWithCategory) || (c is CallQuestionAnswerDisplay))
                    {
                        if (lastAdded == null)
                            lastAdded = c;
                        else
                            if (c.Top > lastAdded.Top)
                                lastAdded = c;
                    }
                }
            }
        }

        private void MoveControlsUp(int top, int controlsRemoved)
        {
            // first, figure out how much everything should be moved
            int lastBottom = top + SPACER;

            // Second, move everything and fix tabindexes, control count, and lastBottom variable
            foreach (Control c in Controls)
            {
                if (c.Top > top)
                {
                    c.Top = SPACER + lastBottom;
                    c.TabIndex = c.TabIndex - controlsRemoved;
                    lastBottom = c.Bottom;
                }
            }

            controlCount -= controlsRemoved;
        }

        private void AddQuestion(question q, bool isRoot, bool hideQuestion)
        {
            int lastBottom;
            if (isRoot)
            {
                questionCount++;

                // Slight hack here because sometimes the root category does not have 
                // a question in it, and the root level is deeper. Will have problems
                // with deeply nested questions, should be addressed at some point
                if (q.parent == currentParentCategory.id)
                    displayDepth = 0;
                else
                    displayDepth = 1;

                if (!categories.ContainsKey(q.parent))
                    categories.Add(q.parent, displayDepth);
            }
            else if (!categories.ContainsKey(q.parent))
            {
                questionCount++;
                
                if (categories.ContainsKey(q.ParentQuestion.parent))
                {
                    displayDepth = categories[q.ParentQuestion.parent] + 1;
                }
                else
                    displayDepth++;
                categories.Add(q.parent, displayDepth);
                
            }
            else 
            {
                questionCount++;
                displayDepth = categories[q.parent];
            }

            if (q.is_fork)
            {
                if (!categories.ContainsKey(q.id))
                    categories.Add(q.id, displayDepth);
            }

            if (lastAdded == null)
                lastBottom = 0;
            else
                lastBottom = lastAdded.Bottom;

            if (q.type == question.QuestionTypes.Category)
            {
                AddCategoryLabel(q, hideQuestion);
            }
            else
            {
                CallQuestionAnswerDisplay cqad = new CallQuestionAnswerDisplay(q, null, CurrentCall);

                cqad.Location = new Point(DEFAULTX + (DEFAULTINDENT * displayDepth), lastBottom + SPACER);

                if (q.is_fork)
                {
                    cqad.Top += CATEGORYSPACER;
                }
                cqad.TabIndex = controlCount;
                cqad.Name = "cqad" + controlCount;
                cqad.Size = new Size(Width - DEFAULTX - 15 - (DEFAULTINDENT * displayDepth), cqad.DefaultHeight);
                cqad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                cqad.BorderStyle = BorderStyle.FixedSingle;
                cqad.QuestionAnswered += new EventHandler<QuestionAnsweredEventArgs>(cqad_QuestionAnswered);
                cqad.QuestionCleared += new EventHandler<QuestionAnsweredEventArgs>(cqad_QuestionCleared);
                cqad.IsHidden = hideQuestion;
                cqad.Size = new Size(Width - DEFAULTX - 15 - (DEFAULTINDENT * displayDepth), cqad.DefaultHeight);
                cqad.DisplayDepth = displayDepth;

                controlCount++;

                lastAdded = cqad;
                pnlControls.Controls.Add(cqad);
                formControls[currentParentCategory.id].Add(cqad);
            }
        }

        void cqad_QuestionCleared(object sender, QuestionAnsweredEventArgs e)
        {
            _questionsAnsweredCount--;
            if (QuestionCleared != null)
                QuestionCleared(this, new QuestionAnsweredEventArgs());

            if (_choices.Contains(e.Choice))
                _choices.Remove(e.Choice);

            CallQuestionAnswerDisplay sentBy = (CallQuestionAnswerDisplay)sender;
            if (sentBy.Question.is_fork)
            {
                HideQuestions(sentBy, "");
            }
        }

        /// <summary>
        /// Hide all questions that do not have the given answer
        /// </summary>
        /// <param name="sentBy"></param>
        /// <param name="answer"></param>
        private void HideQuestions(CallQuestionAnswerDisplay sentBy, string answer)
        {
            // Need to show all subquestions here
            
            List<Control> toHide = GetChildQuestionsRecursive(sentBy.Question, answer, false);

            int totalSubtractHeight = 0;
            toHide.Sort(delegate(Control c1, Control c2) { return c1.TabIndex.CompareTo(c2.TabIndex); });
            foreach (Control aControl in toHide)
            {
                
                int top = 0;
                totalSubtractHeight += aControl.Height;
                if (aControl is LabelWithCategory)
                {
                    ((LabelWithCategory)aControl).IsHidden = true;
                    aControl.Height = ((LabelWithCategory)aControl).DefaultHeight;
                    top = GetTop(aControl.TabIndex) + CATEGORYSPACER;
                }
                else if (aControl is CallQuestionAnswerDisplay)
                {
                    ((CallQuestionAnswerDisplay)aControl).IsHidden = true;
                    aControl.Height = ((CallQuestionAnswerDisplay)aControl).DefaultHeight;
                    top = GetTop(aControl.TabIndex) + SPACER;
                }


                aControl.Location = new Point(aControl.Location.X, top);
            }

            if (toHide.Count > 0)
            {
                for (int i = toHide[toHide.Count - 1].TabIndex + 1; i < formControls[currentParentCategory.id].Count; i++)
                {
                    formControls[currentParentCategory.id][i].Top -= totalSubtractHeight;
                }
            }
             
        }

        void cqad_QuestionAnswered(object sender, QuestionAnsweredEventArgs e)
        {
            _questionsAnsweredCount++;
            CallQuestionAnswerDisplay sentBy = (CallQuestionAnswerDisplay)sender;
            if (sentBy.Question.is_fork)
            {
                pnlControls.SuspendLayout();
                pnlControls.AutoScroll = false;
                HideQuestions(sentBy, e.Choice.answer);
                
                // Need to show all subquestions here
                List<Control> toShow = GetChildQuestionsRecursive(sentBy.Question, e.Choice.answer);
                

                int totalAddedHeight = 0;
                // Controls aren't showing properly because controls in toShow aren't sorted by tabindex
                // Is likely also the problem with control hiding
                toShow.Sort(delegate(Control c1, Control c2) { return c1.TabIndex.CompareTo(c2.TabIndex);  });

                int lastBottom = 0;
                if (toShow.Count > 0)
                    lastBottom = GetTop(toShow[0].TabIndex);
                foreach (Control aControl in toShow)
                {
                    int top = 0;
                    if (aControl is LabelWithCategory)
                    {
                        ((LabelWithCategory)aControl).IsHidden = false;
                        aControl.Height = ((LabelWithCategory)aControl).DefaultHeight;
                        top = lastBottom + CATEGORYSPACER;
                    }
                    else if (aControl is CallQuestionAnswerDisplay)
                    {
                        ((CallQuestionAnswerDisplay)aControl).IsHidden = false;
                        aControl.Height = ((CallQuestionAnswerDisplay)aControl).DefaultHeight;
                        top = lastBottom + SPACER;       
                    }

                     

                    totalAddedHeight += aControl.Height;
                    aControl.Location = new Point(aControl.Location.X, top);
                    lastBottom = aControl.Bottom;  
                }

                if (toShow.Count > 0)
                {
                    for (int i = toShow[toShow.Count - 1].TabIndex + 1; i < formControls[currentParentCategory.id].Count; i++)
                    {
                        formControls[currentParentCategory.id][i].Top += totalAddedHeight;
                    }
                }

                pnlControls.ResumeLayout();
                pnlControls.AutoScroll = true;

            }

            if (!_choices.Contains(e.Choice))
                _choices.Add(e.Choice);

            if (QuestionAnswered != null)
                QuestionAnswered(sender, e);
        }

        private string GetTabIndexes(List<Control> toShow)
        {
            string toReturn = "";
            foreach (Control aControl in toShow)
            {
                toReturn += "," + aControl.TabIndex;
            }
            return toReturn;
        }

        private List<Control> GetChildQuestionsRecursive(question parentQuestion, string givenAnswer)
        {
            return GetChildQuestionsRecursive(parentQuestion, givenAnswer, true);
        }   

        /// <summary>
        /// Returns all child questions for a given question. Given answer is the answer to search for. If requires match is true,
        /// returns all child questions that match. If it's false, returns all non-matches.
        /// </summary>
        /// <param name="parentQuestion"></param>
        /// <param name="givenAnswer"></param>
        /// <param name="requiresMatch"></param>
        /// <returns></returns>
        private List<Control> GetChildQuestionsRecursive(question parentQuestion, string givenAnswer, bool requiresMatch)
        {
            List<Control> toReturn = new List<Control>();

            foreach (Control anItem in formControls[currentParentCategory.id])
            {
                if (anItem is LabelWithCategory)
                {
                    LabelWithCategory thisItem = (LabelWithCategory)anItem;

                    if ((thisItem.Category.parent == parentQuestion.id) && ((thisItem.Category.required_answer == givenAnswer) == requiresMatch))
                    {
                        toReturn.Add(thisItem);

                        if (ShowChildQuestions(thisItem.Category))
                        {
                            toReturn.AddRange(GetChildQuestionsRecursive(thisItem.Category, ""));
                        }
                    }
                }
                else if (anItem is CallQuestionAnswerDisplay)
                {
                    CallQuestionAnswerDisplay thisItem = (CallQuestionAnswerDisplay)anItem;

                    if ((thisItem.Question.parent == parentQuestion.id) && ((thisItem.Question.required_answer == givenAnswer) == requiresMatch))
                    {
                        toReturn.Add(thisItem);

                        if (ShowChildQuestions(thisItem.Question))
                        {
                            toReturn.AddRange(GetChildQuestionsRecursive(thisItem.Question, ""));
                        }
                    }
                }
                else
                {
                    throw new Exception("Unitialized type in formControls array. (Programmer error.)");
                }
            }

            return toReturn;
        }

        /// <summary>
        /// If the question is a fork, returns false. If not, checks to see if it has any child questions.
        /// </summary>
        /// <param name="parentQuestion"></param>
        /// <returns></returns>
        private bool ShowChildQuestions(question parentQuestion)
        {
            if (parentQuestion.is_fork)
                return false;

            foreach (Control aQuestion in formControls[currentParentCategory.id])
            {
                if (aQuestion is LabelWithCategory)
                {
                    if (((LabelWithCategory)aQuestion).Category.parent == parentQuestion.id)
                        return true;
                }
                else if (aQuestion is CallQuestionAnswerDisplay)
                {
                    if (((CallQuestionAnswerDisplay)aQuestion).Question.parent == parentQuestion.id)
                        return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Returns the bottom edge of the control above the one with the current tabindex
        /// </summary>
        /// <param name="tabIndex"></param>
        /// <returns></returns>
        private int GetTop(int tabIndex)
        {
            if (tabIndex > 0)
                return formControls[currentParentCategory.id][tabIndex - 1].Bottom;
            else
                return 0;
        }

        /// <summary>
        /// Not in use - resizes the label so that it encompasses it's category
        /// </summary>
        private void ResizeCurrentCategoryLabel()
        {
            Controls["lbl" + questionCount].Height = lastAdded.Bottom - Controls["lbl" + questionCount].Top + 2;
            Controls["lbl" + questionCount].SendToBack();
        }

        private void AddCategoryLabel(question category, bool hidden)
        {
            int lastBottom;
            LabelWithCategory toAdd = new LabelWithCategory();

            if (lastAdded == null)
                lastBottom = 0;
            else
                lastBottom = lastAdded.Bottom;

            toAdd.Category = category;

            toAdd.Location = new Point(DEFAULTX + (DEFAULTINDENT * displayDepth), lastBottom + CATEGORYSPACER);
            toAdd.Name = "lbl" + questionCount;
            
            toAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toAdd.BorderStyle = BorderStyle.FixedSingle;
            toAdd.Text = category.text;
            toAdd.BackColor = Color.SteelBlue; // System.Drawing.SystemColors.Control;
            toAdd.TextAlign = ContentAlignment.TopLeft;
            toAdd.Padding = new Padding(5);
            toAdd.Font = new Font(new FontFamily("Arial"), 10.0f, FontStyle.Bold);
            toAdd.TabIndex = controlCount;
            toAdd.ForeColor = Color.White;
            toAdd.IsHidden = hidden;

            toAdd.Size = new Size(Width - DEFAULTX - 15 - (DEFAULTINDENT * displayDepth), toAdd.DefaultHeight);

            controlCount++;
            lastAdded = toAdd;
            pnlControls.Controls.Add(toAdd);
            formControls[currentParentCategory.id].Add(toAdd);
        }

        class LabelWithCategory : Label
        {
            public question Category;
            public bool IsHidden;
            public int DisplayDepth;

            public int DefaultHeight
            {
                get
                {
                    if (IsHidden)
                        return 0;
                    else
                        return 32;
                }
            }
        }
    }
}
