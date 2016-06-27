using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker.Call_Management
{
    public partial class DataVerificationHandler : UserControl
    {
        public const int DEFAULTX = 8;
        public const int DEFAULTHEIGHT = 20;
        public const int INITIALY = 0;
        public event EventHandler Hidden;
        public event EventHandler<DataVerificationCheckChangeEventArgs> ItemCheckChanged;


        public DataVerificationHandler()
        {
            InitializeComponent();
        }

        private void choice_checked(object sender, EventArgs e)
        {
            DataVerificationCheckChangeEventArgs dcce = new DataVerificationCheckChangeEventArgs();
            dcce.ChangedQuestion = ((CheckboxWithQuestion) sender).AttachedQuestion;
            dcce.IsChecked = ((CheckboxWithQuestion) sender).Checked;
            
            if (ItemCheckChanged != null)
                ItemCheckChanged(this, dcce);
        }

        private void LoadQuestions(int parent)
        {
            LoadQuestions(MatchingSubquestions(parent));
        }

        private void LoadQuestions(DataTable matches)
        {
            question q;
            int i = 0;
            pnlAnswers.Controls.Clear();
            foreach (DataRow aRow in matches.Rows)
            {
                q = new question();
                q.Load(aRow);

                CheckboxWithQuestion toAdd = new CheckboxWithQuestion();
                toAdd.AttachedQuestion = q;
                toAdd.Text = q.text;
                toAdd.AutoSize = true;
                toAdd.TabIndex = i;
                toAdd.index = i;
                toAdd.Name = "chk" + i;
                toAdd.Location = new Point(GetX(i), GetY(0));
                toAdd.CheckedChanged += new EventHandler(choice_checked);
                

                pnlAnswers.Controls.Add(toAdd);

                i++;
            }

            //int newHeight = lblTitle.Height + GetY(i - 1) + DEFAULTHEIGHT + 5;

            // Height = newHeight;
            Width = pnlAnswers.Controls[pnlAnswers.Controls.Count - 1].Right + DEFAULTX;
        }

        private int GetX(int i)
        {
            if (i == 0)
                return DEFAULTX;
            else
                return pnlAnswers.Controls["chk" + (i - 1)].Right + 5;
        }

        private int GetY(int i)
        {
            return INITIALY + (i * DEFAULTHEIGHT - 1);
        }

        public void Initialize()
        {
            LoadQuestions(-1);
        }

        private DataTable MatchingSubquestions(int parentID)
        {
            return new question().Search("SELECT * FROM questions WHERE parent = " + 
                parentID + " ORDER BY order_id");
        }

        private void cmdHide_Click(object sender, EventArgs e)
        {
            if (Hidden != null)
                Hidden(this, null);
        }
    }

    public class CheckboxWithQuestion : CheckBox
    {
        public question AttachedQuestion;
        public int index;
    }

    public class DataVerificationCheckChangeEventArgs : EventArgs
    {
        public question ChangedQuestion;
        public bool IsChecked;
    }
}
