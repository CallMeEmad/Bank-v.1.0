using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Forms
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        { 
            if (!InputValidator())
            {
                MessageBox.Show("لطفا تمام فیلد ها را مقدار دهی کنید", "خطا");
                return;
            }
            DataHolder.SaveCustomers(GenerateCode(),
                txtName.Text,txtLastName.Text,int.Parse(txtAge.Text),txtAddress.Text,false);
            LoadCustomers();
            ClearUI();
        }

        private int GenerateCode()
        {
           DataTable dt =  (DataTable)dgCustomers.DataSource;
            if (dt == null || dt.Rows.Count <=0) return 1;
           return Convert.ToInt32(dgCustomers.Rows[dgCustomers.Rows.Count - 1].Cells["ID"].Value) + 1;
        }
        private void LoadCustomers()
        {
            dgCustomers.DataSource = DataHolder.RetrieveCustomers();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            GridSettings();
        }

        private void GridSettings()
        {
            dgCustomers.Columns["Used"].Visible = false;
            dgCustomers.Columns["ID"].HeaderText = "شناسه";
            dgCustomers.Columns["Name"].HeaderText = "نام";
            dgCustomers.Columns["LastName"].HeaderText = "نام خانوادگی";
            dgCustomers.Columns["Age"].HeaderText = "سن";
            dgCustomers.Columns["Address"].HeaderText = "آدرس";
        }

        private bool InputValidator()
        {
            bool key = true;
            if (txtName.Text.Trim().Equals(string.Empty))
                key = false;
            if (txtLastName.Text.Trim().Equals(string.Empty))
                key = false;
            if (txtAge.Text.Trim().Equals(string.Empty))
                key = false;
            if (txtAddress.Text.Trim().Equals(string.Empty))
                key = false;
            return key;
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }
        private void ClearUI()
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType() == new TextBox().GetType())
                {
                    TextBox t = (TextBox)item;
                    t.Text = string.Empty;
                }
            }
        }
    }
}
