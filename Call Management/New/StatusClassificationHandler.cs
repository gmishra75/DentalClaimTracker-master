using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker.Call_Management
{
    public partial class ConditionClassificationHandler : UserControl
    {
        public const int DEFAULTX = 8;
        public const int DEFAULTHEIGHT = 25;
        public const int INITIALY = 10;
        List<question> _selectedQuestions = new List<question>();
        public event EventHandler AllChoicesMade;
        public question _category = null;
        public ConditionClassificationHandler()
        {
            InitializeComponent();
        }

        public List<question> SelectedQuestions
        {
            get { return _selectedQuestions; }
        }

        public question Category
        {
            get { return _category; }
        }

        private void choice_checked(object sender, EventArgs e)
        {
            if (((RadioWithQuestion)sender).Checked)
            {
                question q = ((RadioWithQuestion)sender).AttachedQuestion;
                _selectedQuestions.Add(q);

                DataTable matches = MatchingSubClassifications(q.id);
                // Check to see if it has any subchoices. If not, let them know it's ready
                if (matches.Rows.Count == 0)
                {
                    _category = q;
                    if (AllChoicesMade != null)
                        AllChoicesMade(this, new EventArgs());
                }
                else
                {
                    // Show additional questions
                    GenerateCategoryText();
                    LoadQuestions(matches);
                }
            }
        }

        private void LoadQuestions(int parent, int CustomerID)
        {
            LoadQuestions(MatchingSubquestions(parent, CustomerID));
        }

        private void LoadQuestions(int parent)
        {
            LoadQuestions(MatchingSubClassifications(parent));
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

                if ((q.type == question.QuestionTypes.Header) || (q.type == question.QuestionTypes.Spacer))
                {
                    Label toAdd = new Label();

                    toAdd.AutoSize = false;
                    toAdd.Width = pnlAnswers.Width;
                    toAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;   
                    toAdd.Location = new Point(0, GetY(i));
                    toAdd.ForeColor = Color.White;
                    toAdd.TextAlign = ContentAlignment.MiddleCenter;
                    

                    if (q.type == question.QuestionTypes.Header)
                    {
                        toAdd.Text = q.text;
                        toAdd.BackColor = Color.SteelBlue;
                        toAdd.Height = 22;
                        toAdd.BorderStyle = BorderStyle.FixedSingle;
                    }
                    else
                    {
                        toAdd.Text = "";
                        toAdd.Height = 14;
                    }

                    pnlAnswers.Controls.Add(toAdd);
                }
                else
                {
                    RadioWithQuestion toAdd = new RadioWithQuestion();
                    toAdd.AttachedQuestion = q;
                    toAdd.Text = q.text;
                    toAdd.AutoSize = true;
                    toAdd.TabIndex = i;
                    toAdd.index = i;
                    toAdd.Location = new Point(DEFAULTX, GetY(i));
                    toAdd.CheckedChanged += new EventHandler(choice_checked);

                    pnlAnswers.Controls.Add(toAdd);
                }

                

                i++;
            }

            int newHeight = lblTitle.Height + GetY(i - 1) + DEFAULTHEIGHT + 5;

            if (lblCategoryMarker.Visible)
                newHeight += lblCategoryMarker.Height;

            Height = newHeight;

        }

        private int GetY(int i)
        {
            return INITIALY + (i * DEFAULTHEIGHT - 1);
        }

        private void GenerateCategoryText()
        {
            if (SelectedQuestions.Count > 0)
            {
                lblCategoryMarker.Visible = true;
                lblCategoryMarker.Text = "Claim Condition: " + SelectedQuestions[0].text;
                for (int i = 1; i < SelectedQuestions.Count; i++)
                {
                    lblCategoryMarker.Text += " > " + SelectedQuestions[i].text;
                }

                lblCategoryMarker.Height = (lblCategoryMarker.Font.Height + 2) * SelectedQuestions.Count;
            }
            else
            {
                lblCategoryMarker.Visible = false;
            }
        }

        public void Initialize(int customerID)
        {
            _selectedQuestions.Clear();
            GenerateCategoryText();
            LoadQuestions(0, customerID);
        }

        private DataTable MatchingSubClassifications(int parentID)
        {
            return new question().Search("SELECT * FROM questions WHERE parent = " + 
                parentID + " AND is_classification = 1 ORDER BY order_id");
        }

        /// <summary>
        /// Returns all questions that apply on the base level to a customer. Parent ID here should
        /// almost always be 0
        /// </summary>
        /// <param name="parentID"></param>
        /// <param name="CustomerID"></param>
        /// <returns></returns>
        private DataTable MatchingSubquestions(int parentID, int CustomerID)
        {
            string sql = "SELECT * FROM questions q LEFT JOIN question_insurance_companies " +
                "qic on q.id = qic.question_id " +
                "WHERE q. parent = " + parentID +
                " AND is_classification = " + 1 +
                " AND (qic.insurance_id = " + CustomerID + " OR qic.insurance_id is null) " +
                "ORDER BY order_id";
            return new question().Search(sql);
        }
    }

    public class RadioWithQuestion : RadioButton
    {
        public question AttachedQuestion;
        public int index;
    }
}
