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

        private void rbtn10_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn10.Checked)
            {
                double percent10 = .10;
                double newTip = (double.Parse(tbxSubTotal.Text.Substring(1)) * percent10);
                tbxTip.Text = newTip.ToString("C");
                double subTotal = double.Parse(tbxSubTotal.Text.Substring(1));
                double tax = double.Parse(tbxTax.Text.Substring(1));
                tbxGrandTotal.Text = (subTotal + tax + newTip).ToString("C");

                
            }
                
        }

        private void rbtn15_CheckedChanged(object sender, EventArgs e)
        {
            double percent15 = .15;
            double newTip = (double.Parse(tbxSubTotal.Text.Substring(1)) * percent15);
            tbxTip.Text = newTip.ToString("C");
            double subTotal = double.Parse(tbxSubTotal.Text.Substring(1));
            double tax = double.Parse(tbxTax.Text.Substring(1));
            tbxGrandTotal.Text = (subTotal + tax + newTip).ToString("C");
        }

        private void rbtn20_CheckedChanged(object sender, EventArgs e)
        {
            double percent20 = .20;
            double newTip = (double.Parse(tbxSubTotal.Text.Substring(1)) * percent20);
            tbxTip.Text = newTip.ToString("C");
            double subTotal = double.Parse(tbxSubTotal.Text.Substring(1));
            double tax = double.Parse(tbxTax.Text.Substring(1));
            tbxGrandTotal.Text = (subTotal + tax + newTip).ToString("C");
        }

        private void rbtn25_CheckedChanged(object sender, EventArgs e)
        {
            double percent25 = .25;
            double newTip = (double.Parse(tbxSubTotal.Text.Substring(1)) * percent25);
            tbxTip.Text = newTip.ToString("C");
            double subTotal = double.Parse(tbxSubTotal.Text.Substring(1));
            double tax = double.Parse(tbxTax.Text.Substring(1));
            tbxGrandTotal.Text = (subTotal + tax + newTip).ToString("C");
        }

        private void rbtn0_CheckedChanged(object sender, EventArgs e)
        {
            
            double newTip = 0;
            tbxTip.Text = newTip.ToString("C");
            double subTotal = double.Parse(tbxSubTotal.Text.Substring(1));
            double tax = double.Parse(tbxTax.Text.Substring(1));
            tbxGrandTotal.Text = (subTotal + tax).ToString("C");
        }
    }
}
