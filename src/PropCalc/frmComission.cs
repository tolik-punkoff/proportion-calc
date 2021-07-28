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
            idcComission.Text = "0";
            idcPayment.Text = "0";
        }

        private void Calc()
        {
            bOkr = chkOkr.Checked;
            sPayment = idcPayment.Text;
            sComission = idcComission.Text;

            txtResult.Text = 
                calc.CalcPayWithCommission(sPayment, sComission, bOkr);            
        }

        private void idc_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void chkOkr_CheckedChanged(object sender, EventArgs e)
        {
            Calc();
        }
    }
}
