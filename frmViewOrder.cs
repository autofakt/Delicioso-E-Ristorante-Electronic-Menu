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
    public partial class frmViewOrder : Form
    {
        public frmViewOrder()
        {
            InitializeComponent();
        }

        // Lee //
        // Added event handler to OrderMore button which closes form //
        private void btnOrderMore_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRequestCheck_Click(object sender, EventArgs e)
        {
            frmBillAndPayment paymentForm = new frmBillAndPayment();
            for (int i = 0; i < frmMainMenu.getItemCounter(); i++)
                paymentForm.lstItemizedBill.Items.Add(frmMainMenu.quantity[i] + " " + frmMainMenu.items[i] +"\t" + (frmMainMenu.quantity[i] * frmMainMenu.price[i]));
            double subTotal = frmMainMenu.getEstimate();
            paymentForm.tbxSubTotal.Text = subTotal.ToString("C");
            double taxRate = 0.095;
            double tax = subTotal * taxRate;
            paymentForm.tbxTax.Text = tax.ToString("C");
           
            double tip = 0;
            paymentForm.tbxTip.Text = tip.ToString("C");
            paymentForm.rbtn0.Checked = true;

            double grandTotal = subTotal + tax;
            paymentForm.tbxGrandTotal.Text = grandTotal.ToString("C");

            paymentForm.ShowDialog();
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for placing your order, the kitchen is preparing your food, you can continue ordering.");
        }
    }
}
