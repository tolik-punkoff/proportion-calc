using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PropCalc
{
    public partial class frmComission : Form
    {
        bool bOkr = false;
        string sPayment = "0";
        string sComission = "0";

        public frmComission()
        {
            InitializeComponent();
        }
        
        private void frmComission_Load(object sender, EventArgs e)
        {
            txtComission.Text = "0";
            txtPayment.Text = "0";
        }

        private void Calc()
        {
            bOkr = chkOkr.Checked;
            sPayment = txtPayment.Text;
            sComission = txtComission.Text;

            txtResult.Text = 
                calc.CalcPayWithCommission(sPayment, sComission, bOkr);            
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            Calc();
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

        private void chkOkr_CheckedChanged(object sender, EventArgs e)
        {
            Calc();
        }
    }
}
