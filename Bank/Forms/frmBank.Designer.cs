namespace Bank
{
    partial class fromBank
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.moneyTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.mainWithdrawMoneyTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawWithSignTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.baseInfoTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.customersTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionTSM,
            this.baseInfoTSM,
            this.exitTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionTSM
            // 
            this.actionTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moneyTSM});
            this.actionTSM.Name = "actionTSM";
            this.actionTSM.Size = new System.Drawing.Size(55, 20);
            this.actionTSM.Text = "عملیات";
            // 
            // moneyTSM
            // 
            this.moneyTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainWithdrawMoneyTSM,
            this.withdrawWithSignTSM});
            this.moneyTSM.Name = "moneyTSM";
            this.moneyTSM.Size = new System.Drawing.Size(152, 22);
            this.moneyTSM.Text = "برداشت وجه";
            // 
            // mainWithdrawMoneyTSM
            // 
            this.mainWithdrawMoneyTSM.Name = "mainWithdrawMoneyTSM";
            this.mainWithdrawMoneyTSM.Size = new System.Drawing.Size(183, 22);
            this.mainWithdrawMoneyTSM.Text = "برداشت به تنهایی";
            this.mainWithdrawMoneyTSM.Click += new System.EventHandler(this.mainWithdrawMoneyTSM_Click);
            // 
            // withdrawWithSignTSM
            // 
            this.withdrawWithSignTSM.Name = "withdrawWithSignTSM";
            this.withdrawWithSignTSM.Size = new System.Drawing.Size(183, 22);
            this.withdrawWithSignTSM.Text = "برداشت با کفایت امضا";
            this.withdrawWithSignTSM.Click += new System.EventHandler(this.withdrawWithSignTSM_Click);
            // 
            // baseInfoTSM
            // 
            this.baseInfoTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersTSM,
            this.rolesTSM});
            this.baseInfoTSM.Name = "baseInfoTSM";
            this.baseInfoTSM.Size = new System.Drawing.Size(80, 20);
            this.baseInfoTSM.Text = "اطلاعات پایه";
            // 
            // customersTSM
            // 
            this.customersTSM.Name = "customersTSM";
            this.customersTSM.Size = new System.Drawing.Size(152, 22);
            this.customersTSM.Text = "مشتریان";
            this.customersTSM.Click += new System.EventHandler(this.customersTSM_Click);
            // 
            // rolesTSM
            // 
            this.rolesTSM.Name = "rolesTSM";
            this.rolesTSM.Size = new System.Drawing.Size(152, 22);
            this.rolesTSM.Text = "سطوح دسترسی";
            this.rolesTSM.Click += new System.EventHandler(this.rolesTSM_Click);
            // 
            // exitTSM
            // 
            this.exitTSM.Name = "exitTSM";
            this.exitTSM.Size = new System.Drawing.Size(44, 20);
            this.exitTSM.Text = "خروج";
            this.exitTSM.Click += new System.EventHandler(this.exitTSM_Click);
            // 
            // fromBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 466);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fromBank";
            this.Text = "بانک";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionTSM;
        private System.Windows.Forms.ToolStripMenuItem moneyTSM;
        private System.Windows.Forms.ToolStripMenuItem baseInfoTSM;
        private System.Windows.Forms.ToolStripMenuItem customersTSM;
        private System.Windows.Forms.ToolStripMenuItem rolesTSM;
        private System.Windows.Forms.ToolStripMenuItem exitTSM;
        private System.Windows.Forms.ToolStripMenuItem mainWithdrawMoneyTSM;
        private System.Windows.Forms.ToolStripMenuItem withdrawWithSignTSM;
    }
}

