using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class frmEditMultipleChoiceQuestions : Form
    {
        private question _formQuestion;
        multiple_choice_answer _lastAnswer;

        public frmEditMultipleChoiceQuestions(question parentQuestion)
        {
            InitializeComponent();
            _formQuestion = parentQuestion;
            lblquestionText.Text = parentQuestion.popup_question_text;

            InitializeAnswers();
        }

        private void InitializeAnswers()
        {
            lstAnswerList.Items.Clear();
            foreach (multiple_choice_answer mca in _formQuestion.GetMultipleChoiceAnswers())
            {
                lstAnswerList.Items.Add(mca);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            SaveCurrentItem(true);
            Close();
        }

        private void lstAnswerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveCurrentItem(true);
            ShowAnswer();
        }

        private void ShowAnswer()
        {
            if (lstAnswerList.SelectedIndex < 0)
            {
                txtAnswerText.Enabled = false;
            }
            else
            {
                _lastAnswer = (multiple_choice_answer)lstAnswerList.SelectedItem;
                txtAnswerText.Text = _lastAnswer.answer_text;
                txtAnswerText.Focus();
                txtAnswerText.Enabled = true;
            }
        }

        private void lnkAddNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNew();
        }

        private void AddNew()
        {
            multiple_choice_answer toAdd = new multiple_choice_answer();

            toAdd.question_id = _formQuestion.id;
            toAdd.order_id = lstAnswerList.Items.Count;
            toAdd.answer_text = "Enter your text here...";
            toAdd.Save();

            lstAnswerList.Items.Add(toAdd);
            lstAnswerList.SelectedItem = toAdd;
            ForceAnswerReorder();

            txtAnswerText.Focus();
        }

        private void moveUpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (lstAnswerList.SelectedIndex > -1)
            {
                ((multiple_choice_answer)lstAnswerList.SelectedItem).Delete();
                lstAnswerList.Items.Remove(lstAnswerList.SelectedItem);
                InitializeAnswers();
                ForceAnswerReorder();
                _lastAnswer = null;
            }
        }

        private void ForceAnswerReorder()
        {
            int i = 0;

            _formQuestion.ExecuteNonQuery("UPDATE multiple_choice_answers SET order_id = order_id + " +
                "1000 WHERE question_id = " + _formQuestion.id);

            foreach (multiple_choice_answer anAnswer in lstAnswerList.Items)
            {
                // Have to save this manually because order_id is part of primary key ><
                anAnswer.ExecuteNonQuery("UPDATE multiple_choice_answers SET order_id = " + i +
                    " WHERE order_id = (" + anAnswer.order_id + " + 1000) AND question_id = " + anAnswer.question_id);
                anAnswer.order_id = i;
                i++;
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SaveCurrentItem(false);
        }

        private void SaveCurrentItem(bool ask)
        {
            if (lstAnswerList.SelectedIndex > -1)
            {
                if (_lastAnswer != null)
                {
                    if (_lastAnswer.answer_text != txtAnswerText.Text)
                    {
                        bool needsSave = true;
                        if (ask)
                        {
                            if (MessageBox.Show(this, "Would you like to save changes to the current item before proceeding?",
                                "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                needsSave = false;
                        }

                        if (needsSave)
                        {
                            _lastAnswer.answer_text = txtAnswerText.Text;
                            _lastAnswer.Save();

                            lstAnswerList.Items.Remove(_lastAnswer);
                            lstAnswerList.Items.Insert(_lastAnswer.order_id, _lastAnswer);
                            if (!ask)
                                lstAnswerList.SelectedIndex = _lastAnswer.order_id;
                        }
                    }
                }
                
            }
        }

        private void lblMoveTop_Click(object sender, EventArgs e)
        {
            if (lstAnswerList.SelectedIndex > 0)
            {
                MoveToPosition(lstAnswerList.SelectedItem, 0);
            }
        }

        /// <summary>
        /// Keep in mind that the item will be removed when passing the index
        /// </summary>
        /// <param name="selectedItem"></param>
        /// <param name="newIndex"></param>
        private void MoveToPosition(object selectedItem, int newIndex)
        {
            lstAnswerList.Items.Remove(selectedItem);
            lstAnswerList.Items.Insert(newIndex, selectedItem);

            lstAnswerList.SelectedItem = selectedItem;
            ForceAnswerReorder();
        }

        private void lblMoveUp_Click(object sender, EventArgs e)
        {
            if (lstAnswerList.SelectedIndex > 0)
            {
                MoveToPosition(lstAnswerList.SelectedItem, lstAnswerList.SelectedIndex - 1);
            }
        }

        private void lblMoveDown_Click(object sender, EventArgs e)
        {
            if (lstAnswerList.SelectedIndex < lstAnswerList.Items.Count - 1)
            {
                MoveToPosition(lstAnswerList.SelectedItem, lstAnswerList.SelectedIndex + 1);
            }
        }

        private void lblMoveBottom_Click(object sender, EventArgs e)
        {
            if (lstAnswerList.SelectedIndex < lstAnswerList.Items.Count - 1)
            {
                MoveToPosition(lstAnswerList.SelectedItem, lstAnswerList.Items.Count - 1);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            if (lstAnswerList.SelectedIndex > -1)
            {
                txtAnswerText.Text = ((multiple_choice_answer)lstAnswerList.SelectedItem).answer_text;
            }
        }

        private void txtAnswerText_Enter(object sender, EventArgs e)
        {
            AcceptButton = cmdSave;
            CancelButton = cmdCancel;
        }

        private void txtAnswerText_Leave(object sender, EventArgs e)
        {
            CancelButton = cmdClose;
        }
    }
}