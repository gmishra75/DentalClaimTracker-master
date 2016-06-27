using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class CallDisplay : UserControl
    {
        private bool _showNotes;

        public bool ShowNotes
        {
            get { return _showNotes; }
            set { _showNotes = value; }
        }
    
        public CallDisplay()
        {
            InitializeComponent();
        }

        public CallDisplay(call toShow)
        {
            _showNotes = true;
            DisplayCall(toShow);
        }

        public CallDisplay(call toShow, bool showNotes)
        {
            _showNotes = showNotes;
            DisplayCall(toShow);
        }

        public void DisplayCall(call toShow)
        {
            dgvMain.Rows.Clear();
            dgvMain.Rows.Add(new object[] { "Creation", toShow.operatordata + " " + toShow.created_on.Value.ToShortDateString() + 
                " " + toShow.created_on.Value.ToShortTimeString() });

            dgvMain.Rows.Add(new object[] { "Length", System.Convert.ToInt32(toShow.DurationSeconds / 60) + " minutes" });

            if (toShow.call_status > 0)
            {
                dgvMain.Rows.Add(new object[] { "Status", toShow.LinkedStatus.text });
            }

            foreach (choice aChoice in toShow.GetCallChoices())
            {
                string toAdd = "";
                List<string> parentCatNames = new List<string>();
                question workingQuestion;
                if (aChoice.LinkedQuestion.parent > 0)
                {
                    workingQuestion = aChoice.LinkedQuestion;
                    parentCatNames.Insert(0, workingQuestion.text);
                    while (workingQuestion.parent > 0)
                    {
                        workingQuestion = workingQuestion.ParentQuestion;
                        parentCatNames.Insert(0, workingQuestion.text);
                    }
                }
                else
                {
                    parentCatNames.Insert(0, aChoice.LinkedQuestion.text);
                }

                foreach (string aCatName in parentCatNames)
                {
                    if (toAdd == string.Empty)
                        toAdd = aCatName;
                    else
                        toAdd += " -> " + aCatName;
                }
                dgvMain.Rows.Add(new object[] { toAdd, aChoice.answer });

            }

            foreach (notes aNote in toShow.GetNotes())
            {
                dgvMain.Rows.Add(new object[] { "note", aNote.Note });
            }
        }
    }
}
