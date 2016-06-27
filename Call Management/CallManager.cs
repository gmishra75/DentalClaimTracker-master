using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace C_DentalClaimTracker
{
    public partial class CallManager : UserControl
    {
        private bool _IsCallInProgress;
        private bool _IsCallOnHold;
        private bool OnHoldIsDrawn;
        private List<question> _questions;
        private claim _claim;
        private List<call> _pastCalls;
        private call _currentCall;
        private Panel currentChoicePanel;
        private CallTreeQuestionNode currentQuestionNode;
        private CallTreeCallNode currentCallNode;
        private bool currentChoiceIsDirty;
        private DateTime onHoldStarted;
        int _numQuestionsAnswered;

        public CallManager()
        {
            _IsCallInProgress = false;
            _IsCallOnHold = false;
            OnHoldIsDrawn = false;
            currentChoiceIsDirty = false;
            currentCallNode = null;
            currentQuestionNode = null;
            onHoldStarted = DateTime.MinValue;
            _questions = new List<question>();
            _pastCalls = new List<call>();
            InitializeComponent();
            this.tvwCall.LineColor = SystemColors.GrayText;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        public bool IsCallInProgress
        {
            get { return _IsCallInProgress; }
            private set { _IsCallInProgress = value; }
        }

        public bool IsCallOnHold
        {
            get { return _IsCallOnHold; }
            private set { _IsCallOnHold = value; }
        }

        public call CurrentCall
        {
            get { return _currentCall; }
            private set { _currentCall = value; }
        }

        public List<call> PastCalls
        {
            get { return _pastCalls; }
        }

        public List<question> Questions
        {
            get { return Claim.Questions; }
        }

        public claim Claim
        {
            get { return this._claim; }
            private set { this._claim = value; }
        }

        public bool NotesPanelVisible
        {
            get { return pnlNotes.Visible; }
            set
            {
                pnlNotes.Visible = value;
                splCallManager.Visible = value;
            }
        }

        public bool CallControlsVisible
        {
            get { return pnlCallControls.Visible; }
            set { pnlCallControls.Visible = value; }
        }

        public void LoadClaim(claim claim)
        {
            Claim = claim;

            tvwCall.Nodes.Clear();

            _pastCalls = Claim.GetPastCalls(false);

            TreeNode previousCallsNode = new TreeNode("Previous Calls");
            previousCallsNode.ImageIndex = 1; 
            previousCallsNode.SelectedImageIndex = 1;
            tvwCall.Nodes.Add(previousCallsNode);

            foreach (call call in PastCalls)
            {
                AddCallToTree(call, previousCallsNode);
            }

            notesGrid.LoadNotes(claim);
        }

        private void AddCallToTree(call call, TreeNode parentNode)
        {
            // Add Call Node
            CallTreeCallNode callNode = new CallTreeCallNode(call);
            callNode.ImageIndex = 0; 
            callNode.SelectedImageIndex = 0;

            parentNode.Nodes.Add(callNode);

            List<CallQuestion> callQuestions = call.GetCallQuestions();

            foreach (CallQuestion cq in callQuestions)
            {
                if (cq.IsAnswered)
                {
                    AddQuestionToTree(cq, callNode);
                }
            }
        }

        private void AddQuestionToTree(question question, TreeNode parentNode)
        {
            CallQuestion callQuestion = new CallQuestion(question, CurrentCall);
            AddQuestionToTree(callQuestion, parentNode);
        }

        private void AddQuestionToTree(CallQuestion callQuestion, TreeNode parentNode)
        {
            CallTreeQuestionNode newNode = new CallTreeQuestionNode(callQuestion.Question);            
            if (callQuestion.IsAnswered)
            {
                if (callQuestion.Question.type == question.QuestionTypes.Category)
                {
                    newNode.ImageIndex = 2;
                    newNode.SelectedImageIndex = 2;
                }
                else
                {
                    newNode.ImageIndex = 4;
                    newNode.SelectedImageIndex = 4;
                }

                if (callQuestion.Choice != null)
                {
                    newNode.Choice = callQuestion.Choice;
                }
                else if (callQuestion.Question.type != question.QuestionTypes.Category) 
                { }
            }
            else
            {
                if (callQuestion.Question.type == question.QuestionTypes.Category)
                {
                    newNode.ImageIndex = 1;
                    newNode.SelectedImageIndex = 1;
                }
                else
                {
                    newNode.ImageIndex = 3;
                    newNode.SelectedImageIndex = 3;
                }
            }

            newNode.Text = callQuestion.Question.text;

            if (newNode.Choice != null)
            {
                if (newNode.Question.type == question.QuestionTypes.YesNo)
                {
                    if (newNode.Choice.answer == true.ToString())
                    {
                        newNode.Text += ": Yes";
                    }
                    else if (newNode.Choice.answer == false.ToString())
                    {
                        newNode.Text += ": No";
                    }
                }
                else
                {
                    newNode.Text += ": " + newNode.Choice.answer;
                }
            }

            newNode.Name = callQuestion.Question.id.ToString();

            if (parentNode == null)
            {
                tvwCall.Nodes.Add(newNode);
            }
            else
            {
                parentNode.Nodes.Add(newNode);
            }

            foreach (CallQuestion cq in callQuestion.SubQuestions)
            {
                if (!String.IsNullOrEmpty(cq.Question.required_answer))
                {
                    if (!IsCallInProgress)
                    {
                        if (cq.IsAnswered)
                            AddQuestionToTree(cq, newNode);
                    }
                    else
                    {
                        if ((callQuestion.Choice != null) && (callQuestion.Choice.answer == cq.Question.required_answer))
                        {
                            AddQuestionToTree(cq, newNode);
                        }
                    }
                }
                else
                {
                    if (!IsCallInProgress)
                    {
                        if (cq.IsAnswered == true)
                        {
                            // If the parent question is answered then subquestions must be also
                            // This means a new call will load all questions, but existing calls 
                            // will only load questions that have been answered    

                            AddQuestionToTree(cq, newNode);
                        }
                    }
                    else
                        AddQuestionToTree(cq, newNode);
                }
            }
        }

        public void InitializeNewCall()
        {
            IsCallInProgress = true;

            btnHoldCall.Enabled = true;

            btnLogCall.Text = "End Call";

            CurrentCall = new call();
            CurrentCall.created_on = DateTime.Now;
            CurrentCall.claim_id = Claim.id;
            CurrentCall.OnHoldSeconds = 0;
            CurrentCall.operatordata = ActiveUser.UserObject.username;
            CurrentCall.updated_on = DateTime.Now;
            CurrentCall.Save();
            currentCallNode = new CallTreeCallNode(CurrentCall);
            currentCallNode.ImageIndex = 5;
            currentCallNode.SelectedImageIndex = 5;

            // Initialize CallTreeView            
            foreach (question q in Questions)
            {
                if (String.IsNullOrEmpty(q.required_answer))
                {
                    AddQuestionToTree(q, (TreeNode)currentCallNode);
                }
            }
            _numQuestionsAnswered = 0;
            tvwCall.Nodes.Add(currentCallNode);
            currentCallNode.NodeFont = new Font(tvwCall.Font, FontStyle.Bold);
            currentCallNode.Expand();
            currentCallNode.EnsureVisible();            

            notesGrid.CurrentCall = CurrentCall;
        }

        /// <summary>
        /// Ends the current call, saving it if necessary. If askForSave is true, it will prompt the user before
        /// saving the call.
        /// </summary>
        /// <param name="askForSave"></param>
        public void TerminateCall(bool askForSave)
        {
            if (CurrentCall != null)
            {
                bool _needsSave = true;
                notesGrid.SaveNote();
                if (askForSave)
                {
                    if (MessageBox.Show(this, "Would you like to save the call in progress?", "Save Current Call", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        DeleteCurrentCall();
                        _needsSave = false;
                    }
                }


                if (_needsSave)
                {
                    CurrentCall.Save();
                }

                
                btnLogCall.Text = "Log Call";
                currentCallNode.NodeFont = new Font(tvwCall.Font, FontStyle.Regular);
                currentCallNode.ImageIndex = 0;
                currentCallNode.SelectedImageIndex = 0;
            }

            IsCallInProgress = false;
            btnHoldCall.Enabled = false;
            notesGrid.CurrentCall = null;
        }

        private void DeleteCurrentCall()
        {
            CurrentCall.Delete();
            CurrentCall = null;
            tvwCall.Nodes.Remove(currentCallNode);
        }

        private void pnlCallControls_Resize(object sender, EventArgs e)
        {
            // Center the two buttons on the bottom of the control
            //btnLogCall.Left = pnlCallControls.Width / 2 - btnLogCall.Width - 5;
            //btnHoldCall.Left = pnlCallControls.Width / 2 + 5;
        }

        private void btnLogCall_Click(object sender, EventArgs e)
        {
            if (!IsCallInProgress)
            {
                InitializeNewCall();
            }
            else
            {
                TerminateCall(false);
            }
        }

        private void btnHoldCall_Click(object sender, EventArgs e)
        {
            if (IsCallOnHold)
            {
                IsCallOnHold = false;
                btnHoldCall.Text = "Hold Call";
                tvwCall.Refresh();
                tmrOnHold.Enabled = false;

                if (CurrentCall != null)
                {
                    TimeSpan holdTime = DateTime.Now.Subtract(onHoldStarted);
                    CurrentCall.OnHoldSeconds += (int)holdTime.TotalSeconds;
                }
            }
            else
            {
                IsCallOnHold = true;
                btnHoldCall.Text = "Resume";
                tmrOnHold.Enabled = true;
                onHoldStarted = DateTime.Now;
            }
        }

        private void tmrOnHold_Tick(object sender, EventArgs e)
        {
            if (OnHoldIsDrawn)
            {
                tvwCall.Refresh();
                OnHoldIsDrawn = false;
            }
            else
            {
                TimeSpan holdTime = DateTime.Now.Subtract(onHoldStarted);
                Graphics g = tvwCall.CreateGraphics();
                Font DrawFont = new Font(this.Font.FontFamily.Name, 48.0F, FontStyle.Bold, GraphicsUnit.Pixel);
                SolidBrush DrawBrush = new SolidBrush(Color.FromArgb(90, Color.Blue));
                String DrawText = "On-Hold " + FormatSeconds((int)holdTime.TotalSeconds);
                SizeF DrawSize = g.MeasureString(DrawText, DrawFont);
                float x = tvwCall.Width / 2 - DrawSize.Width / 2;
                float y = tvwCall.Height / 2 - DrawSize.Height / 2;

                tvwCall.Refresh();
                g.DrawString(DrawText, DrawFont, DrawBrush, x, y);
                g.Flush();
                OnHoldIsDrawn = true;
            }
        }

        private string FormatSeconds(int secs)
        {
            if (secs < 10)
            {
                return "0:0" + secs.ToString();
            }
            else if (secs < 60)
            {
                return "0:" + secs.ToString();
            }
            else
            {
                int rem;
                int mins = Math.DivRem(secs, 60, out rem);

                if (rem < 10)
                {
                    return mins.ToString() + ":0" + rem.ToString();
                }
                else
                {
                    return mins.ToString() + ":" + rem.ToString();
                }
            }
        }

        private void tvwCall_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            const int SPACE_IL = 3;  // space between Image and Label

            // we only do additional drawing
            e.DrawDefault = true;

            if (this.tvwCall.ShowLines && this.imgCallIcons != null && e.Node.ImageIndex >= this.imgCallIcons.Images.Count)
            {
                // Image size
                int imgW = this.imgCallIcons.ImageSize.Width;
                int imgH = this.imgCallIcons.ImageSize.Height;

                // Image center
                int xPos = e.Node.Bounds.Left - SPACE_IL - imgW / 2;
                int yPos = (e.Node.Bounds.Top + e.Node.Bounds.Bottom) / 2;

                using (Pen p = new Pen(this.tvwCall.LineColor, 1))
                {
                    p.DashStyle = DashStyle.Dot;
                    // draw the horizontal missing treeline
                    e.Graphics.DrawLine(p, (xPos - imgW / 2), yPos, (xPos + imgW / 2), yPos);

                    if (!this.tvwCall.CheckBoxes && e.Node.IsExpanded)
                    {
                        // draw the vertical missing treeline
                        e.Graphics.DrawLine(p, xPos, yPos, xPos, (yPos + imgW / 2));
                    }
                }
            }
        }

        private void tvwCall_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            if (!this.tvwCall.CheckBoxes && this.imgCallIcons != null && e.Node.ImageIndex >= this.imgCallIcons.Images.Count)
            {
                this.tvwCall.Invalidate(e.Node.Bounds);
            }
        }

        private void tvwCall_AfterSelect(object sender, TreeViewEventArgs e)
        {
            CallTreeQuestionNode qNode = tvwCall.SelectedNode as CallTreeQuestionNode;
            currentQuestionNode = null;

            if (qNode != null)
            {
                if (!pnlDataEntry.Visible)
                {
                    pnlDataEntry.Visible = true;
                }

                if (currentChoicePanel != null)
                {
                    currentChoicePanel.Visible = false;
                }

                lblDataDescription.Text = qNode.Question.popup_question_text;

                switch (qNode.Question.type)
                {
                    case question.QuestionTypes.Category:
                        currentChoicePanel = null;
                        pnlDataEntry.Visible = false;
                        break;
                    case question.QuestionTypes.Date:
                        currentChoicePanel = pnlChoiceDate;
                        pnlDataEntry.Height = 66;
                        if (qNode.Choice != null)
                        {
                            DateTime choiceDate;
                            if (DateTime.TryParse(qNode.Choice.answer, out choiceDate))
                            {
                                ctlDate.CurrentDate = choiceDate;
                            }
                            else if (qNode.Choice.answer == "")
                                ctlDate.CurrentDate = null;
                            else
                                ctlDate.CurrentDate = DateTime.Now;
                        }
                        else
                        {
                            ctlDate.SetDefaultDate(DateTime.Now);
                        }
                        break;
                    case question.QuestionTypes.LargeText:
                        currentChoicePanel = pnlChoiceLargeText;
                        pnlDataEntry.Height = 125;
                        if (qNode.Choice != null)
                        {
                            txtLarge.Text = qNode.Choice.answer;
                        }
                        else
                        {
                            txtLarge.Text = "";
                        }
                        break;
                    case question.QuestionTypes.MultipleChoice:
                        currentChoicePanel = pnlChoiceMultiple;
                        pnlDataEntry.Height = 100;
                        cmbMultipleChoice.Items.Clear();

                        // Use ComboBox
                        foreach (multiple_choice_answer mca in qNode.Question.MultipleChoiceAnswers)
                        {
                            cmbMultipleChoice.Items.Add(mca);
                        }

                        if (qNode.Choice != null)
                        {
                            for (int i = 0; i < cmbMultipleChoice.Items.Count; i++)
                            {
                                if (cmbMultipleChoice.Items[i].ToString() == qNode.Choice.answer)
                                {
                                    cmbMultipleChoice.SelectedIndex = i;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            cmbMultipleChoice.SelectedIndex = -1;
                        }



                        break;
                    case question.QuestionTypes.NormalText:
                        currentChoicePanel = pnlChoiceNormalText;
                        pnlDataEntry.Height = 66;
                        if (qNode.Choice != null)
                        {
                            txtNormal.Text = qNode.Choice.answer;
                        }
                        else
                        {
                            txtNormal.Text = "";
                        }
                        break;
                    case question.QuestionTypes.Numeric:
                        currentChoicePanel = pnlChoiceNumeric;
                        pnlDataEntry.Height = 66;
                        if (qNode.Choice != null)
                        {
                            if (CommonFunctions.IsNumeric(qNode.Choice.answer))
                            {
                                numNumber.Value = Convert.ToDecimal(qNode.Choice.answer);
                            }
                            else
                            {
                                numNumber.Value = 0;
                            }
                        }
                        else
                        {
                            numNumber.Value = 0;
                        }
                        break;
                    case question.QuestionTypes.SmallText:
                        currentChoicePanel = pnlChoiceSmallText;
                        pnlDataEntry.Height = 100;
                        if (qNode.Choice != null)
                        {
                            txtSmall.Text = qNode.Choice.answer;
                        }
                        else
                        {
                            txtSmall.Text = "";
                        }
                        break;
                    case question.QuestionTypes.YesNo:
                        currentChoicePanel = pnlChoiceYesNo;
                        pnlDataEntry.Height = 84;
                        if (qNode.Choice != null)
                        {
                            bool YesNo = CommonFunctions.FromYesNo(qNode.Choice.answer);
                            if (YesNo)
                            {
                                radYes.Checked = true;
                            }
                            else
                            {
                                radNo.Checked = true;
                            }
                        }
                        else
                        {
                            radYes.Checked = false;
                            radNo.Checked = false;
                        }
                        break;
                    default:
                        if (pnlDataEntry.Visible)
                        {
                            pnlDataEntry.Visible = false;
                        }
                        currentChoicePanel = null;
                        break;
                }

                if (qNode.Choice == null)
                    cmdClearAnswer.Visible = false;
                else
                    cmdClearAnswer.Visible = false;

                if (currentChoicePanel != null)
                {
                    currentChoicePanel.Visible = true;
                    currentQuestionNode = qNode;
                }
            }
            else
            {
                pnlDataEntry.Visible = false;
                currentQuestionNode = null;
            }
            tvwCall.SelectedNode.EnsureVisible();
        }

        private choice GetNewCallChoice()
        {
            if (CurrentCall == null)
                return null;

            choice newChoice = new choice();
            newChoice.created_at = DateTime.Now;
            newChoice.operatordata = ActiveUser.UserObject.username;
            newChoice.LinkedCall = CurrentCall;

            if (currentQuestionNode != null)
            {
                newChoice.LinkedQuestion = currentQuestionNode.Question;
            }

            return newChoice;
        }

        private void MarkParentAnswered(CallTreeQuestionNode node, bool isAnswered)
        {
            CallTreeQuestionNode parentNode = node.Parent as CallTreeQuestionNode;
            if (parentNode != null)
            {
                int categoryIndex;
                int standardIndex;
                if (isAnswered)
                {
                    categoryIndex = 2;
                    standardIndex = 4;
                }
                else
                {
                    categoryIndex = 1;
                    standardIndex = 3;
                }

                if (parentNode.Question.type == question.QuestionTypes.Category)
                {
                    parentNode.ImageIndex = categoryIndex;
                    parentNode.SelectedImageIndex = categoryIndex;
                }
                else
                {
                    parentNode.ImageIndex = standardIndex;
                    parentNode.SelectedImageIndex = standardIndex;
                }


                if (parentNode.Parent != null)
                {
                    if (isAnswered)
                        MarkParentAnswered(parentNode, true);
                    else
                        UpdateParentImage(parentNode);
                }
            }
        }

        private void UpdateParentImage(CallTreeQuestionNode node)
        {
            CallTreeQuestionNode parentNode = node.Parent as CallTreeQuestionNode;

            if (parentNode != null)
            {
                bool hasAnsweredQuestions = false;

                foreach (CallTreeQuestionNode aNode in parentNode.Nodes)
                {
                    if (aNode.Choice != null)
                    {
                        hasAnsweredQuestions = true;
                        break;
                    }
                    else if (aNode.Question.type == question.QuestionTypes.Category)
                    {
                        if (aNode.ImageIndex == 2)
                        {
                            hasAnsweredQuestions = true;
                            break;
                        }
                    }
                }

                if (parentNode.Question.type != question.QuestionTypes.Category)
                {
                    if (parentNode.Choice != null)
                        hasAnsweredQuestions = true;
                }

                MarkParentAnswered(node, hasAnsweredQuestions);
            }
        }

        private void UpdateAnswer(string answer)
        {
            if (currentQuestionNode != null)
            {
                if (currentQuestionNode.Choice != null)
                {
                    if (currentQuestionNode.Choice.LinkedCall.ReadOnly)
                        return; // Cancel edit (this is a past call)
                }
                else
                {
                    currentQuestionNode.Choice = GetNewCallChoice();
                    _numQuestionsAnswered++;
                }
                

                currentQuestionNode.Choice.answer = answer;
                if (currentQuestionNode.Question.type == question.QuestionTypes.YesNo)
                {
                    if (currentQuestionNode.Choice.answer == true.ToString())
                    {
                        answer = "Yes";
                        currentQuestionNode.Text = currentQuestionNode.Question.text + ": Yes";
                    }
                    else if (currentQuestionNode.Choice.answer == false.ToString())
                    {
                        answer = "No";
                        currentQuestionNode.Text = currentQuestionNode.Question.text + ": No";
                    }
                }
                else
                {
                    currentQuestionNode.Text = currentQuestionNode.Question.text + ": " + currentQuestionNode.Choice.answer;
                }
                currentQuestionNode.ImageIndex = 4;
                currentQuestionNode.SelectedImageIndex = 4;
                currentQuestionNode.Choice.Save();
                // currentChoiceIsDirty = true;

                if (currentQuestionNode.Parent != null)
                {
                    MarkParentAnswered(currentQuestionNode, true);
                }
                cmdClearAnswer.Visible = false;
                ShowHideRequiredAnswerNodes(answer);
            }
        }

        private void ShowHideRequiredAnswerNodes(string answer)
        {
            // check if we need to add some required answer nodes
            if (currentQuestionNode.Nodes.Count != currentQuestionNode.Question.SubQuestions.Count)
            {
                // This node may have required answer subquestions
                foreach (question q in currentQuestionNode.Question.SubQuestions)
                {
                    if (q.required_answer.ToUpper() == answer.ToUpper())
                    {
                        AddQuestionToTree(new CallQuestion(q, CurrentCall), currentQuestionNode);
                        break;
                    }
                }
            }

            // check if we have to remove some required answer nodes
            List<CallTreeQuestionNode> removeNodes = new List<CallTreeQuestionNode>();
            foreach (CallTreeQuestionNode qNode in currentQuestionNode.Nodes)
            {
                if (!String.IsNullOrEmpty(qNode.Question.required_answer))
                {
                    if (qNode.Question.required_answer.ToUpper() != answer.ToUpper())
                    {
                        removeNodes.Add(qNode);
                    }
                }
            }
            foreach (CallTreeQuestionNode qNode in removeNodes)
            {
                currentQuestionNode.Nodes.Remove(qNode);
            }
        }

        private void txtLarge_TextChanged(object sender, EventArgs e)
        {
            if (currentChoicePanel == pnlChoiceLargeText)
            {
                UpdateAnswer(txtLarge.Text);
            }
        }

        private void txtNormal_TextChanged(object sender, EventArgs e)
        {
            if (currentChoicePanel == pnlChoiceNormalText)
            {
                UpdateAnswer(txtNormal.Text);
            }
        }

        private void txtSmall_TextChanged(object sender, EventArgs e)
        {
            if (currentChoicePanel == pnlChoiceSmallText)
            {
                UpdateAnswer(txtSmall.Text);
            }
        }

        private void radYes_CheckedChanged(object sender, EventArgs e)
        {
            if (currentChoicePanel == pnlChoiceYesNo)
            {
                if (radYes.Checked)
                {
                    UpdateAnswer(true.ToString());
                }
            }
        }

        private void radNo_CheckedChanged(object sender, EventArgs e)
        {
            if (currentChoicePanel == pnlChoiceYesNo)
            {
                if (radNo.Checked)
                {
                    UpdateAnswer(false.ToString());
                }
            }
        }

        private void numNumber_ValueChanged(object sender, EventArgs e)
        {
            if (currentChoicePanel == pnlChoiceNumeric)
            {
                UpdateAnswer(numNumber.Value.ToString());
            }
        }

        private void cmbMultipleChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentChoicePanel == pnlChoiceMultiple)
            {
                UpdateAnswer(cmbMultipleChoice.SelectedItem.ToString());
            }
        }

        private void tvwCall_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (currentChoiceIsDirty)
            {
                if (currentQuestionNode != null)
                {
                    currentQuestionNode.Choice.Save();
                }

                currentChoiceIsDirty = false;
            }
        }

        private void notesGrid_NewNotes(object sender, EventArgs e)
        {
            if (!IsCallInProgress)
            {
                InitializeNewCall();
            }
        }

        private void ctlDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateAnswer(ctlDate.CurrentDateText);
        }

        private void cmdClearAnswer_Click(object sender, EventArgs e)
        {
            ClearInputBoxes();
            currentQuestionNode.Choice.Delete();
            currentQuestionNode.Choice = null;
            currentQuestionNode.Text = currentQuestionNode.Question.text;
            currentQuestionNode.ImageIndex = 3;
            currentQuestionNode.SelectedImageIndex = 3;
            cmdClearAnswer.Visible = false;
            _numQuestionsAnswered--;
            
            ShowHideRequiredAnswerNodes("");
            UpdateParentImage(currentQuestionNode);
        }

        private void ClearInputBoxes()
        {
            txtLarge.Text = "";
            txtNormal.Text = "";
            txtSmall.Text = "";
            radNo.Checked = false;
            radYes.Checked = false;
            cmbMultipleChoice.SelectedIndex = -1;
            ctlDate.Clear();
            numNumber.Value = 0;
        }
    }
}
