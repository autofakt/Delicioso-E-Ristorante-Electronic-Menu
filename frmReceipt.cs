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
        // Lee //
        // FilePath for opening and saving file name //
        string filePath = "info.txt";
        public frmReceipt()
        {
            InitializeComponent();
        }

        // Lee //
        // Executes when user clicks SaveReceipt button //
        // Write receipt information to a file, save it with receipt number, and reset all forms //
        private void btnSaveReceipt_Click(object sender, EventArgs e)
        {
            // Declare a StreamWriter variable //
            StreamWriter receiptFile;

            saveFileDialog1.Filter = "txt Files (*.txt) |  *.txt";  // Default file type //

            // Executes if user selects Save option from Save As dialog box //                                   
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Creates selected file and saves with user specified FileName ******* still need to figure out how to save to receipt number ******************* //
                filePath = saveFileDialog1.FileName;
                receiptFile = File.AppendText(filePath);

                // Writes receipt information onto a txt file //
                receiptFile.WriteLine(lblReceiptNumInfo.Text);
                receiptFile.WriteLine(lblCustNameInfo.Text);
                receiptFile.WriteLine(lblDateInfo.Text);

                // For loop iterates through list box of ordered items //
                for (int i = 0; i < lstItemsOrdered.Items.Count; i++)
                {
                    // Writes each item ordered onto txt file //
                    receiptFile.WriteLine(lstItemsOrdered.Items[i]);
                }

                // Writes more receipt information onto a txt file //
                receiptFile.WriteLine(lblSubtotalInfo.Text);
                receiptFile.WriteLine(lblTaxInfo.Text);
                receiptFile.WriteLine(lblTipInfo.Text);
                receiptFile.WriteLine(lblGrandTotalInfo.Text);
                receiptFile.WriteLine(lblMethodPymtInfo.Text);

                // Closes file //
                receiptFile.Close();

                // Return focus back to Main Menu and clears all controls //
                frmMainMenu master = (frmMainMenu)Application.OpenForms["frmMainMenu"];
                master.clearMainMenu();
                // Closes Form
                this.Close();

            }
            // Executes else if user selected Cancel from Save As dialog box //
            else
            {
                MessageBox.Show("You clicked Cancel.");
                saveFileDialog1.Filter = "txt Files (*.txt) |  *.txt";  // Default file type //
            }
        }
    }
}
