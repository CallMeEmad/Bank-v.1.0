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
    public partial class frmMainCustomerWithdraw : Form
    {
        public frmMainCustomerWithdraw()
        {
            InitializeComponent();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedIndex > -1)
            {
                MessageBox.Show("برداشت وجه با موفقیت انجام شد", "موفقیت");
            }
        }
        private void LoadCustomers()
        {
            var dtCustomers = DataHolder.RetrieveMainCustomers();
            Dictionary<int, string> dict = new Dictionary<int, string>();
            foreach (DataRow item in dtCustomers.Rows)
            {

                dict.Add(Convert.ToInt32(item["ID"]),
                    item["Name"].ToString() + " " + item["Lastname"].ToString());
            }

            cmbCustomers.DataSource = null;
            cmbCustomers.DataSource = dict.ToList();
            cmbCustomers.DisplayMember = "Value";
            cmbCustomers.ValueMember = "Key";
        }

        private void fromMainCustomerWithdraw_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void cmbCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;   
        }
    }
}
