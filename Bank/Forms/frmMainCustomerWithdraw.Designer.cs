namespace Bank.Forms
{
    partial class frmMainCustomerWithdraw
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
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(98, 92);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(128, 23);
            this.btnWithdraw.TabIndex = 0;
            this.btnWithdraw.Text = "برداشت وج";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(34, 54);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(240, 21);
            this.cmbCustomers.TabIndex = 1;
            this.cmbCustomers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCustomers_KeyPress);
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(228, 30);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(49, 13);
            this.lblCustomers.TabIndex = 2;
            this.lblCustomers.Text = "مشتری : ";
            // 
            // frmMainCustomerWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 137);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.btnWithdraw);
            this.Location = new System.Drawing.Point(342, 176);
            this.MaximumSize = new System.Drawing.Size(342, 176);
            this.Name = "frmMainCustomerWithdraw";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "برداشت وجه فردی(برداشت به تنهایی)";
            this.Load += new System.EventHandler(this.fromMainCustomerWithdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label lblCustomers;
    }
}