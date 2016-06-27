using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmEditQuestionTree : Form
    {
        public enum SetRevisitDateOptions
        {
            NotSet = -1,
            Automated = 0,
            User = 1,
            DoNotSet = 2
        }

        private question _currentQuestion;
        private CallTreeQuestionNode _cutNode = null;
        private bool _dataChanged = false;

        public frmEditQuestionTree()
        {
            InitializeComponent();

            cmbQuestionType.Items.Clear();
            cmbQuestionType.Items.Add("Category");
            cmbQuestionType.Items.Add("Yes / No");
            cmbQuestionType.Items.Add("Multiple Choice");
            cmbQuestionType.Items.Add("Normal Text");
            cmbQuestionType.Items.Add("Small Text");
            cmbQuestionType.Items.Add("Large Text");
            cmbQuestionType.Items.Add("Date");
            cmbQuestionType.Items.Add("Numeric");
            cmbQuestionType.Items.Add("Header");
            cmbQuestionType.Items.Add("Spacer");

            InitializeStatusDropdown();
        }

        private void InitializeStatusDropdown()
        {
            cmbStatusDropdown.Items.Add("No linked status");

            claim_status cs = new claim_status();
            DataTable allcs = cs.GetAllData("orderid");
            
            foreach (DataRow aRow in allcs.Rows)
            {
                cs = new claim_status();
                
                cs.Load(aRow);

                cmbStatusDropdown.Items.Add(cs);
            }
        }

        private void frmEditQuestionTree_Load(object sender, EventArgs e)
        {
            InitializeCallTree();
            WindowState = FormWindowState.Maximized;
        }

        private void InitializeCallTree(CallTreeQuestionNode selectNode)
        {
            claim c = new claim();
            List<question> Questions = c.Questions;
            trvDisplay.Nodes.Clear();
            trvDisplay.Nodes.Add("Base");
            trvDisplay.Nodes[0].ImageIndex = 0;
            trvDisplay.Nodes[0].SelectedImageIndex = 0;
            // Initialize CallTreeView            
            foreach (question q in Questions)
            {
                if (String.IsNullOrEmpty(q.required_answer))
                {
                    AddQuestionToTree(q, trvDisplay.Nodes[0]);
                }
            }


            trvDisplay.Nodes[0].Expand();

            if (selectNode != null)
            {
                // Find the old node somehow
                FindNode(selectNode, trvDisplay.Nodes[0]);
            }
        }

        private void FindNode(CallTreeQuestionNode selectNode, TreeNode currentSearchNode)
        {
            if (trvDisplay.SelectedNode == null)
            {
                foreach (CallTreeQuestionNode tn in currentSearchNode.Nodes)
                {
                    if (tn.Question.id == selectNode.Question.id)
                    {
                        trvDisplay.SelectedNode = tn;
                        break;
                    }

                    if (tn.Nodes.Count > 0)
                        FindNode(selectNode, tn);
                }
            }
        }

        private void InitializeCallTree()
        {
            InitializeCallTree(null);
        }

        private CallTreeQuestionNode AddQuestionToTree(question questionToAdd, TreeNode parentNode)
        {
            CallTreeQuestionNode newNode = new CallTreeQuestionNode(questionToAdd);

            newNode = SetQuestionImage(questionToAdd, newNode);
            newNode.Text = questionToAdd.text;
            newNode.Name = questionToAdd.id.ToString();

            if (parentNode == null)
            {
                trvDisplay.Nodes.Add(newNode);
            }
            else
            {
                parentNode.Nodes.Add(newNode);
            }

            foreach (question cq in questionToAdd.SubQuestions)
            {
                AddQuestionToTree(cq, newNode);
            }

            return newNode;
        }

        private CallTreeQuestionNode SetQuestionImage(question questionToAdd, CallTreeQuestionNode newNode)
        {
            if (System.Convert.ToBoolean(questionToAdd.is_fork))
            {
                newNode.ImageIndex = 5;
                newNode.SelectedImageIndex = 5;
            }
            else if (questionToAdd.type == question.QuestionTypes.Category)
            {
                newNode.ImageIndex = 1;
                newNode.SelectedImageIndex = 1;
            }
            else
            {
                newNode.ImageIndex = 3;
                newNode.SelectedImageIndex = 3;
            }

            return newNode;
        }

        private void trvDisplay_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (trvDisplay.SelectedNode is CallTreeQuestionNode)
            {
                CallTreeQuestionNode cn = (CallTreeQuestionNode)trvDisplay.SelectedNode;
                _currentQuestion = cn.Question;
                LoadCurrentQuestion();
                pnlDetailsPanel.Enabled = true;
                EnableOptionsPanel(true);
            }
            else
            {
                pnlDetailsPanel.Enabled = false;
                EnableOptionsPanel(false);
            }
            QuestionChanged(false);
        }

        private void EnableOptionsPanel(bool isEnabled)
        {
            cmdMoveUp.Enabled = isEnabled;
            cmdMoveDown.Enabled = isEnabled;
            cmdDelete.Enabled = isEnabled;
            cmdCut.Enabled = isEnabled;
        }

        private void LoadCurrentQuestion()
        {
            txtQuestionText.Text = _currentQuestion.popup_question_text;
            txtTreeText.Text = _currentQuestion.text;
            radFork.Checked = _currentQuestion.is_fork;
            radCallClassification.Checked = _currentQuestion.is_classification;
            if ((!radFork.Checked) && (!radCallClassification.Checked))
                radStandard.Checked = true;
            cmbQuestionType.SelectedIndex = (int)_currentQuestion.type - 1;
            InitialRequiredAnswer(_currentQuestion);
            
                try
                {
                    nmbDefaultRevisitDate.Value = Convert.ToInt32(_currentQuestion.default_revisit_date);
                    if (_currentQuestion.linked_status > 0)
                    {
                        try
                        {
                            cmbStatusDropdown.SelectedIndex = new claim_status(_currentQuestion.linked_status).orderid + 1;
                        }
                        catch {
                            LoggingHelper.Log("An invalid status was assigned to a question in frmEditQuestionTree.LoadCurrentQuestion().", LogSeverity.Error);
                        }
                    }
                    else
                    {
                        cmbStatusDropdown.SelectedIndex = 0;
                    }


                    if ((int)_currentQuestion.set_revisit_date >= 0)
                        cmbRevisitDateOptions.SelectedIndex = (int)_currentQuestion.set_revisit_date;
                    else
                        cmbRevisitDateOptions.SelectedIndex = cmbRevisitDateOptions.Items.Count - 1;
                }
                catch (Exception err)
                {
                    LoggingHelper.Log("Error loading classification data in frmEditQuestionTree.LoadCurrentQuestion.", LogSeverity.Error, err, false);
                    MessageBox.Show(this, "An error occurred loading classification specific data.");
                }

                QuestionChanged(false);
        }

        private void InitialRequiredAnswer(question toCheck)
        {
            bool isRequired = toCheck.ParentIsFork;
            cmbRequiredAnswer.Items.Clear();
            if (isRequired)
            {
                InitializeRequiredAnswerDropDown(toCheck);
            }

            pnlForkOptions.Enabled = isRequired;
        }

        private void InitializeRequiredAnswerDropDown(question toInitialize)
        {
            cmbRequiredAnswer.Items.Add("No answer required");

            if (toInitialize.ParentQuestion.type == question.QuestionTypes.MultipleChoice)
            {
                foreach (multiple_choice_answer mca in toInitialize.GetMultipleChoiceAnswers())
                {
                    cmbRequiredAnswer.Items.Add(mca);
                }


                cmbRequiredAnswer.SelectedIndex = cmbRequiredAnswer.FindStringExact(toInitialize.required_answer);
            }
            else if (toInitialize.ParentQuestion.type == question.QuestionTypes.YesNo)
            {
                cmbRequiredAnswer.Items.Add("Yes");
                cmbRequiredAnswer.Items.Add("No");

                try
                {
                    // Temporary structure to deal with the fact that sometime required answer is saved as "true" and other times as "yes"
                    cmbRequiredAnswer.SelectedIndex = cmbRequiredAnswer.FindStringExact(
                        CommonFunctions.ToYesNo(System.Convert.ToBoolean(toInitialize.required_answer)));
                }
                catch
                {
                    cmbRequiredAnswer.SelectedIndex = cmbRequiredAnswer.FindStringExact(toInitialize.required_answer);


                    if (cmbRequiredAnswer.SelectedIndex < 0)
                        cmbRequiredAnswer.SelectedIndex = 0;
                }
            }
            else
            {
                LoggingHelper.Log("Uninitialized question type on a parent that is marked as a fork.", LogSeverity.Critical,
                    new Exception("Uninitialized question type on a parent that is marked as a fork."), true);
            }

            if (cmbRequiredAnswer.SelectedIndex == -1)
                cmbRequiredAnswer.SelectedIndex = 0;
        }

        private void MakeQuestionTextVisible(question.QuestionTypes type)
        {

            if ((type == question.QuestionTypes.Category) || (type == question.QuestionTypes.Header) ||
                (type == question.QuestionTypes.Spacer))
            {
                txtQuestionText.Enabled = false;

            }
            else
            {
                txtQuestionText.Enabled = true;
            }

            if (type == question.QuestionTypes.Spacer)
            {
                txtTreeText.Enabled = false;
                txtTreeText.Text = "(Spacer)";
            }
            else
            {
                txtTreeText.Enabled = true;
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbQuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbQuestionType.SelectedIndex > -1)
            {
                question.QuestionTypes questionType = (question.QuestionTypes)(cmbQuestionType.SelectedIndex + 1);

                if ((questionType == question.QuestionTypes.YesNo) || (questionType == question.QuestionTypes.MultipleChoice))
                {
                    radFork.Enabled = true;
                }
                else
                {
                    radFork.Enabled = false;
                    radFork.Checked = false;
                }

                MakeQuestionTextVisible(questionType);
                lnkEditMultipleChoiceOptions.Enabled = questionType == question.QuestionTypes.MultipleChoice;
                QuestionChanged(true);
            }
            
        }

        private void QuestionChanged(bool changed)
        {
            _dataChanged = changed;

            if (changed)
                pnlSaveCancel.BackColor = Color.PaleGoldenrod;
            else
                pnlSaveCancel.BackColor = DefaultBackColor;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            LoadCurrentQuestion();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (_currentQuestion != null)
            {
                string saveSuccess = ValidateSave();

                if (saveSuccess == string.Empty)
                {
                    _currentQuestion.popup_question_text = txtQuestionText.Text;
                    _currentQuestion.text = txtTreeText.Text;
                    _currentQuestion.is_fork = radFork.Checked;
                    _currentQuestion.type = (question.QuestionTypes)cmbQuestionType.SelectedIndex + 1;
                    _currentQuestion.required_answer = cmbRequiredAnswer.Text;

                    if ((_currentQuestion.type == question.QuestionTypes.Header) || (_currentQuestion.type == question.QuestionTypes.Spacer))
                    {
                        // Headers and spacers are forced into being classifications
                        radCallClassification.Checked = true;
                    }
                    else if (radCallClassification.Checked)
                    {

                        if (cmbStatusDropdown.SelectedIndex > 0)
                        {
                            _currentQuestion.linked_status = ((claim_status)cmbStatusDropdown.SelectedItem).id;
                            // Go ahead and change the children status' here as well

                            foreach (question q in _currentQuestion.GetSubClassifications())
                            {
                                SetStatusRevisitAndChildren(q, _currentQuestion);
                            }
                        }
                        else
                        {
                            _currentQuestion.linked_status = -1;
                        }
                        if (cmbRevisitDateOptions.SelectedIndex >= 0)
                        {
                            _currentQuestion.set_revisit_date = (frmEditQuestionTree.SetRevisitDateOptions)cmbRevisitDateOptions.SelectedIndex;
                            _currentQuestion.default_revisit_date = Convert.ToInt32(nmbDefaultRevisitDate.Value);
                        }

                        SetChildrenStatusRevisit(_currentQuestion);
                    }

                    _currentQuestion.is_classification = radCallClassification.Checked;

                    _currentQuestion.Save();
                    ((CallTreeQuestionNode)trvDisplay.SelectedNode).Question = _currentQuestion;
                    QuestionChanged(false);
                    SetQuestionImage(_currentQuestion, (CallTreeQuestionNode)trvDisplay.SelectedNode);
                    trvDisplay.SelectedNode.Text = txtTreeText.Text;
                }
                else
                {
                    MessageBox.Show(saveSuccess);
                }
            }
        }

        private void SetStatusRevisitAndChildren(question childQuestion, question parentQuestion)
        {
            if (childQuestion.linked_status <= 0)
                childQuestion.linked_status = parentQuestion.linked_status;
            
            if (childQuestion.set_revisit_date <= 0)
                childQuestion.set_revisit_date = parentQuestion.set_revisit_date;
            
            if (childQuestion.default_revisit_date == 0)
                childQuestion.default_revisit_date = parentQuestion.default_revisit_date;

            childQuestion.Save();
            foreach (question subs in childQuestion.GetSubClassifications())
            {
                SetStatusRevisitAndChildren(subs, parentQuestion);
            }
        }

        /// <summary>
        /// Iterates through children of the selected question and looks for classifications that do not have a status or a revisit date
        /// set, and then makes it match the current question
        /// </summary>
        /// <param name="_currentQuestion"></param>
        private void SetChildrenStatusRevisit(question _currentQuestion)
        {
            foreach (question q in _currentQuestion.SubCategories())
            {
                if (q.type == question.QuestionTypes.Category)
                    SetChildrenStatusRevisit(q);

                if (q.linked_status <= 0)
                {
                    // Assign the new status here
                    q.linked_status = _currentQuestion.linked_status;
                }

                if (q.set_revisit_date == SetRevisitDateOptions.NotSet)
                {
                    q.set_revisit_date = _currentQuestion.set_revisit_date;
                    q.default_revisit_date = _currentQuestion.default_revisit_date;
                }

                q.Save();
            }
        }

        /// <summary>
        /// Validates the form and returns an error string with all errors. Returns string.empty if valid
        /// </summary>
        /// <returns></returns>
        private string ValidateSave()
        {
            bool valid = true;
            string Problems = "The question can not be saved for the following reason(s): \n";

            if (radCallClassification.Checked)
            {
                if (!CheckValidClassification())
                {
                    valid = false;
                    Problems += "\nThis question can not be marked as 'Classification'. To be valid as a classification, a question " +
                        "must either be at the base level or every parent must be a classification.";
                }
            }

            question.QuestionTypes newType = (question.QuestionTypes)cmbQuestionType.SelectedIndex + 1;

            if ((newType != question.QuestionTypes.Header) && (newType != question.QuestionTypes.Spacer))
            {
                if (txtTreeText.Text == "")
                {
                    valid = false;
                    Problems += "\nPlease enter valid tree text.";
                }

                if (newType != question.QuestionTypes.Category)
                {
                    if (txtQuestionText.Text == "")
                    {
                        valid = false;
                        Problems += "\nPlease enter valid question text.";
                    }
                }

            }

            if (valid)
                return string.Empty;
            else
                return Problems;

        }

        /// <summary>
        /// Verifies that the current questionis allowed to be a classification
        /// </summary>
        /// <returns></returns>
        private bool CheckValidClassification()
        {
            return IsValidClassification(_currentQuestion);
        }

        private bool IsValidClassification(question _currentQuestion)
        {
            if ((_currentQuestion.parent == 0) || (_currentQuestion.parent == -1))
                return true;
            else
            {
                question toCheck = new question(_currentQuestion.parent);

                if (toCheck.is_classification)
                {
                    return IsValidClassification(_currentQuestion.ParentQuestion);
                }
                else
                    return false;

            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Deleting question: " + _currentQuestion.text + "\n\nDeleting this question will also delete all of it's sub-questions. Are " +
                "you sure you want to do this?", "Delete Question?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _currentQuestion.Delete();

                TreeNode toSelect;

                if (trvDisplay.SelectedNode.NextNode != null)
                    toSelect = trvDisplay.SelectedNode.NextNode;
                else if (trvDisplay.SelectedNode.PrevNode != null)
                    toSelect = trvDisplay.SelectedNode.PrevNode;
                else
                    toSelect = trvDisplay.SelectedNode.Parent;

                trvDisplay.SelectedNode.Remove();
                QuestionChanged(false);
                trvDisplay.SelectedNode = toSelect;
            }
        }

        private void cmdAddNew_Click(object sender, EventArgs e)
        {
            question newQuestion = new question();

            newQuestion.type = question.QuestionTypes.Category;
            newQuestion.text = "Type your new question here...";
            newQuestion.order_id = trvDisplay.SelectedNode.Nodes.Count;
            newQuestion.is_classification = false;
            newQuestion.is_fork = false;


            if (trvDisplay.SelectedNode is CallTreeQuestionNode)
            {
                newQuestion.parent = ((CallTreeQuestionNode)trvDisplay.SelectedNode).Question.id;
                question parentQuestion = new question(newQuestion.parent);
                newQuestion.linked_status = parentQuestion.linked_status;
                newQuestion.set_revisit_date = parentQuestion.set_revisit_date;
                newQuestion.default_revisit_date = parentQuestion.default_revisit_date;
            }
            else
            {
                newQuestion.linked_status = 0;
                newQuestion.parent = 0;
            }

            newQuestion.Save();

            trvDisplay.SelectedNode = AddQuestionToTree(newQuestion, trvDisplay.SelectedNode);
            ForceReorderNodes(trvDisplay.SelectedNode);

            txtQuestionText.Focus();
        }

        private void cmdMoveUp_Click(object sender, EventArgs e)
        {
            if (trvDisplay.SelectedNode != null)
            {
                if (trvDisplay.SelectedNode.PrevNode != null)
                {
                    TreeNode parentNode = trvDisplay.SelectedNode.Parent;
                    TreeNode tn = trvDisplay.SelectedNode;
                    int newIndex = tn.Index - 1;

                    trvDisplay.SelectedNode.Remove();

                    parentNode.Nodes.Insert(newIndex, tn);
                    trvDisplay.SelectedNode = tn;

                    ForceReorderNodes(tn);
                }
            }
        }

        private void cmdMoveDown_Click(object sender, EventArgs e)
        {
            if (trvDisplay.SelectedNode != null)
            {
                if (trvDisplay.SelectedNode.NextNode != null)
                {
                    TreeNode parentNode = trvDisplay.SelectedNode.Parent;
                    TreeNode tn = trvDisplay.SelectedNode;
                    int newIndex = tn.Index + 1;

                    trvDisplay.SelectedNode.Remove();

                    parentNode.Nodes.Insert(newIndex, tn);
                    trvDisplay.SelectedNode = tn;

                    ForceReorderNodes(tn);
                }
            }
        }

        /// <summary>
        /// Resave all the questions at the current level so that their order matches the order displayed 
        /// in the question tree
        /// </summary>
        /// <param name="tn"></param>
        private void ForceReorderNodes(TreeNode tn)
        {
            int i = 0;
            foreach (CallTreeQuestionNode aNode in tn.Parent.Nodes)
            {
                aNode.Question.order_id = i;
                aNode.Question.Save();
                i++;
            }

            trvDisplay.SelectedNode = tn;
        }

        private void trvDisplay_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                Point ptClient = new Point(e.X, e.Y);
                TreeNode objDragTargetNode = trvDisplay.GetNodeAt(ptClient);

                if (trvDisplay.SelectedNode != objDragTargetNode)
                    trvDisplay.SelectedNode = objDragTargetNode;

            }
        }

        private void cmdCut_Click(object sender, EventArgs e)
        {
            if (trvDisplay.SelectedNode is CallTreeQuestionNode)
            {
                _cutNode = (CallTreeQuestionNode)trvDisplay.SelectedNode;
                trvDisplay.SelectedNode.Remove();
                EnableCut(false);
            }
        }

        private void cmdPaste_Click(object sender, EventArgs e)
        {
            PasteNode();
        }

        private void PasteNode()
        {
            if (trvDisplay.SelectedNode is CallTreeQuestionNode)
            {
                CallTreeQuestionNode currentNode = (CallTreeQuestionNode)trvDisplay.SelectedNode;

                if (currentNode.Question.type == question.QuestionTypes.Category)
                {
                    trvDisplay.SelectedNode.Nodes.Insert(0, _cutNode);
                    _cutNode.Question.parent = currentNode.Question.id;
                    currentNode.Expand();
                    ForceReorderNodes(_cutNode);
                }
                else
                {
                    trvDisplay.SelectedNode.Parent.Nodes.Insert(0, _cutNode);
                    _cutNode.Question.parent = ((CallTreeQuestionNode)trvDisplay.SelectedNode.Parent).Question.id;

                    ForceReorderNodes(_cutNode);
                }
            }
            else
            {
                trvDisplay.Nodes[0].Nodes.Insert(0, _cutNode);
                _cutNode.Question.parent = 0;

                ForceReorderNodes(_cutNode);
            }
            EnableCut(true);
            _cutNode = null;
        }

        private void EnableCut(bool enable)
        {
            cmdCut.Enabled = enable;
            mnuCut.Enabled = enable;
            cmdPaste.Enabled = !enable;
            mnuPaste.Enabled = !enable;
        }

        private void lnkEditMultipleChoiceOptions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cmdSave.PerformClick();
            frmEditMultipleChoiceQuestions toShow = new frmEditMultipleChoiceQuestions(_currentQuestion);
            toShow.ShowDialog(this);
        }

        private void trvDisplay_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = !RecordChangeOK();
        }

        private bool RecordChangeOK()
        {
            if (_dataChanged)
            {
                DialogResult dr = MessageBox.Show(this, "It appears there are unsaved changes to the current option. " +
                    "Would you like to save them before continuing?", "Unsaved changes", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (dr == DialogResult.Cancel)
                    return false;
                else if (dr == DialogResult.No)
                    return true;
                else
                {
                    cmdSave.PerformClick();
                    return true;
                }
            }
            else
                return true;
        }

        private void DataChanged(object sender, EventArgs e)
        {
            QuestionChanged(true);
        }

        private void chkIsClassification_CheckedChanged(object sender, EventArgs e)
        {
            pnlClassificationOptions.Enabled = radCallClassification.Checked;
            pnlClassification2.Enabled = radCallClassification.Checked;
            pnlCategoryRestrictions.Enabled = radCallClassification.Checked;
            QuestionChanged(true);
        }

        private void lnkInsuranceCompanyList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInsuranceCompanyList toShow = new frmInsuranceCompanyList(_currentQuestion);
            toShow.ShowDialog();
        }

        private void trvDisplay_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Item is CallTreeQuestionNode)
                trvDisplay.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void trvDisplay_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void trvDisplay_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("C_DentalClaimTracker.CallTreeQuestionNode", false))
            {
                Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
                TreeNode DestinationNode = ((TreeView)sender).GetNodeAt(pt);



                _cutNode = (CallTreeQuestionNode)e.Data.GetData("C_DentalClaimTracker.CallTreeQuestionNode", true);
                trvDisplay.Nodes.Remove(_cutNode);
                trvDisplay.SelectedNode = DestinationNode;
                EnableCut(false);

                PasteNode();
            }
        }

        private void trvDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    cmdDelete.PerformClick();
                    e.Handled = true;
                    break;
                case Keys.Add:
                    cmdAddNew.PerformClick();
                    e.Handled = true;
                    break;
            }

            if (e.Control)
            {
                if (e.KeyCode == Keys.X)
                {
                    cmdCut.PerformClick();
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.V)
                {
                    cmdPaste.PerformClick();
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Up)
                {
                    cmdMoveUp.PerformClick();
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    cmdMoveDown.PerformClick();
                    e.Handled = true;
                }
            }
        }

        private void cmbRevisitDateOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 0 = set revisit, 1 = user set, 2 = don't set, 3 = Unspecified
            if (cmbRevisitDateOptions.SelectedIndex == 0 || cmbRevisitDateOptions.SelectedIndex == 1)
                nmbDefaultRevisitDate.Enabled = true;
            else
                nmbDefaultRevisitDate.Enabled = false;

            QuestionChanged(true);
        }

        private void cmbStatusDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuestionChanged(true);
        }

        private void nmbDefaultRevisitDate_ValueChanged(object sender, EventArgs e)
        {
            QuestionChanged(true);
        }

        private void frmEditQuestionTree_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!RecordChangeOK())
                e.Cancel = true;
        }
    }
}