using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class NotesGrid : UserControl
    {
        public enum NotesGridMode
        {
            GridView,
            Editor
        }

        private NotesGridMode _mode;
        private List<notes> _notes;
        private notes editNote;        
        private call _currentCall;
        private claim _currentClaim;
        private bool _readOnly = false;
        
        // Events
        public event EventHandler ModeChanged;
        public event EventHandler NewNotes;

        public NotesGrid()
        {
            _mode = NotesGridMode.GridView;
            _notes = new List<notes>();
            InitializeComponent();
            bsNotes.DataSource = _notes;
        }

        private void InitializeQuickNote(int index, Button btnToUse)
        {
            try
            {
                btnToUse.Text = system_options.GetQuickNote(index, false);
                btnToUse.Tag = system_options.GetQuickNote(index, true);
                ttipMain.SetToolTip(btnToUse, btnToUse.Tag.ToString());

                btnToUse.Visible = btnToUse.Tag.ToString() != "";
            }
            catch(Exception e)
            {
                LoggingHelper.Log(e, false); // Not expecting any errors here
            }
        }

        public call CurrentCall
        {
            get { return _currentCall; }
            set
            {
                _currentCall = value;             
            }
        }

        /// <summary>
        /// Only used when this is a multiple claim call
        /// </summary>
        public claim CurrentClaim
        {
            get { return _currentClaim; }
            set { _currentClaim = value; }
        }

        public List<notes> Notes
        {
            get { return _notes; }
        }

        public bool ReadOnly
        {
            get { return _readOnly; }
            set
            {
                _readOnly = value;
                pnlNotesControls.Visible = !value;
            }
        }

        public List<notes> SelectedNotes
        {
            get 
            {
                List<notes> selectedNotes = new List<notes>();
                foreach (DataGridViewNoteRow row in dgvNotes.SelectedRows)
                {
                    selectedNotes.Add(GetNoteFromGrid(row.Index));
                }
                return selectedNotes;
            }            
        }

        public void LoadNotes(claim activeClaim)
        {
            Notes.Clear();
            
            foreach (notes note in activeClaim.GetNotes())
            {
                note.Note += CreateNoteAdditionalText(note);
                Notes.Add(note);
            }

            bsNotes.ResetBindings(false);
            InitializeColumnVisibility();
        }

        private string CreateNoteAdditionalText(notes note)
        {
            if (note.created_on == null)
                return " (" + note.operatorId + " Unknown time)";
            else
                return " (" + note.operatorId + " " + note.created_on.Value.ToShortDateString() + 
                    " " + note.created_on.Value.ToShortTimeString() + ")";
        }
        
        public void LoadNotes(call call)
        {
            Notes.Clear();
            List<notes> callNotes = call.GetNotes();
            foreach (notes note in callNotes)
            {
                note.Note += CreateNoteAdditionalText(note);
                Notes.Add(note);
            }
            bsNotes.ResetBindings(false);
            InitializeColumnVisibility();
        }
        
        public NotesGridMode Mode
        {
            get { return _mode; }
            set 
            {
                bool changed = (_mode != value);                
                _mode = value;

                if (changed)
                {                    
                    if (_mode == NotesGridMode.GridView)
                    {
                        pnlGrid.BringToFront();
                        pnlGridControls.BringToFront();                        
                    }
                    else if (_mode == NotesGridMode.Editor)
                    {
                        pnlEditor.BringToFront();
                        pnlEditorControls.BringToFront();
                    }

                    if (this.ModeChanged != null)
                    {
                        ModeChanged(this, new EventArgs());
                    }
                }
            }
        }        

        private void lblAddNote_Click(object sender, EventArgs e)
        {
            editNote = new notes();
            rtbNote.Text = "";
            Mode = NotesGridMode.Editor;            
            rtbNote.Focus();

            if (NewNotes != null)
                NewNotes(this, new EventArgs());
        }

        private void lblEditNote_Click(object sender, EventArgs e)
        {
            if (dgvNotes.SelectedRows.Count == 1)
            {
                editNote = GetNoteFromGrid(dgvNotes.SelectedRows[0].Index);
                rtbNote.Text = editNote.Note;
                Mode = NotesGridMode.Editor;                
                rtbNote.Focus();
            }
        }

        private void lblRemoveNote_Click(object sender, EventArgs e)
        {
            RemoveSelectedNotes();
        }

        private void RemoveSelectedNotes()
        {
            List<notes> removeNotes = new List<notes>();
            foreach (DataGridViewRow row in dgvNotes.SelectedRows)
            {
                removeNotes.Add(GetNoteFromGrid(row.Index));
            }
            if (removeNotes.Count > 0)
            {
                string prompt;
                string title;

                if (removeNotes.Count > 1)
                {
                    prompt = "Are you sure you want to delete these notes?";
                    title = "Confirm Delete Multiple Notes";
                }
                else
                {
                    prompt = "Are you sure you want to delete this note?";
                    title = "Confirm Delete Note";
                }

                if (MessageBox.Show(prompt, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    foreach (notes note in removeNotes)
                    {
                        Notes.Remove(note);
                        note.Delete();
                    }
                }
                bsNotes.ResetBindings(false);
            }
        }

        private notes GetNoteFromGrid(int rowIndex)
        {
            if (dgvNotes.Rows[rowIndex] != null)
            {
                int noteId = (int) dgvNotes.Rows[rowIndex].Cells["dgvcNoteId"].Value;
                foreach (notes note in Notes)
                {
                    if (note.NoteId == noteId)
                    {
                        return note;
                    }
                }
            }
            return null;
        }

        private void dgvNotes_SelectionChanged(object sender, EventArgs e)
        {
            switch (dgvNotes.SelectedRows.Count)
            {
                case 1: // 1 Note is selected
                    // lblEditNote.Enabled = true;
                    lblRemoveNote.Enabled = true;                    
                    break;
                case 0: // No notes are selected
                    lblEditNote.Enabled = false;
                    lblRemoveNote.Enabled = false;
                    break;
                default: // Multiple notes are selected
                    lblEditNote.Enabled = false;
                    lblRemoveNote.Enabled = true;
                    break;
            }
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            SaveNote();
        }

        public void SaveNote()
        {
            if ((editNote != null) && (rtbNote.Text != ""))
            {
                bool isNew = (!editNote.created_on.HasValue);
                editNote.Note = rtbNote.Text.Trim();
                if ((editNote.CallId == 0) && (CurrentCall != null))
                {
                    editNote.CallId = CurrentCall.id;
                }
                else
                    editNote.CallId = 0;

                if ((editNote.claim_id == 0) && (CurrentClaim != null))
                    editNote.claim_id = CurrentClaim.id;
                else
                    editNote.claim_id = 0;

                editNote.operatorId = ActiveUser.UserObject.username;
                if (!editNote.created_on.HasValue)
                {
                    editNote.created_on = DateTime.Now;
                }
                editNote.updated_on = DateTime.Now;

                ActiveUser.LogAction(ActiveUser.ActionTypes.CreateNote, editNote.claim_id, editNote.CallId, "");
                editNote.Save();

                if (isNew)
                {
                    editNote.Note += CreateNoteAdditionalText(editNote);
                    Notes.Insert(0, editNote);
                }

                editNote = null;
                rtbNote.Text = "";
                Mode = NotesGridMode.GridView;
                bsNotes.ResetBindings(false);
            }
            else
                CancelNote();
        }        

        private void btnCancelNote_Click(object sender, EventArgs e)
        {
            CancelNote();        
        }

        private void CancelNote()
        {
            editNote = null;
            rtbNote.Text = "";
            Mode = NotesGridMode.GridView;
        }

        private void dgvNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete) && (!_readOnly))
            {
                RemoveSelectedNotes();
            }
        }

        private void dgvNotes_Leave(object sender, EventArgs e)
        {
            dgvNotes.DefaultCellStyle.SelectionBackColor = SystemColors.Control;
            dgvNotes.DefaultCellStyle.SelectionForeColor = SystemColors.ControlText;
        }

        private void dgvNotes_Enter(object sender, EventArgs e)
        {
            dgvNotes.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgvNotes.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
        }

        public bool CallHasNote(int callID)
        {
            bool toReturn = false;
            foreach (notes n in _notes)
            {
                if (n.CallId == callID)
                {
                    toReturn = true;
                    break;
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Unusual bug requires that this be re-set manually
        /// </summary>
        private void InitializeColumnVisibility()
        {
            for (int i = 0; i < dgvNotes.Columns.Count; i++)
            {
                if (i < dgvNotes.Columns.Count - 1)
                    dgvNotes.Columns[i].Visible = false;
                else
                    break;
            }
                
        }

        private void QuickText_Click(object sender, EventArgs e)
        {
            if (rtbNote.Text != string.Empty)
                rtbNote.Text += "\n";

            rtbNote.Text += ((Button)sender).Tag.ToString();
        }

        private void NotesGrid_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// This needs to be called if you want quick notes available
        /// </summary>
        public void InitializeQuickNotes()
        {
            InitializeQuickNote(1, btnQuickText1);
            InitializeQuickNote(2, btnQuickText2);
            InitializeQuickNote(3, btnQuickText3);
            InitializeQuickNote(4, btnQuickText4);
        }
    }
}
