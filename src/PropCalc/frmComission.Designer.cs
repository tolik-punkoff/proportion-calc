namespace PropCalc
{
    partial class frmComission
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComission));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.chkOkr = new System.Windows.Forms.CheckBox();
            this.idcPayment = new Wildsoft.Controls.InputDigitControl();
            this.idcComission = new Wildsoft.Controls.InputDigitControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сумма платежа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Комиссия (%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сумма для внесения:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(126, 61);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(312, 20);
            this.txtResult.TabIndex = 5;
            // 
            // chkOkr
            // 
            this.chkOkr.AutoSize = true;
            this.chkOkr.Location = new System.Drawing.Point(9, 87);
            this.chkOkr.Name = "chkOkr";
            this.chkOkr.Size = new System.Drawing.Size(132, 17);
            this.chkOkr.TabIndex = 6;
            this.chkOkr.Text = "Округлить до целого";
            this.chkOkr.UseVisualStyleBackColor = true;
            this.chkOkr.CheckedChanged += new System.EventHandler(this.chkOkr_CheckedChanged);
            // 
            // idcPayment
            // 
            this.idcPayment.Fractional = true;
            this.idcPayment.Location = new System.Drawing.Point(126, 8);
            this.idcPayment.Name = "idcPayment";
            this.idcPayment.Size = new System.Drawing.Size(312, 20);
            this.idcPayment.TabIndex = 1;
            this.idcPayment.TextChanged += new System.EventHandler(this.idc_TextChanged);
            // 
            // idcComission
            // 
            this.idcComission.Fractional = true;
            this.idcComission.Location = new System.Drawing.Point(126, 35);
            this.idcComission.Name = "idcComission";
            this.idcComission.Size = new System.Drawing.Size(312, 20);
            this.idcComission.TabIndex = 3;
            this.idcComission.TextChanged += new System.EventHandler(this.idc_TextChanged);
            // 
            // frmComission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 108);
            this.Controls.Add(this.idcComission);
            this.Controls.Add(this.idcPayment);
            this.Controls.Add(this.chkOkr);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmComission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Расчет платежа с комиссией";
            this.Load += new System.EventHandler(this.frmComission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.CheckBox chkOkr;
        private Wildsoft.Controls.InputDigitControl idcPayment;
        private Wildsoft.Controls.InputDigitControl idcComission;
    }
}