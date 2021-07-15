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
            frmMainMenu master = (frmMainMenu)Application.OpenForms["frmMainMenu"];
            master.btnStartOver.PerformClick();
            this.Close();
        }

        private void btnRequestCheck_Click(object sender, EventArgs e)
        {
            frmBillAndPayment paymentForm = new frmBillAndPayment();

            for (int i = 0; i < frmMainMenu.getItemCounterFinal(); i++)
                paymentForm.lstItemizedBill.Items.Add(frmMainMenu.quantityFinal[i] + " " + frmMainMenu.itemsFinal[i] +"\t" + (frmMainMenu.quantityFinal[i] * frmMainMenu.priceFinal[i]));

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
