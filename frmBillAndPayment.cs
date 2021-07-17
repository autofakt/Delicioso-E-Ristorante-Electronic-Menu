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
        // Variable fields and Constants //
        public static string paymentType = "";
        public static string cardNumber = "";
        public static string expDate = "";
        public static string pinNumber = "";
        public const int CARD_MIN_LENGTH = 16; // we dont accept amex or 15 card credit cards
        public const int EXDATE_MIN_LENGTH = 4;
        public const int PIN_MIN_LENGTH = 4;
        public const double TAXRATE = 0.095;

        public frmBillAndPayment()
        {
            InitializeComponent();
        }
        // Credit Card Radio button selected //
        private void rbtnCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            paymentType = "Credit Card";
            lblPymtMthdPrompt.Visible = true;
            lblPymtMthdPrompt.Text = "Please enter your Credit Card information.";
            txtCardNumber.ReadOnly = false;
            txtExpDate.ReadOnly = false;
            txtPinNumber.ReadOnly = true;
            //Yongqin Lin
            lblDateFormat.Visible = true;
            lblCardNumberFormat.Visible = true;
        }
        // Cash Radio button selected //
        private void rbtnCash_CheckedChanged(object sender, EventArgs e)
        {
            paymentType = "Cash";
            lblPymtMthdPrompt.Visible = true;
            lblPymtMthdPrompt.Text = "Please wait for the waiter to return to pay in cash.";
            txtCardNumber.ReadOnly = true;
            txtExpDate.ReadOnly = true;
            txtPinNumber.ReadOnly = true;
        }
        // Debit Card Radio button selected //
        private void rbtnDebitCard_CheckedChanged(object sender, EventArgs e)
        {
            paymentType = "Debit Card";
            lblPymtMthdPrompt.Visible = true;
            lblPymtMthdPrompt.Text = "Please enter your Debit Card information.";
            txtCardNumber.ReadOnly = false;
            txtExpDate.ReadOnly = false;
            txtPinNumber.ReadOnly = false;
        }
        // Writes receipt number to a file for use on receipt form //
        private void writeReceiptCounter()
        {
            StreamWriter outputFile;
            outputFile = File.CreateText("receiptCounter.txt");
            outputFile.WriteLine(frmMainMenu.receiptCounter.ToString());
            outputFile.Close();
        }

        // Method validates Credit Card info and returns a bool //
        public bool validateCreditCard(string cardNum, string expDate)
        {
            // Temorary variables used to check user input //
            long temp;
            int temp2;
            
            // Checks length of user input //
            if (cardNum.Length == CARD_MIN_LENGTH && expDate.Length == EXDATE_MIN_LENGTH)
            {
                // Checks if user input can be converted to numbers //
                bool cardGood = long.TryParse(cardNum, out temp);
                bool expDataGood = int.TryParse(expDate, out temp2);
                return cardGood && expDataGood;
            }
            // Else returns false //
            return false;
        }

        // Method validates Debit Card info and returns a bool //
        private bool validateDebitCard(string cardNum, string expDate, string pinNum)
        {
            // Temorary variables used to check user input //
            long temp;
            int temp2;
            int temp3;
            // Checks if user input can be converted to numbers //
            if (cardNum.Length >= CARD_MIN_LENGTH && expDate.Length == EXDATE_MIN_LENGTH && pinNum.Length == PIN_MIN_LENGTH)
            {
                // Checks if user input can be converted to numbers //
                bool cardGood = long.TryParse(cardNum, out temp);
                bool expDataGood = int.TryParse(expDate, out temp2);
                bool pinGood = int.TryParse(pinNum, out temp3);
                return cardGood && expDataGood && pinGood;
            }
            // Else returns false //
            return false;

        }
        // Lee //
        // Method validates Payment Method and returns a bool //
        public bool isPymtMethodValid(string pymtType, string cardNum, string expDate, string pinNum)
        {
            // Checks which payment method was selected //
            switch (pymtType)
            { 
                case "Credit Card":
                    // Calls method to validate Credit Card //
                    return validateCreditCard(cardNum, expDate);
                case "Debit Card":
                    // Calls method to validate Debit Card //
                    return validateDebitCard(cardNum, expDate, pinNum);
                case "Cash":
                    // Returns true if Cash is selected, nothing to validate //
                    return true;
                default:
                    // If nothing was selected, return false //
                    return false;
            }
        }

        // Executes if Pay Bill button is clicked //
        private void btnPayBill_Click(object sender, EventArgs e)
        {
            // Lee //
            // Get user input from text boxes and assign to variables //
            cardNumber = txtCardNumber.Text;
            expDate = txtExpDate.Text;
            pinNumber = txtPinNumber.Text;

            // Assign return value of isPaymentMethodValid to variable validPaymentMethod bool //
            bool validPaymentMethod = isPymtMethodValid(paymentType, cardNumber, expDate, pinNumber);

            // Executes code IF user entered validPaymentMethod //
            if (validPaymentMethod)
            {
                //Yongqin Lin
                //Add a hyphen(-) after every 4 numbers after customer entered all 16 digits
                cardNumber = txtCardNumber.Text;
                var list = Enumerable
                .Range(0, cardNumber.Length / 4)
                .Select(i => cardNumber.Substring(i * 4, 4))
                .ToList();
                var resl = string.Join("-", list);
                txtCardNumber.Text = resl;

                // Create receiptForm object //
                frmReceipt receiptForm = new frmReceipt();
                DateTime now = DateTime.Now;
                string format = "MMM ddd d HH:mm yyyy";
                receiptForm.lblDateInfo.Text = now.ToString(format);

                receiptForm.lblReceiptNumInfo.Text = frmMainMenu.receiptCounter++.ToString(); // gets receipt number and increments
                writeReceiptCounter(); // writes new receipt counter value to file.

                // Adds items from complete order to the list box in receipt form //
                for (int i = 0; i < frmMainMenu.getItemCounterFinal(); i++)
                    receiptForm.lstItemsOrdered.Items.Add(frmMainMenu.quantityFinal[i] + " " + frmMainMenu.itemsFinal[i] + "\t" + (frmMainMenu.quantityFinal[i] * frmMainMenu.priceFinal[i]));

                // Calculate and display subtotal //
                double subTotal = frmViewOrder.getEstimate();
                receiptForm.lblSubTotal.Text = subTotal.ToString("C");

                // Calculate and display tax //
                double tax = subTotal * TAXRATE;
                receiptForm.lblTaxInfo.Text = tax.ToString("C");

                // Calculate and display tip //
                double tip = double.Parse(tbxTip.Text.Substring(1));
                receiptForm.lblTipInfo.Text = tip.ToString("C");

                // Calculate and display grandtotal //
                double grandTotal = subTotal + tax + tip;
                receiptForm.lblGrandTotalInfo.Text = grandTotal.ToString("C");

                // Display payment method and customer name //
                receiptForm.lblMethodPymtInfo.Text = paymentType;
                receiptForm.lblCustNameInfo.Text = frmMainMenu.customerName;

                // Open Receipt form //
                receiptForm.ShowDialog();

                // Closes billAndPayment form //
                this.Close();
            }
            // Else it displays an error message if payment method is invalid //
            else
            {
                MessageBox.Show("We could not process your payment.\nPlease review your information and try again.");
            }
        }
        // Tip percentage 10% Radio button selected //
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
        // Tip percentage 15% Radio button selected //
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
        // Tip percentage 20% Radio button selected //
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
        // Tip percentage 25% Radio button selected //
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
        // No Tip Radio button selected //
        private void rbtn0_CheckedChanged(object sender, EventArgs e)
        {
            chkRoundTip.Enabled = false;
            double newTip = 0;
            tbxTip.Text = newTip.ToString("C");
            double subTotal = double.Parse(tbxSubTotal.Text.Substring(1));
            double tax = double.Parse(tbxTax.Text.Substring(1));
            tbxGrandTotal.Text = (subTotal + tax).ToString("C");
        }
        // Executes if Back to Main Menu button is clicked //
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Returns user to Main Menu form //
            frmMainMenu master = (frmMainMenu)Application.OpenForms["frmMainMenu"];
            // Calls method to clear main menu //
            master.clearMainItems();
            // Closes BillAndPayment form //
            this.Close();
        }
        // Temporary variables //
        double tempTip; //keeps track of pre tip rounded values to toggle with check box.
        double tempGrandTotal;

        // Executes if Round Tip checkbox is selected //
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
                else 
                {
                    tempTip = double.Parse(tbxTip.Text.Substring(1));
                    tempGrandTotal = double.Parse(tbxGrandTotal.Text.Substring(1));
                    double newGrandTotal = Math.Round(tempGrandTotal, 0, MidpointRounding.AwayFromZero);
                    double difference = tempGrandTotal - newGrandTotal;
                    tbxTip.Text = (tempTip - difference).ToString("C");
                    tbxGrandTotal.Text = newGrandTotal.ToString("C");
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
