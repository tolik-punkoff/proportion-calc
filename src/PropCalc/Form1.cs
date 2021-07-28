using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Wildsoft.About;
using Wildsoft.Controls;

namespace PropCalc
{
    public partial class frmMain : Form
    {
        string A = string.Empty;
        string B = string.Empty;
        string C = string.Empty;
        string D = string.Empty;

        bool VisibleScheme = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            chkXD.Checked = true;
            DrawFormula.pbDraw = pbDrawFormula;
            DrawFormula.InitGraph();

            HideScheme();
        }                

        private void chkX_CheckedChanged(object sender, EventArgs e)
        {
            if (!((CheckBox)sender).Checked) return;
            UncheckOthers((CheckBox)sender);
            
            string chkLetter = ((CheckBox)sender).Name;
            chkLetter = chkLetter.Substring(chkLetter.Length-1);

            switch (chkLetter)
            {
                case "A":
                    {
                        DisableInputDigitControl(idcA);                        
                        A = null;

                        B = string.Empty;
                        C = string.Empty;
                        D = string.Empty;
                        
                        pbScheme.BackgroundImage = Properties.Resources.sXA;
                        pbFormula.BackgroundImage = Properties.Resources.fXA;
                    }; break;
                case "B":
                    {
                        DisableInputDigitControl(idcB);                        
                        B = null;

                        A = string.Empty;
                        C = string.Empty;
                        D = string.Empty;

                        pbScheme.BackgroundImage = Properties.Resources.sXB;
                        pbFormula.BackgroundImage = Properties.Resources.fXB;
                    }; break;
                case "C":
                    {
                        DisableInputDigitControl(idcC);
                        C = null;

                        B = string.Empty;
                        A = string.Empty;
                        D = string.Empty;

                        pbScheme.BackgroundImage = Properties.Resources.sXC;
                        pbFormula.BackgroundImage = Properties.Resources.fXC;
                    }; break;
                case "D":
                    {
                        DisableInputDigitControl(idcD);
                        D = null;
                        
                        B = string.Empty;
                        C = string.Empty;
                        A = string.Empty;

                        pbScheme.BackgroundImage = Properties.Resources.sXD;
                        pbFormula.BackgroundImage = Properties.Resources.fXD;
                    }; break;
            }            
        }

        private void DisableInputDigitControl(InputDigitControl idcCtrl)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is InputDigitControl)
                {
                    InputDigitControl idc = (InputDigitControl)ctrl;
                    if (idc.Name == idcCtrl.Name)
                    {
                        idc.ReadOnly = true;
                    }
                    else
                    {
                        idc.ReadOnly = false;
                    }
                }
            }
        }

        private void UncheckOthers(CheckBox CheckBoxCtrl)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox cb = (CheckBox)ctrl;
                    if (cb.Name != CheckBoxCtrl.Name)
                    {
                        cb.Checked = false;
                    }                    
                }
            }
        }

        private void SetAnswer(string Answer)
        {            
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is InputDigitControl)
                {
                    InputDigitControl idc = (InputDigitControl)ctrl;
                    if (idc.ReadOnly)
                    {
                        idc.Text = Answer;
                    }                    
                }
            }
        }

        private void idc_TextChanged(object sender, EventArgs e)
        {
            if (A != null) A = idcA.Text;
            if (B != null) B = idcB.Text;
            if (C != null) C = idcC.Text;
            if (D != null) D = idcD.Text;

            string Result = calc.PropCalc(A, B, C, D);
            SetAnswer(Result);

            if (chkCopy.Checked)
            {
                CopyToClipboard();
            }
        }

        private void ShowScheme()
        {
            this.Width = 470;
            this.Height = 410;
            VisibleScheme = true;
            btnShowHide.Text = "Скрыть схему";
        }

        private void HideScheme()
        {
            this.Width = 470;
            this.Height = 130;
            VisibleScheme = false;
            btnShowHide.Text = "Показать схему";
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (VisibleScheme)
            {
                HideScheme();
            }
            else
            {
                ShowScheme();
            }
        }

        private void CopyToClipboard()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is InputDigitControl)
                {
                    InputDigitControl idc = (InputDigitControl)ctrl;
                    if (idc.ReadOnly)
                    {
                        if (idc.Text != string.Empty)
                        {
                            Clipboard.Clear();
                            Clipboard.SetText(idc.Text);
                        }
                    }
                }
            }
        }

        private void chkCopy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCopy.Checked)
            {
                CopyToClipboard();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout fAbout = new frmAbout();
            fAbout.ShowDialog();
        }

        private void mnuPaymentWithComission_Click(object sender, EventArgs e)
        {
            frmComission fComission = new frmComission();
            fComission.ShowDialog();
        }                
    }
}
