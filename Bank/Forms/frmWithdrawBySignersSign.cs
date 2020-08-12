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
    public partial class frmWithdrawBySignersSign : Form
    {
        public frmWithdrawBySignersSign()
        {
            InitializeComponent();
        }
        private void cmbCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void frmWithdrawBySignersSign_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadListBox(lstSignersCustomer, DataHolder.RetrieveSignerCustomers());
            LoadListBox(lstCustomerWithSignLimit, DataHolder.RetrieveCustomersWithSignLimit());
        }

        private void LoadListBox(ListBox list, DataTable dataList)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            foreach (DataRow item in dataList.Rows)
            {

                dict.Add(Convert.ToInt32(item["ID"]),
                    item["Name"].ToString() + " " + item["Lastname"].ToString());
            }
            list.DataSource = null;
            list.DataSource = dict.ToList();
            list.DisplayMember = "Value";
            list.ValueMember = "Key";
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
        private void lstSignersCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSignersCount.Text = lstSignersCustomer.SelectedIndices.Count.ToString();
        }
        private void lstCustomerWithSignLimit_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectedCustomerWithSignLimitCount.Text = lstCustomerWithSignLimit.SelectedIndices.Count.ToString();
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedIndex < 0)
            {
                MessageBox.Show("لطفا یک مشتری برای برداشت وجه انتخاب کنید","خطا");
                return;
            }

            bool FirstCondition = lstSignersCustomer.SelectedIndices.Count + 1 >=
                lstSignersCustomer.Items.Count;
            bool SecondCondition = lstCustomerWithSignLimit.SelectedIndices.Count ==
                        lstCustomerWithSignLimit.Items.Count;

            if (FirstCondition || SecondCondition)
            {
                MessageBox.Show("برداشت وجه با موفقیت انجام شد", "موفقیت");
            }
            else
            {
                MessageBox.Show("برای برداشت وجه یا باید تمام مشتریان برداشت در صورت کفایت امضا , امضا کنند یا از مشتریان حق امضا حداقل همه بجز یکنفر امضا کنند", "عدم کفایت");
            }

        }
    }
}
