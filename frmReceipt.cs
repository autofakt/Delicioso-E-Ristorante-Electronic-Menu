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
    public partial class frmReceipt : Form
    {
        public frmReceipt()
        {
            InitializeComponent();
        }

        // Method writes receipt information to a file, save it with receipt number, and reset all forms //
        public void saveReceipt()
        {
            // Create file //
            StreamWriter receiptFile;
            int tempReceiptNumber = frmMainMenu.receiptCounter-1; //increments earlier so need to offset by 1.
            receiptFile = File.CreateText(tempReceiptNumber.ToString() + ".txt");

            // Writes receipt information onto a txt file //
            receiptFile.WriteLine("Receipt Number: " + lblReceiptNumInfo.Text);
            receiptFile.WriteLine("Customer Name: " + lblCustNameInfo.Text);
            receiptFile.WriteLine("Date: " + lblDateInfo.Text);

            // For loop iterates through list box of ordered items //
            for (int i = 0; i < lstItemsOrdered.Items.Count; i++)
            {
                // Writes each item ordered onto txt file //
                receiptFile.WriteLine(lstItemsOrdered.Items[i]);
            }

            // Writes more receipt information onto a txt file //
            receiptFile.WriteLine("SubTotal: " + lblSubTotal.Text);
            receiptFile.WriteLine("Tax: " + lblTaxInfo.Text);
            receiptFile.WriteLine("Tip: " + lblTipInfo.Text);
            receiptFile.WriteLine("Total: " + lblGrandTotalInfo.Text);
            receiptFile.WriteLine("Payment Method: " + lblMethodPymtInfo.Text);

            // Closes file //
            receiptFile.Close();
        }

        // Lee //
        // Executes when user clicks SaveReceipt button //
        private void btnSaveReceipt_Click(object sender, EventArgs e)
        {
            // Call method to save receipt //
            saveReceipt();

            // Return focus back to Main Menu and clears all controls //
            frmMainMenu master = (frmMainMenu)Application.OpenForms["frmMainMenu"];
                // Calls method to clear main menu //
                master.clearMainMenu();
                // Calls method to reset Final array //
                frmMainMenu.resetFinalArray();

                // Closes Form
                this.Close();

            
        }
    }
}
