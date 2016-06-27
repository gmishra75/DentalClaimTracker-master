using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker.Call_Management
{
    public partial class CallQuestionAnswerDisplay : UserControl
    {
        Panel currentChoicePanel = null;
        question _question;
        choice _choice;
        call _currentCall;
        int _defaultHeight;
        bool _isHidden = false;
        public event EventHandler<QuestionAnsweredEventArgs> QuestionAnswered;
        public event EventHandler<QuestionAnsweredEventArgs> QuestionCleared;
        private int _displayDepth;

        public CallQuestionAnswerDisplay(question q, choice c, call ca)
        {
            InitializeComponent();
            _question = q; 
            _choice = c;
            _currentCall = ca;
            lblDataDescription.Text = q.text;
            SetQuestion();
        }

        public bool IsHidden
        {
            get { return _isHidden; }
            set { _isHidden = value; }
            
        }

        public int DisplayDepth
        {
            get { return _displayDepth; }
            set { _displayDepth = value; }
        }

        public question Question
        {
            get { return _question; }
        }

        public choice Choice
        {
            get { return _choice; }
        }

        private void SetQuestion()
        {
            switch (Question.type)
            {
                case question.QuestionTypes.Category:
                    currentChoicePanel = null;
                    pnlDataEntry.Visible = false;
                    _defaultHeight = 32;
                    break;
                case question.QuestionTypes.Date:
                    currentChoicePanel = pnlChoiceDate;
                    _defaultHeight = 32;
                    if (Choice != null)
                    {
                        DateTime choiceDate;
                        if (DateTime.TryParse(Choice.answer, out choiceDate))
                        {
                            ctlDate.CurrentDate = choiceDate;
                        }
                        else if (Choice.answer == "")
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
                    _defaultHeight = 96;
                    if (Choice != null)
                    {
                        txtLarge.Text = Choice.answer;
                    }
                    else
                    {
                        txtLarge.Text = "";
                    }
                    break;
                case question.QuestionTypes.MultipleChoice:
                    currentChoicePanel = pnlChoiceMultiple;
                    _defaultHeight = 32;
                    cmbMultipleChoice.Items.Clear();

                    Question.GetMultipleChoiceAnswers();

                    // Use ComboBox
                    foreach (multiple_choice_answer mca in Question.MultipleChoiceAnswers)
                    {
                        cmbMultipleChoice.Items.Add(mca);
                    }

                    if (Choice != null)
                    {
                        for (int i = 0; i < cmbMultipleChoice.Items.Count; i++)
                        {
                            if (cmbMultipleChoice.Items[i].ToString() == Choice.answer)
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
                    _defaultHeight = 32;
                    if (Choice != null)
                    {
                        txtNormal.Text = Choice.answer;
                    }
                    else
                    {
                        txtNormal.Text = "";
                    }
                    break;
                case question.QuestionTypes.Numeric:
                    currentChoicePanel = pnlChoiceNumeric;
                    _defaultHeight = 32;
                    if (Choice != null)
                    {
                        if (CommonFunctions.IsNumeric(Choice.answer))
                        {
                            numNumber.Value = Convert.ToDecimal(Choice.answer);
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
                    _defaultHeight = 32;
                    if (Choice != null)
                    {
                        txtSmall.Text = Choice.answer;
                    }
                    else
                    {
                        txtSmall.Text = "";
                    }
                    break;
                case question.QuestionTypes.YesNo:
                    currentChoicePanel = pnlChoiceYesNo;
                    _defaultHeight = 32;
                    if (Choice != null)
                    {
                        bool YesNo = Convert.ToBoolean(Choice.answer);
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

            if (Choice == null)
                cmdClearAnswer.Visible = false;
            else
                cmdClearAnswer.Visible = true;



            if (Question.is_fork)
            {
                lblDataDescription.BackColor = Color.LightYellow;
                currentChoicePanel.BackColor = Color.LightYellow;
            }

            if (currentChoicePanel != null)
            {
                pnlDataEntry.Visible = true;
                currentChoicePanel.Visible = true;
            }
        }

        public int DefaultHeight
        {
            get
            {
                if (IsHidden)
                    return 0;
                else
                    return _defaultHeight;
            }
        }


        private void UpdateAnswer(string answer)
        {
            string answerText = answer;

            if (Choice != null)
            {
                if (Choice.LinkedCall.ReadOnly)
                    return; // Cancel edit (this is a past call)
            }
            else
                _choice = GetNewCallChoice();

            if (Question.type == question.QuestionTypes.YesNo)
            {
                if (answer == true.ToString())
                {
                    answerText = "Yes";
                    Text = Question.text + ": Yes";
                }
                else if (answer == false.ToString())
                {
                    answerText = "No";
                    Text = Question.text + ": No";
                }
            }
            else
            {
                Text = Question.text + ": " + Choice.answer;
            }
            _choice.answer = answerText;
            QuestionAnsweredEventArgs ea = new QuestionAnsweredEventArgs();
            ea.Choice = _choice;

            if (QuestionAnswered != null)
                QuestionAnswered(this, ea);


            Choice.Save();
            // currentChoiceIsDirty = true;

            cmdClearAnswer.Visible = true;
        }

        private choice GetNewCallChoice()
        {
            choice newChoice = new choice();
            newChoice.created_at = DateTime.Now;
            newChoice.operatordata = ActiveUser.UserObject.username;
            newChoice.LinkedCall = _currentCall;
            newChoice.LinkedQuestion = Question;
            

            return newChoice;
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
            if ((currentChoicePanel == pnlChoiceMultiple) && (cmbMultipleChoice.SelectedIndex >= 0))
            {
                UpdateAnswer(cmbMultipleChoice.SelectedItem.ToString());
            }
        }

        private void ctlDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateAnswer(ctlDate.CurrentDateText);
        }

        private void cmdClearAnswer_Click(object sender, EventArgs e)
        {
            ClearInputBoxes();
            cmdClearAnswer.Visible = false;

            QuestionAnsweredEventArgs qe = new QuestionAnsweredEventArgs();

            qe.Choice = _choice;

            if (QuestionCleared != null)
                QuestionCleared(this, qe);

            try
            {
                _choice.Delete();
                _choice = null;
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error deleting choice in CallQuestionAnswerDisplay.ClearAnswer", LogSeverity.Error, err, false);
                MessageBox.Show(this, "An error occurred erasing your choice. Please report the following error to a system administrator:\n\n" +
                    err.Message, "Error removing choice");
            }

            
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

    public class QuestionAnsweredEventArgs : EventArgs
    {
        public choice Choice;
    }
}
