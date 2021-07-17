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
        // Variable Fields and Constants //
        public static bool itemOrdered = false;
        static double estimate = 0;
        public const double TAXRATE = 0.095;

        public frmViewOrder()
        {
            InitializeComponent();
        }

        // Lee //
        // Added event handler to OrderMore button which closes form //
        private void btnOrderMore_Click(object sender, EventArgs e)
        {
            frmMainMenu master = (frmMainMenu)Application.OpenForms["frmMainMenu"];
            master.clearMainItems();
            this.Close();
        }
        // Method returns estimate //
        public static double getEstimate()
        {
            return estimate;
        }
        // Method calculates sum of items ordered and returns a double //
        public double estimateCalculator()
        {
            int itemCounterFinal = frmMainMenu.getItemCounterFinal();
            double sum = 0;

            for (int i = 0; i < itemCounterFinal; i++)
            {
                sum += frmMainMenu.priceFinal[i] * frmMainMenu.quantityFinal[i];
            }
            return sum;
        }
        // Lee //
        // Method validates that 1 minimum order has been submitted //
        public bool oneOrderMinimum()
        {
            int itemCounterFinal = frmMainMenu.getItemCounterFinal();
            // Return true if greater than or equal to 1 //
            if (itemCounterFinal >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Executes when request check button is clicked //
        private void btnRequestCheck_Click(object sender, EventArgs e)
        {
            // Lee //
            // Assign return value from oneOrderMinimum to itemOrdered //
            itemOrdered = oneOrderMinimum();
            // Executes code if itemOrdered was set to true //
            if (itemOrdered)
            {
                frmBillAndPayment paymentForm = new frmBillAndPayment();

                // For Loop add each item to list in Itemized Bill Form //
                for (int i = 0; i < frmMainMenu.getItemCounterFinal(); i++)
                    paymentForm.lstItemizedBill.Items.Add(frmMainMenu.quantityFinal[i] + " " + frmMainMenu.itemsFinal[i] + "\t" + (frmMainMenu.quantityFinal[i] * frmMainMenu.priceFinal[i]));

                // Calls method and assigns results to estimate variable //
                estimate = estimateCalculator();

                // Calculate and display subtotal //
                double subTotal = estimate;
                paymentForm.tbxSubTotal.Text = subTotal.ToString("C");

                // Calculate and display tax //
                double tax = subTotal * TAXRATE;
                paymentForm.tbxTax.Text = tax.ToString("C");

                // Calculate and display tip //
                double tip = 0;
                paymentForm.tbxTip.Text = tip.ToString("C");
                paymentForm.rbtn0.Checked = true;

                // Calculate and display grandtotal //
                double grandTotal = subTotal + tax;
                paymentForm.tbxGrandTotal.Text = grandTotal.ToString("C");

                // Display BillAndPayment Form //
                paymentForm.ShowDialog();

                // Closes View Order Form //
                this.Close();
            }
            else // Else it displays an error message //
            {
                MessageBox.Show("Please submit your order before requesting your check.");
            }
        }
        // Executes if Submit Order Button is clicked //
        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            // Confirmation Message that order was submitted successfully //
            MessageBox.Show("Thank you.\nYour order will be out soon.\nYou may continue ordering until you request the check.");

            int itemsCounter = frmMainMenu.getItemCounter();  // number of current items
                int itemsCounterFinal = frmMainMenu.getItemCounterFinal();  // number of final items

                if (itemsCounterFinal == 0)
                {
                    for (int i = 0; i < itemsCounter; i++)
                    {

                        frmMainMenu.itemsFinal[i] = frmMainMenu.items[i];
                        frmMainMenu.quantityFinal[i] = frmMainMenu.quantity[i];
                        frmMainMenu.priceFinal[i] = frmMainMenu.price[i];
                        itemsCounterFinal++;
                    }

                    for (int i = 0; i < itemsCounterFinal; i++)
                        lstTotalItemsOrdered.Items.Add(frmMainMenu.quantityFinal[i] + " " + frmMainMenu.itemsFinal[i]);
                }
                else
                {
                    for (int i = 0; i < itemsCounter; i++)
                    {
                        int foundIndex = Array.IndexOf(frmMainMenu.itemsFinal, frmMainMenu.items[i]);

                        if (foundIndex >= 0)
                        {
                            frmMainMenu.quantityFinal[foundIndex] = frmMainMenu.quantity[i] + frmMainMenu.quantityFinal[foundIndex];
                        }
                        else
                        {
                            frmMainMenu.itemsFinal[itemsCounterFinal] = frmMainMenu.items[i];
                            frmMainMenu.quantityFinal[itemsCounterFinal] = frmMainMenu.quantity[i];
                            frmMainMenu.priceFinal[itemsCounterFinal] = frmMainMenu.price[i];
                            itemsCounterFinal++;
                        }

                    }
                }

                Array.Clear(frmMainMenu.items, 0, frmMainMenu.items.Length); //clears current array
                Array.Clear(frmMainMenu.quantity, 0, frmMainMenu.items.Length);
                Array.Clear(frmMainMenu.price, 0, frmMainMenu.items.Length);

                frmMainMenu.setItemCounterFinal(itemsCounterFinal); //sets the new value of final array in main menu
                lstItemsOrdered.Items.Clear();

                lstTotalItemsOrdered.Items.Clear();
                for (int i = 0; i < itemsCounterFinal; i++)
                    lstTotalItemsOrdered.Items.Add(frmMainMenu.quantityFinal[i] + " " + frmMainMenu.itemsFinal[i]);

         
        }
    }
}
