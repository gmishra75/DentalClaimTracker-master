using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace C_DentalClaimTracker
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class ctlClaimDataDisplay : UserControl
    {
        public enum ClaimDataDisplayMode
        {
            Minimize,
            Normal,
            Full
        }

        private ClaimDataDisplayMode _currentDisplayMode = ClaimDataDisplayMode.Full;
        public event EventHandler Resized;
        private int MINIMUMHEIGHT;
        private int _formIndex = 0;
        private bool _canMaximize = true;
        private const string NORMALTOOLTIPTEXT = "Standard View\n\nExpand this section to show the most important information.";
        private const string MAXIMIZETOOLTIPTEXT = "Full View\n\nExpand this section to show all information.";

        public ctlClaimDataDisplay()
        {
            InitializeComponent();
            ResizeControl();
            MINIMUMHEIGHT = cmdMaximize.Top + cmdMaximize.Height + 2;
            ttipMain.SetToolTip(cmdMaximize, MAXIMIZETOOLTIPTEXT);
            ttipMain.SetToolTip(cmdGrow, NORMALTOOLTIPTEXT);
            cmdGrow.BackColor = System.Drawing.SystemColors.Control;
            cmdMinimize.BackColor = System.Drawing.SystemColors.Control;
        }

        public string Caption
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }

        public Color BackColorCaption
        {
            get { return lblTitle.BackColor; }
            set { lblTitle.BackColor = value; }
        }

        public int FormIndex
        {
            get { return _formIndex; }
            set { _formIndex = value; }
        }

        public bool CanMaximize
        {
            get { return _canMaximize; }
            set { 
                _canMaximize = value;
                cmdMaximize.Enabled = _canMaximize;

                if (_canMaximize)
                {
                    cmdMaximize.BackgroundImage = global::C_DentalClaimTracker.Properties.Resources.bullet_arrow_top;
                    cmdMaximize.BackColor = System.Drawing.SystemColors.Control;
                }
                else
                {
                    cmdMaximize.BackgroundImage = null;
                    cmdMaximize.BackColor = System.Drawing.SystemColors.ControlLightLight;
                }
            }
        }

        public ClaimDataDisplayMode DisplayMode
        {
            get { return _currentDisplayMode; }
            set
            {
                if (_currentDisplayMode != value)
                {
                    _currentDisplayMode = value;
                    ResizeControl();
                }
            }
        }

        /// <summary>
        /// Forces the control to resize (if controls are being added or resized dynamically, use this)
        /// </summary>
        public void ForceResize()
        {
            ResizeControl();
        }

        private void ResizeControl()
        {
            int oldHeight = Height;

            cmdMinimize.FlatStyle = FlatStyle.Standard;
            cmdMaximize.FlatStyle = FlatStyle.Standard;
            cmdGrow.FlatStyle = FlatStyle.Standard;

            if (_currentDisplayMode == ClaimDataDisplayMode.Minimize)
            {
                Height = MINIMUMHEIGHT;
                cmdMinimize.FlatStyle = FlatStyle.Flat;
            }
            else if (_currentDisplayMode == ClaimDataDisplayMode.Normal)
            {
                int lastMax = MINIMUMHEIGHT;

                foreach (Control aControl in Controls)
                {
                    if (System.Convert.ToInt32(aControl.Tag) == 1) // A little cheap, but using the tag property here
                    {
                        int controlBottom = aControl.Top + aControl.Height;
                        if (controlBottom > lastMax)
                        {
                            lastMax = controlBottom;
                        }
                    }
                    else if (aControl is Panel)
                    {
                        foreach (Control aSubControl in aControl.Controls)
                        {
                            if (System.Convert.ToInt32(aSubControl.Tag) == 1) // A little cheap, but using the tag property here
                            {
                                int controlBottom = aSubControl.Top + aSubControl.Height + aControl.Top;
                                if (controlBottom > lastMax)
                                {
                                    lastMax = controlBottom;
                                }
                            }
                        }
                    }
                }
                Height = lastMax + 2;
                cmdGrow.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                int lastMax = MINIMUMHEIGHT;

                foreach (Control aControl in Controls)
                {
                    if (aControl is Panel)
                    {
                        foreach (Control aSubControl in aControl.Controls)
                        {
                            int controlBottom = aSubControl.Top + aSubControl.Height + aControl.Top;
                            if (controlBottom > lastMax)
                            {
                                lastMax = controlBottom;
                            }
                        }
                    }
                    else
                    {
                        int controlBottom = aControl.Top + aControl.Height;
                        if (controlBottom > lastMax)
                        {
                            lastMax = controlBottom;
                        }
                    }

                }
                Height = lastMax + 5;
                cmdMaximize.FlatStyle = FlatStyle.Flat;
            }

            if (oldHeight != Height)
            {
                if (Resized != null)
                    Resized(this, null);
            }
        }

        private void cmdMinimize_Click(object sender, EventArgs e)
        {
            DisplayMode = ClaimDataDisplayMode.Minimize;
        }

        private void cmdMaximize_Click(object sender, EventArgs e)
        {
            if (CanMaximize)
            {
                DisplayMode = ClaimDataDisplayMode.Full;
            }
        }

        private void cmdGrow_Click(object sender, EventArgs e)
        {
            DisplayMode = ClaimDataDisplayMode.Normal;
        }

        private void ctlClaimDataDisplay_Paint(object sender, PaintEventArgs e)
        {
            pnlTop.SendToBack();
        }
    }
}
