namespace PropCalc
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtA = new System.Windows.Forms.TextBox();
            this.chkXA = new System.Windows.Forms.CheckBox();
            this.chkXB = new System.Windows.Forms.CheckBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.chkXD = new System.Windows.Forms.CheckBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.chkXC = new System.Windows.Forms.CheckBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCopy = new System.Windows.Forms.CheckBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pbDrawFormula = new System.Windows.Forms.PictureBox();
            this.pbFormula = new System.Windows.Forms.PictureBox();
            this.pbScheme = new System.Windows.Forms.PictureBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuPaymentWithComission = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScheme)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(2, 29);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(184, 20);
            this.txtA.TabIndex = 0;
            this.txtA.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // chkXA
            // 
            this.chkXA.AutoSize = true;
            this.chkXA.Location = new System.Drawing.Point(193, 31);
            this.chkXA.Name = "chkXA";
            this.chkXA.Size = new System.Drawing.Size(33, 17);
            this.chkXA.TabIndex = 1;
            this.chkXA.Text = "X";
            this.chkXA.UseVisualStyleBackColor = true;
            this.chkXA.CheckedChanged += new System.EventHandler(this.chkX_CheckedChanged);
            // 
            // chkXB
            // 
            this.chkXB.AutoSize = true;
            this.chkXB.Location = new System.Drawing.Point(423, 31);
            this.chkXB.Name = "chkXB";
            this.chkXB.Size = new System.Drawing.Size(33, 17);
            this.chkXB.TabIndex = 3;
            this.chkXB.Text = "X";
            this.chkXB.UseVisualStyleBackColor = true;
            this.chkXB.CheckedChanged += new System.EventHandler(this.chkX_CheckedChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(232, 29);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(184, 20);
            this.txtB.TabIndex = 2;
            this.txtB.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // chkXD
            // 
            this.chkXD.AutoSize = true;
            this.chkXD.Location = new System.Drawing.Point(423, 57);
            this.chkXD.Name = "chkXD";
            this.chkXD.Size = new System.Drawing.Size(33, 17);
            this.chkXD.TabIndex = 7;
            this.chkXD.Text = "X";
            this.chkXD.UseVisualStyleBackColor = true;
            this.chkXD.CheckedChanged += new System.EventHandler(this.chkX_CheckedChanged);
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(232, 55);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(184, 20);
            this.txtD.TabIndex = 6;
            this.txtD.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // chkXC
            // 
            this.chkXC.AutoSize = true;
            this.chkXC.Location = new System.Drawing.Point(193, 57);
            this.chkXC.Name = "chkXC";
            this.chkXC.Size = new System.Drawing.Size(33, 17);
            this.chkXC.TabIndex = 5;
            this.chkXC.Text = "X";
            this.chkXC.UseVisualStyleBackColor = true;
            this.chkXC.CheckedChanged += new System.EventHandler(this.chkX_CheckedChanged);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(2, 55);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(184, 20);
            this.txtC.TabIndex = 4;
            this.txtC.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // btnShowHide
            // 
            this.btnShowHide.Location = new System.Drawing.Point(2, 80);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(107, 23);
            this.btnShowHide.TabIndex = 8;
            this.btnShowHide.Text = "Показать схему";
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(186, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "==>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(419, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "==>";
            // 
            // chkCopy
            // 
            this.chkCopy.AutoSize = true;
            this.chkCopy.Location = new System.Drawing.Point(116, 83);
            this.chkCopy.Name = "chkCopy";
            this.chkCopy.Size = new System.Drawing.Size(140, 17);
            this.chkCopy.TabIndex = 14;
            this.chkCopy.Text = "Копировать результат";
            this.chkCopy.UseVisualStyleBackColor = true;
            this.chkCopy.CheckedChanged += new System.EventHandler(this.chkCopy_CheckedChanged);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(349, 81);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(107, 23);
            this.btnAbout.TabIndex = 15;
            this.btnAbout.Text = "О программе...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pbDrawFormula
            // 
            this.pbDrawFormula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbDrawFormula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDrawFormula.Location = new System.Drawing.Point(2, 252);
            this.pbDrawFormula.Name = "pbDrawFormula";
            this.pbDrawFormula.Size = new System.Drawing.Size(454, 133);
            this.pbDrawFormula.TabIndex = 12;
            this.pbDrawFormula.TabStop = false;
            // 
            // pbFormula
            // 
            this.pbFormula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbFormula.Location = new System.Drawing.Point(232, 109);
            this.pbFormula.Name = "pbFormula";
            this.pbFormula.Size = new System.Drawing.Size(184, 133);
            this.pbFormula.TabIndex = 10;
            this.pbFormula.TabStop = false;
            // 
            // pbScheme
            // 
            this.pbScheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbScheme.Location = new System.Drawing.Point(2, 109);
            this.pbScheme.Name = "pbScheme";
            this.pbScheme.Size = new System.Drawing.Size(184, 133);
            this.pbScheme.TabIndex = 9;
            this.pbScheme.TabStop = false;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPaymentWithComission});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(464, 24);
            this.mnuMain.TabIndex = 16;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuPaymentWithComission
            // 
            this.mnuPaymentWithComission.Name = "mnuPaymentWithComission";
            this.mnuPaymentWithComission.Size = new System.Drawing.Size(164, 20);
            this.mnuPaymentWithComission.Text = "Расчет платежа с комиссией";
            this.mnuPaymentWithComission.Click += new System.EventHandler(this.mnuPaymentWithComission_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 388);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.chkCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbDrawFormula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbFormula);
            this.Controls.Add(this.pbScheme);
            this.Controls.Add(this.btnShowHide);
            this.Controls.Add(this.chkXD);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.chkXC);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.chkXB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.chkXA);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор пропорций";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScheme)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.CheckBox chkXA;
        private System.Windows.Forms.CheckBox chkXB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.CheckBox chkXD;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.CheckBox chkXC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.PictureBox pbScheme;
        private System.Windows.Forms.PictureBox pbFormula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbDrawFormula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkCopy;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuPaymentWithComission;
    }
}

