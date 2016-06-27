using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker.Claims_Primary
{
    public partial class MultiCallDisplay : UserControl
    {
        public MultiCallDisplay()
        {
            InitializeComponent();
        }

        public void DisplayClaim(claim toDisplay, bool showZeroAnswer)
        {
            rtbMain.Text = "";
            List<ClaimDisplayData> displayData = new List<ClaimDisplayData>();


            // Get Call History
            foreach (call aCall in toDisplay.GetPastCalls(!showZeroAnswer))
            {
                ClaimDisplayDataCall cd = new ClaimDisplayDataCall();
                cd.ActionTime = aCall.created_on.Value;
                cd.CallDuration = aCall.DurationSeconds;
                cd.User = aCall.operatordata;

                if (aCall.call_status > 0)
                    cd.LinkedStatus = aCall.LinkedStatus.text;
                else
                    cd.LinkedStatus = "";

                string callText = "";
                string categoryText = "";

                foreach (choice aChoice in aCall.GetCallChoices())
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

                            if (!workingQuestion.is_classification)
                            {
                                parentCatNames.Insert(0, workingQuestion.text);
                            }
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
                            toAdd += " - " + aCatName;
                    }

                    if (callText != "")
                        callText += "\\line ";

                    callText += string.Format("{0}: {1}", toAdd, aChoice.answer);

                }

                foreach (notes aNote in aCall.GetNotes())
                {
                    callText += "\\line Note: " + aNote.Note;
                }

                cd.CallDetails += categoryText + callText;
                
                if (cd.CallDetails != "")
                    cd.CallDetails += @"\line ";

                if (cd.LinkedStatus != "" && cd.CallDetails != "")
                    displayData.Add(cd);
            }

            // Get Status History
            foreach (claim_status_history csh in toDisplay.GetClaimHistory(false))
            {
                ClaimDisplayDataStatusChange cd = new ClaimDisplayDataStatusChange();
                cd.ActionTime = csh.date_of_change.GetValueOrDefault();
                cd.User = csh.LinkedUser.username;

                if (csh.old_status_id != csh.new_status_id)
                {
                    if (csh.new_status_id == -1)
                        cd.LinkedStatus = "{Empty}";
                    else
                        cd.LinkedStatus = csh.LinkedNewStatus.name;
                }

                cd.RevisitDate = csh.new_revisit_date;
                displayData.Add(cd);
            }

            var sortedDD = displayData.OrderByDescending(o => o.ActionTime);


            string fullText = @"{\rtf1\ansi {\colortbl;\red0\green0\blue0;\red25\green25\blue112;}";
            foreach (ClaimDisplayData anItem in sortedDD)
            {
                // Example (missing formatting)
                /*
                    2/13/15 (aaron) | In Process 
                    Date Received: 1/20/2015
                    Information needed by insurance company-: answered question
                 */

                string baseLineFormat = @"\cf2 {0}\cf1 \b  {2}{3}\b0  \i{1}\i0 \line ";
                string revisitDate;

                if (anItem.RevisitDate.HasValue)
                    if (anItem.RevisitDate > new DateTime(2000, 1, 1))
                        revisitDate = string.Format(" +{0}", Math.Ceiling((anItem.RevisitDate.Value - anItem.ActionTime).TotalDays));
                    else
                        revisitDate = "";
                else
                    revisitDate = "";
                

                fullText += string.Format(baseLineFormat, anItem.ActionTime.ToString("M/d/yy"), anItem.User,
                    anItem.LinkedStatus, revisitDate);

                if (anItem is ClaimDisplayDataCall)
                {
                    ClaimDisplayDataCall callItem = (ClaimDisplayDataCall)anItem;
                    fullText += callItem.CallDetails;
                }

            }

            fullText += "}";

            rtbMain.Rtf = fullText;

            if (rtbMain.Text == "")
            {
                rtbMain.Text = "No history found.";
            }
        }
    }

    public class ClaimDisplayData
    {
        public DateTime ActionTime { get; set; }
        public string User { get; set; }
        public string LinkedStatus { get; set; }
        public DateTime? RevisitDate { get; set; }
    }

    public class ClaimDisplayDataCall : ClaimDisplayData
    {
        public decimal CallDuration { get; set; }
        public string CallDetails { get; set; }
        
    }

    public class ClaimDisplayDataStatusChange : ClaimDisplayData
    {
        
    }
}
