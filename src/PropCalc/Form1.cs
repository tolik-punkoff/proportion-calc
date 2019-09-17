using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Wildsoft.About;

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
        
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {            
            //ввод только цифр с одной точкой (запятой)
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                TextBox txt = (TextBox)sender;
                if (txt.Text.Contains(".") || txt.Text.Contains(","))
                {
                    e.Handled = true;
                    return;
                }
                return;
            }

            if (!(Char.IsDigit(e.KeyChar)))
            {
                if ((e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    return;
                }
            }
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
                        DisableTextBox(txtA);                        
                        A = null;

                        B = string.Empty;
                        C = string.Empty;
                        D = string.Empty;
                        
                        pbScheme.BackgroundImage = Properties.Resources.sXA;
                        pbFormula.BackgroundImage = Properties.Resources.fXA;
                    }; break;
                case "B":
                    {
                        DisableTextBox(txtB);                        
                        B = null;

                        A = string.Empty;
                        C = string.Empty;
                        D = string.Empty;

                        pbScheme.BackgroundImage = Properties.Resources.sXB;
                        pbFormula.BackgroundImage = Properties.Resources.fXB;
                    }; break;
                case "C":
                    {
                        DisableTextBox(txtC);
                        C = null;

                        B = string.Empty;
                        A = string.Empty;
                        D = string.Empty;

                        pbScheme.BackgroundImage = Properties.Resources.sXC;
                        pbFormula.BackgroundImage = Properties.Resources.fXC;
                    }; break;
                case "D":
                    {
                        DisableTextBox(txtD);
                        D = null;
                        
                        B = string.Empty;
                        C = string.Empty;
                        A = string.Empty;

                        pbScheme.BackgroundImage = Properties.Resources.sXD;
                        pbFormula.BackgroundImage = Properties.Resources.fXD;
                    }; break;
            }            
        }

        private void DisableTextBox(TextBox TextBoxCtrl)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    if (tb.Name == TextBoxCtrl.Name)
                    {
                        tb.ReadOnly = true;
                    }
                    else
                    {
                        tb.ReadOnly = false;
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
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    if (tb.ReadOnly)
                    {
                        tb.Text = Answer;
                    }                    
                }
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (A != null) A = txtA.Text;
            if (B != null) B = txtB.Text;
            if (C != null) C = txtC.Text;
            if (D != null) D = txtD.Text;

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
            this.Height = 398;
            VisibleScheme = true;
            btnShowHide.Text = "Скрыть схему";
        }

        private void HideScheme()
        {
            this.Width = 470;
            this.Height = 115;
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
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    if (tb.ReadOnly)
                    {
                        if (tb.Text != string.Empty)
                        {
                            Clipboard.Clear();
                            Clipboard.SetText(tb.Text);
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
        
    }
}
