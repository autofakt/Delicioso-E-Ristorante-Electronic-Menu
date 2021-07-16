using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            //Yongqin Lin
            lblDateFormat.Visible = true;
            lblCardNumberFormat.Visible = true;
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

        private void writeReceiptCounter()
        {
            StreamWriter outputFile;
            outputFile = File.CreateText("receiptCounter.txt");
            outputFile.WriteLine(frmMainMenu.receiptCounter.ToString());
            outputFile.Close();
        }
        // Lee //
        // Method checks if string consists of numbers only //
        public bool isOnlyDigits(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        // Lee //
        // Method checks if string is has a valid length //
        public bool validCardLength()
        {
            if (txtCardNumber.TextLength == 16)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Executes if Pay Bill button is clicked //
        private void btnPayBill_Click(object sender, EventArgs e)
        {
            // Lee //
            // Call methods to validate card information //
            if (validCardLength())
            {
                string cardNumber = txtCardNumber.Text;
                if (isOnlyDigits(cardNumber))
                {
                    //Yongqin Lin
                    //Add a hyphen(-) after every 4 numbers after customer entered all 16 digits
                    var list = Enumerable
                    .Range(0, cardNumber.Length / 4)
                    .Select(i => cardNumber.Substring(i * 4, 4))
                    .ToList();
                    var resl = string.Join("-", list);
                    txtCardNumber.Text = resl;

                    frmReceipt receiptForm = new frmReceipt();
                    DateTime now = DateTime.Now;
                    string format = "MMM ddd d HH:mm yyyy";
                    receiptForm.lblDateInfo.Text = now.ToString(format);

                    receiptForm.lblReceiptNumInfo.Text = frmMainMenu.receiptCounter++.ToString(); // gets receipt number and increments
                    writeReceiptCounter(); // writes new receipt counter value to file.

                    for (int i = 0; i < frmMainMenu.getItemCounterFinal(); i++)
                        receiptForm.lstItemsOrdered.Items.Add(frmMainMenu.quantityFinal[i] + " " + frmMainMenu.itemsFinal[i] + "\t" + (frmMainMenu.quantityFinal[i] * frmMainMenu.priceFinal[i]));

                    //double subTotal = frmMainMenu.getEstimate();
                    double subTotal = frmViewOrder.getEstimate();
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

                    this.Close();
                }
                else // Else displays error message //
                {
                    MessageBox.Show("Please only enter numbers and try again.");
                }
            }
            else // Else displays error message //
            {
                MessageBox.Show("Please enter a valid 16 digit card number and try again.");
            }
        }

        private void rbtn10_CheckedChanged(object sender, EventArgs e)
        {
            chkRoundTip.Enabled = true;
            if (chkRoundTip.Checked)
                chkRoundTip.Checked = false;
            double percent10 = .10;
            double newTip = (double.Parse(tbxSubTotal.Text.Substring(1)) * percent10);
            tbxTip.Text = newTip.ToString("C");
            double subTotal = double.Parse(tbxSubTotal.Text.Substring(1));
            double tax = double.Parse(tbxTax.Text.Substring(1));
            tbxGrandTotal.Text = (subTotal + tax + newTip).ToString("C");
        }

        private void rbtn15_CheckedChanged(object sender, EventArgs e)
        {
            chkRoundTip.Enabled = true;
            if (chkRoundTip.Checked)
                chkRoundTip.Checked = false;
            double percent15 = .15;
            double newTip = (double.Parse(tbxSubTotal.Text.Substring(1)) * percent15);
            tbxTip.Text = newTip.ToString("C");
            double subTotal = double.Parse(tbxSubTotal.Text.Substring(1));
            double tax = double.Parse(tbxTax.Text.Substring(1));
            tbxGrandTotal.Text = (subTotal + tax + newTip).ToString("C");
        }

        private void rbtn20_CheckedChanged(object sender, EventArgs e)
        {
            chkRoundTip.Enabled = true;
            if (chkRoundTip.Checked)
                chkRoundTip.Checked = false;
            double percent20 = .20;
            double newTip = (double.Parse(tbxSubTotal.Text.Substring(1)) * percent20);
            tbxTip.Text = newTip.ToString("C");
            double subTotal = double.Parse(tbxSubTotal.Text.Substring(1));
            double tax = double.Parse(tbxTax.Text.Substring(1));
            tbxGrandTotal.Text = (subTotal + tax + newTip).ToString("C");
        }

        private void rbtn25_CheckedChanged(object sender, EventArgs e)
        {
            chkRoundTip.Enabled = true;
            if (chkRoundTip.Checked)
                chkRoundTip.Checked = false;
            double percent25 = .25;
            double newTip = (double.Parse(tbxSubTotal.Text.Substring(1)) * percent25);
            tbxTip.Text = newTip.ToString("C");
            double subTotal = double.Parse(tbxSubTotal.Text.Substring(1));
            double tax = double.Parse(tbxTax.Text.Substring(1));
            tbxGrandTotal.Text = (subTotal + tax + newTip).ToString("C");
        }

        private void rbtn0_CheckedChanged(object sender, EventArgs e)
        {
            chkRoundTip.Enabled = false;
                
            double newTip = 0;
            tbxTip.Text = newTip.ToString("C");
            double subTotal = double.Parse(tbxSubTotal.Text.Substring(1));
            double tax = double.Parse(tbxTax.Text.Substring(1));
            tbxGrandTotal.Text = (subTotal + tax).ToString("C");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu master = (frmMainMenu)Application.OpenForms["frmMainMenu"];
            master.clearMainItems();
            this.Close();
        }

        double tempTip; //keeps track of pre tip rounded values to toggle with check box.
        double tempGrandTotal;
        private void chkRoundTip_CheckedChanged(object sender, EventArgs e)
        {
            //Yongqin 
            //Round the total amount

            

            if (chkRoundTip.Checked)
            {
                if (rbtn0.Checked)
                {
                    MessageBox.Show("Cannot round with 0 tip");
                    
                }
                else {
                     
                     tempTip = double.Parse(tbxTip.Text.Substring(1));
                     tempGrandTotal = double.Parse(tbxGrandTotal.Text.Substring(1));
                    double newGrandTotal = Math.Round(tempGrandTotal, 0, MidpointRounding.AwayFromZero);
                    double difference = tempGrandTotal - newGrandTotal;

                    tbxTip.Text = (tempTip - difference).ToString("C");
                    tbxGrandTotal.Text = newGrandTotal.ToString("C");
                    //MessageBox.Show(newGrandTotal.ToString());


                }
            }
            else
            {
                    tbxTip.Text = tempTip.ToString("C");
                    tbxGrandTotal.Text = tempGrandTotal.ToString("C");         
            }
            
        }
    }
}
