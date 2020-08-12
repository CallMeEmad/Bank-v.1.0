namespace Bank.Forms
{
    partial class frmWithdrawBySignersSign
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
            this.lstSignersCustomer = new System.Windows.Forms.ListBox();
            this.lstCustomerWithSignLimit = new System.Windows.Forms.ListBox();
            this.lblSignersCustomer = new System.Windows.Forms.Label();
            this.lblCustomersWithSignLimit = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblTitleTwo = new System.Windows.Forms.Label();
            this.lblSignersCount = new System.Windows.Forms.Label();
            this.lblSelectedCustomerWithSignLimitCount = new System.Windows.Forms.Label();
            this.lblTitleOne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSignersCustomer
            // 
            this.lstSignersCustomer.FormattingEnabled = true;
            this.lstSignersCustomer.Location = new System.Drawing.Point(12, 47);
            this.lstSignersCustomer.Name = "lstSignersCustomer";
            this.lstSignersCustomer.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSignersCustomer.Size = new System.Drawing.Size(145, 147);
            this.lstSignersCustomer.TabIndex = 0;
            this.lstSignersCustomer.SelectedIndexChanged += new System.EventHandler(this.lstSignersCustomer_SelectedIndexChanged);
            // 
            // lstCustomerWithSignLimit
            // 
            this.lstCustomerWithSignLimit.FormattingEnabled = true;
            this.lstCustomerWithSignLimit.Location = new System.Drawing.Point(163, 47);
            this.lstCustomerWithSignLimit.Name = "lstCustomerWithSignLimit";
            this.lstCustomerWithSignLimit.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstCustomerWithSignLimit.Size = new System.Drawing.Size(208, 147);
            this.lstCustomerWithSignLimit.TabIndex = 1;
            this.lstCustomerWithSignLimit.SelectedIndexChanged += new System.EventHandler(this.lstCustomerWithSignLimit_SelectedIndexChanged);
            // 
            // lblSignersCustomer
            // 
            this.lblSignersCustomer.AutoSize = true;
            this.lblSignersCustomer.Location = new System.Drawing.Point(43, 28);
            this.lblSignersCustomer.Name = "lblSignersCustomer";
            this.lblSignersCustomer.Size = new System.Drawing.Size(87, 13);
            this.lblSignersCustomer.TabIndex = 2;
            this.lblSignersCustomer.Text = "مشتریان حق امضا";
            // 
            // lblCustomersWithSignLimit
            // 
            this.lblCustomersWithSignLimit.AutoSize = true;
            this.lblCustomersWithSignLimit.Location = new System.Drawing.Point(172, 28);
            this.lblCustomersWithSignLimit.Name = "lblCustomersWithSignLimit";
            this.lblCustomersWithSignLimit.Size = new System.Drawing.Size(181, 13);
            this.lblCustomersWithSignLimit.TabIndex = 3;
            this.lblCustomersWithSignLimit.Text = "مشتریان برداشت در صورت کفایت امضا";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(265, 224);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(49, 13);
            this.lblCustomer.TabIndex = 6;
            this.lblCustomer.Text = "مشتری : ";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(71, 248);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(240, 21);
            this.cmbCustomers.TabIndex = 5;
            this.cmbCustomers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCustomers_KeyPress);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(135, 286);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(128, 23);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "برداشت وج";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblTitleTwo
            // 
            this.lblTitleTwo.AutoSize = true;
            this.lblTitleTwo.Location = new System.Drawing.Point(54, 198);
            this.lblTitleTwo.Name = "lblTitleTwo";
            this.lblTitleTwo.Size = new System.Drawing.Size(69, 13);
            this.lblTitleTwo.TabIndex = 7;
            this.lblTitleTwo.Text = "انتخاب شده : ";
            // 
            // lblSignersCount
            // 
            this.lblSignersCount.AutoSize = true;
            this.lblSignersCount.Location = new System.Drawing.Point(45, 198);
            this.lblSignersCount.Name = "lblSignersCount";
            this.lblSignersCount.Size = new System.Drawing.Size(13, 13);
            this.lblSignersCount.TabIndex = 8;
            this.lblSignersCount.Text = "0";
            // 
            // lblSelectedCustomerWithSignLimitCount
            // 
            this.lblSelectedCustomerWithSignLimitCount.AutoSize = true;
            this.lblSelectedCustomerWithSignLimitCount.Location = new System.Drawing.Point(224, 197);
            this.lblSelectedCustomerWithSignLimitCount.Name = "lblSelectedCustomerWithSignLimitCount";
            this.lblSelectedCustomerWithSignLimitCount.Size = new System.Drawing.Size(13, 13);
            this.lblSelectedCustomerWithSignLimitCount.TabIndex = 10;
            this.lblSelectedCustomerWithSignLimitCount.Text = "0";
            // 
            // lblTitleOne
            // 
            this.lblTitleOne.AutoSize = true;
            this.lblTitleOne.Location = new System.Drawing.Point(233, 197);
            this.lblTitleOne.Name = "lblTitleOne";
            this.lblTitleOne.Size = new System.Drawing.Size(69, 13);
            this.lblTitleOne.TabIndex = 9;
            this.lblTitleOne.Text = "انتخاب شده : ";
            // 
            // frmWithdrawBySignersSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 330);
            this.Controls.Add(this.lblSelectedCustomerWithSignLimitCount);
            this.Controls.Add(this.lblTitleOne);
            this.Controls.Add(this.lblSignersCount);
            this.Controls.Add(this.lblTitleTwo);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblCustomersWithSignLimit);
            this.Controls.Add(this.lblSignersCustomer);
            this.Controls.Add(this.lstCustomerWithSignLimit);
            this.Controls.Add(this.lstSignersCustomer);
            this.Name = "frmWithdrawBySignersSign";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "برداشت با کفایت امضا";
            this.Load += new System.EventHandler(this.frmWithdrawBySignersSign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSignersCustomer;
        private System.Windows.Forms.ListBox lstCustomerWithSignLimit;
        private System.Windows.Forms.Label lblSignersCustomer;
        private System.Windows.Forms.Label lblCustomersWithSignLimit;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblTitleTwo;
        private System.Windows.Forms.Label lblSignersCount;
        private System.Windows.Forms.Label lblSelectedCustomerWithSignLimitCount;
        private System.Windows.Forms.Label lblTitleOne;
    }
}