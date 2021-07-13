using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectGUIDraft
{
    public partial class frmBillAndPayment : Form
    {
        public frmBillAndPayment()
        {
            InitializeComponent();
        }

        private void rbtnCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            txtCardNumber.ReadOnly = false;
            txtExpDate.ReadOnly = false;
            txtPinNumber.ReadOnly = true;
        }

        private void rbtnCash_CheckedChanged(object sender, EventArgs e)
        {
            txtCardNumber.ReadOnly = true;
            txtExpDate.ReadOnly = true;
            txtPinNumber.ReadOnly = true;
        }

        private void rbtnDebitCard_CheckedChanged(object sender, EventArgs e)
        {
            txtCardNumber.ReadOnly = false;
            txtExpDate.ReadOnly = false;
            txtPinNumber.ReadOnly = false;
        }

        private void btnPayBill_Click(object sender, EventArgs e)
        {
            frmReceipt receiptForm = new frmReceipt();

            receiptForm.ShowDialog();
        }
    }
}
