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
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void LoadCustomers()
        {
            
            var dtCustomers = DataHolder.RetrieveCustomers();
            Dictionary<int, string> dict = new Dictionary<int, string>();
            foreach (DataRow item in dtCustomers.Rows)
            {
                if (!Convert.ToBoolean(item["Used"]))
                    dict.Add(Convert.ToInt32(item["ID"]),
                        item["Name"].ToString() + " " + item["Lastname"].ToString());
            }

            cmbCustomers.DataSource = null;   
            cmbCustomers.DataSource = dict.ToList();
            cmbCustomers.DisplayMember = "Value";
            cmbCustomers.ValueMember = "Key";

        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            SetupMainCustomerGrid();
            SetupSignerCustomerGrid();
            SetupCustomerWithSignLimitGrid();
            GridSettings(dgMainCustomers);
            GridSettings(dgSignerCustomers);
            GridSettings(dgCustomerWithSignLimit);
        }

        private void btnMainCustomer_Click(object sender, EventArgs e)
        {
            if (!InputValidator())
            {
                MessageBox.Show("لطفا یک مشتری را انتخاب کنید", "خطا");
                return;
            }

            int customerID = Convert.ToInt32(cmbCustomers.SelectedValue);
            var selectedCustomer = DataHolder.RetrieveCustomers().Select($"ID='{customerID}'")[0];
            selectedCustomer["Used"] = true;
            

            DataHolder.SaveMainCustomers(Convert.ToInt32(selectedCustomer["ID"]), 
                selectedCustomer["Name"].ToString(), 
                selectedCustomer["Lastname"].ToString(), 
                Convert.ToInt32(selectedCustomer["Age"]), selectedCustomer["Address"].ToString());
            SetupMainCustomerGrid();
            LoadCustomers();
        }

        private void cmbCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;   
        }

        private void GridSettings(DataGridView gridView)
        {
            gridView.Columns["ID"].HeaderText = "شناسه";
            gridView.Columns["Name"].HeaderText = "نام";
            gridView.Columns["LastName"].HeaderText = "نام خانوادگی";
            gridView.Columns["Age"].HeaderText = "سن";
            gridView.Columns["Address"].HeaderText = "آدرس";
        }
        private void SetupMainCustomerGrid()
        {
            dgMainCustomers.DataSource = DataHolder.RetrieveMainCustomers();
        }
        private void SetupCustomerWithSignLimitGrid()
        {
            dgCustomerWithSignLimit.DataSource = DataHolder.RetrieveCustomersWithSignLimit();
        }
        private void SetupSignerCustomerGrid()
        {
            dgSignerCustomers.DataSource = DataHolder.RetrieveSignerCustomers();
        }
        private void btnSignerCustomer_Click(object sender, EventArgs e)
        {
            if (!InputValidator())
            {
                MessageBox.Show("لطفا یک مشتری را انتخاب کنید", "خطا");
                return;
            }
            int customerID = Convert.ToInt32(cmbCustomers.SelectedValue);
            var selectedCustomer = DataHolder.RetrieveCustomers().Select($"ID='{customerID}'")[0];
            selectedCustomer["Used"] = true;

            DataHolder.SaveSignerCustomers(Convert.ToInt32(selectedCustomer["ID"]),
                selectedCustomer["Name"].ToString(),
                selectedCustomer["Lastname"].ToString(),
                Convert.ToInt32(selectedCustomer["Age"]), selectedCustomer["Address"].ToString());
            SetupSignerCustomerGrid();
            LoadCustomers();
        }
        private void btnCustomerWithSignLimit_Click(object sender, EventArgs e)
        {
            if (!InputValidator())
            {
                MessageBox.Show("لطفا یک مشتری را انتخاب کنید", "خطا");
                return;
            }
            int customerID = Convert.ToInt32(cmbCustomers.SelectedValue);
            var selectedCustomer = DataHolder.RetrieveCustomers().Select($"ID='{customerID}'")[0];
            selectedCustomer["Used"] = true;

            DataHolder.SaveCustomersWithSignLimit(Convert.ToInt32(selectedCustomer["ID"]),
                selectedCustomer["Name"].ToString(),
                selectedCustomer["Lastname"].ToString(),
                Convert.ToInt32(selectedCustomer["Age"]), selectedCustomer["Address"].ToString());
            SetupCustomerWithSignLimitGrid();
            LoadCustomers();
        }
        private bool InputValidator()
        {
            if (cmbCustomers.SelectedIndex < 0)
                return false;
            return true;
        }

    }
}
