namespace Bank.Forms
{
    partial class frmRoles
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
            this.dgCustomerWithSignLimit = new System.Windows.Forms.DataGridView();
            this.dgSignerCustomers = new System.Windows.Forms.DataGridView();
            this.dgMainCustomers = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.lblOneTitle = new System.Windows.Forms.Label();
            this.lblTwoTitle = new System.Windows.Forms.Label();
            this.lblThreeTitle = new System.Windows.Forms.Label();
            this.btnMainCustomer = new System.Windows.Forms.Button();
            this.btnSignerCustomer = new System.Windows.Forms.Button();
            this.btnCustomerWithSignLimit = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerWithSignLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSignerCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMainCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCustomerWithSignLimit
            // 
            this.dgCustomerWithSignLimit.AllowUserToAddRows = false;
            this.dgCustomerWithSignLimit.AllowUserToDeleteRows = false;
            this.dgCustomerWithSignLimit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomerWithSignLimit.Location = new System.Drawing.Point(12, 66);
            this.dgCustomerWithSignLimit.Name = "dgCustomerWithSignLimit";
            this.dgCustomerWithSignLimit.ReadOnly = true;
            this.dgCustomerWithSignLimit.Size = new System.Drawing.Size(255, 244);
            this.dgCustomerWithSignLimit.TabIndex = 0;
            // 
            // dgSignerCustomers
            // 
            this.dgSignerCustomers.AllowUserToAddRows = false;
            this.dgSignerCustomers.AllowUserToDeleteRows = false;
            this.dgSignerCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSignerCustomers.Location = new System.Drawing.Point(271, 66);
            this.dgSignerCustomers.Name = "dgSignerCustomers";
            this.dgSignerCustomers.ReadOnly = true;
            this.dgSignerCustomers.Size = new System.Drawing.Size(255, 244);
            this.dgSignerCustomers.TabIndex = 1;
            // 
            // dgMainCustomers
            // 
            this.dgMainCustomers.AllowUserToAddRows = false;
            this.dgMainCustomers.AllowUserToDeleteRows = false;
            this.dgMainCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMainCustomers.Location = new System.Drawing.Point(530, 66);
            this.dgMainCustomers.Name = "dgMainCustomers";
            this.dgMainCustomers.ReadOnly = true;
            this.dgMainCustomers.Size = new System.Drawing.Size(255, 244);
            this.dgMainCustomers.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 351);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(209, 12);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(401, 21);
            this.cmbCustomers.TabIndex = 5;
            this.cmbCustomers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCustomers_KeyPress);
            // 
            // lblOneTitle
            // 
            this.lblOneTitle.AutoSize = true;
            this.lblOneTitle.Location = new System.Drawing.Point(587, 50);
            this.lblOneTitle.Name = "lblOneTitle";
            this.lblOneTitle.Size = new System.Drawing.Size(136, 13);
            this.lblOneTitle.TabIndex = 6;
            this.lblOneTitle.Text = " سطح حق برداشت به تنهایی";
            // 
            // lblTwoTitle
            // 
            this.lblTwoTitle.AutoSize = true;
            this.lblTwoTitle.Location = new System.Drawing.Point(360, 50);
            this.lblTwoTitle.Name = "lblTwoTitle";
            this.lblTwoTitle.Size = new System.Drawing.Size(73, 13);
            this.lblTwoTitle.TabIndex = 7;
            this.lblTwoTitle.Text = "سطح حق امضا";
            // 
            // lblThreeTitle
            // 
            this.lblThreeTitle.AutoSize = true;
            this.lblThreeTitle.Location = new System.Drawing.Point(48, 50);
            this.lblThreeTitle.Name = "lblThreeTitle";
            this.lblThreeTitle.Size = new System.Drawing.Size(188, 13);
            this.lblThreeTitle.TabIndex = 8;
            this.lblThreeTitle.Text = " سطح حق برداشت در صورت کفایت امضا";
            // 
            // btnMainCustomer
            // 
            this.btnMainCustomer.Location = new System.Drawing.Point(765, 313);
            this.btnMainCustomer.Name = "btnMainCustomer";
            this.btnMainCustomer.Size = new System.Drawing.Size(22, 23);
            this.btnMainCustomer.TabIndex = 9;
            this.btnMainCustomer.Text = "+";
            this.btnMainCustomer.UseVisualStyleBackColor = true;
            this.btnMainCustomer.Click += new System.EventHandler(this.btnMainCustomer_Click);
            // 
            // btnSignerCustomer
            // 
            this.btnSignerCustomer.Location = new System.Drawing.Point(504, 313);
            this.btnSignerCustomer.Name = "btnSignerCustomer";
            this.btnSignerCustomer.Size = new System.Drawing.Size(22, 23);
            this.btnSignerCustomer.TabIndex = 10;
            this.btnSignerCustomer.Text = "+";
            this.btnSignerCustomer.UseVisualStyleBackColor = true;
            this.btnSignerCustomer.Click += new System.EventHandler(this.btnSignerCustomer_Click);
            // 
            // btnCustomerWithSignLimit
            // 
            this.btnCustomerWithSignLimit.Location = new System.Drawing.Point(246, 314);
            this.btnCustomerWithSignLimit.Name = "btnCustomerWithSignLimit";
            this.btnCustomerWithSignLimit.Size = new System.Drawing.Size(22, 23);
            this.btnCustomerWithSignLimit.TabIndex = 11;
            this.btnCustomerWithSignLimit.Text = "+";
            this.btnCustomerWithSignLimit.UseVisualStyleBackColor = true;
            this.btnCustomerWithSignLimit.Click += new System.EventHandler(this.btnCustomerWithSignLimit_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(612, 16);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(54, 13);
            this.lblCustomer.TabIndex = 12;
            this.lblCustomer.Text = "مشتریان : ";
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 386);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.btnCustomerWithSignLimit);
            this.Controls.Add(this.btnSignerCustomer);
            this.Controls.Add(this.btnMainCustomer);
            this.Controls.Add(this.lblThreeTitle);
            this.Controls.Add(this.lblTwoTitle);
            this.Controls.Add(this.lblOneTitle);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgMainCustomers);
            this.Controls.Add(this.dgSignerCustomers);
            this.Controls.Add(this.dgCustomerWithSignLimit);
            this.MaximumSize = new System.Drawing.Size(836, 425);
            this.MinimumSize = new System.Drawing.Size(836, 425);
            this.Name = "frmRoles";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "سطوح";
            this.Load += new System.EventHandler(this.frmRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerWithSignLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSignerCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMainCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCustomerWithSignLimit;
        private System.Windows.Forms.DataGridView dgSignerCustomers;
        private System.Windows.Forms.DataGridView dgMainCustomers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label lblOneTitle;
        private System.Windows.Forms.Label lblTwoTitle;
        private System.Windows.Forms.Label lblThreeTitle;
        private System.Windows.Forms.Button btnMainCustomer;
        private System.Windows.Forms.Button btnSignerCustomer;
        private System.Windows.Forms.Button btnCustomerWithSignLimit;
        private System.Windows.Forms.Label lblCustomer;
    }
}