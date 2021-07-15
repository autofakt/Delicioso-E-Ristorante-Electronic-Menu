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
        public static string paymentType = "";

        public frmBillAndPayment()
        {
            InitializeComponent();
        }

        private void rbtnCreditCard_CheckedChanged(object sender, EventArgs e)
        {

            paymentType = "Credit Card";
            // Lee //
            // Added Payment method Prompt which becomes visible after user selects Credit Card //
            lblPymtMthdPrompt.Visible = true;
            lblPymtMthdPrompt.Text = "Please enter your Credit Card information.";

            txtCardNumber.ReadOnly = false;
            txtExpDate.ReadOnly = false;
            txtPinNumber.ReadOnly = true;
        }

        private void rbtnCash_CheckedChanged(object sender, EventArgs e)
        {
            paymentType = "Cash";
            // Added Payment method Prompt which becomes visible after user selects Cash //
            lblPymtMthdPrompt.Visible = true;
            lblPymtMthdPrompt.Text = "Please wait for the waiter to return to pay in cash.";

            txtCardNumber.ReadOnly = true;
            txtExpDate.ReadOnly = true;
            txtPinNumber.ReadOnly = true;
        }

        private void rbtnDebitCard_CheckedChanged(object sender, EventArgs e)
        {
            paymentType = "Debit Card";

            // Added Payment method Prompt which becomes visible after user selects Debit Card //
            lblPymtMthdPrompt.Visible = true;
            lblPymtMthdPrompt.Text = "Please enter your Debit Card information.";

            txtCardNumber.ReadOnly = false;
            txtExpDate.ReadOnly = false;
            txtPinNumber.ReadOnly = false;
        }

        private void btnPayBill_Click(object sender, EventArgs e)
        {
            
            frmReceipt receiptForm = new frmReceipt();
            DateTime now = DateTime.Now;
            string format = "MMM ddd d HH:mm yyyy";
            receiptForm.lblDateInfo.Text = now.ToString(format);

            for (int i = 0; i < frmMainMenu.getItemCounter(); i++)
                receiptForm.lstItemsOrdered.Items.Add(frmMainMenu.quantity[i] + " " + frmMainMenu.items[i] + "\t" + (frmMainMenu.quantity[i] * frmMainMenu.price[i]));
            double subTotal = frmMainMenu.getEstimate();
            receiptForm.lblSubTotal.Text = subTotal.ToString("C");
            double taxRate = 0.095;
            double tax = subTotal * taxRate;
            receiptForm.lblTaxInfo.Text = tax.ToString("C");

            double tip = double.Parse(tbxTip.Text.Substring(1));
            receiptForm.lblTipInfo.Text = tip.ToString("C");
            

            double grandTotal = subTotal + tax + tip;
            receiptForm.lblGrandTotalInfo.Text = grandTotal.ToString("C");

            receiptForm.lblMethodPymtInfo.Text = paymentType;
            receiptForm.lblCustNameInfo.Text = frmMainMenu.customerName;

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
