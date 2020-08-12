using Bank.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class fromBank : Form
    {
        public fromBank()
        {
            InitializeComponent();
        }

        private void exitTSM_Click(object sender, EventArgs e)
        {
            var Result = MessageBox.Show("آیا میخواهید خارج شوید ؟ ", "خروج",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
                Application.Exit();
        }

        private void customersTSM_Click(object sender, EventArgs e)
        {
            frmCustomer customers = new frmCustomer();
            customers.Show();
        }

        private void rolesTSM_Click(object sender, EventArgs e)
        {
            var hasCustomer = DataHolder.RetrieveCustomers().Rows.Count > 0;
            if (!hasCustomer)
            {
                MessageBox.Show("لطفا اول مشتریان را تعریف کنید","");
                return;
            }
            frmRoles roles = new frmRoles();
            roles.Show();
        }

        private void mainWithdrawMoneyTSM_Click(object sender, EventArgs e)
        {
            var hasMainCustomer = DataHolder.RetrieveMainCustomers().Rows.Count > 0;
            if (!hasMainCustomer)
            {
                MessageBox.Show("به سطوح دسترسی رفته و مشتری (حق برداشت به تنهای) انتخاب کنید ", "مشتری یافت نشد");
                return;
            }
            frmMainCustomerWithdraw fromMainCustomer = new frmMainCustomerWithdraw();
            fromMainCustomer.Show();
        }

        private void withdrawWithSignTSM_Click(object sender, EventArgs e)
        {
            var hasMainCustomer = DataHolder.RetrieveCustomersWithSignLimit().Rows.Count > 0;
            if (!hasMainCustomer)
            {
                MessageBox.Show("به سطوح دسترسی رفته و مشتری (حق برداشت با کفایت امضا) انتخاب کنید ", "مشتری یافت نشد");
                return;
            }
            frmWithdrawBySignersSign withdrawBySignersSign = new frmWithdrawBySignersSign();
            withdrawBySignersSign.Show();
        }
    }
}
