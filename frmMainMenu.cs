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
    public partial class frmMainMenu : Form
    {
        // Lee //
        // Declare Variable Field for customer name // 
        public static string customerName = "";

        const int MAX_ITEMS = 22; // 22 Menu Items
        const int MAX_ORDER = 50; // Cannot have more than 50 items in one order.

        static int itemCounter = 0; //counter for the current order array
        static int itemCounterFinal = 0; //counter for the total order array
        //static double estimate = 0;

        public static int getItemCounter()
        {
                return itemCounter; 
        }

        public static int getItemCounterFinal()
        {
            return itemCounterFinal;
        }

        public static void setItemCounterFinal(int counter)
        {
           itemCounterFinal = counter;
        }

        /*
        public static double getEstimate()
        {
            return estimate;
        }
        */

        public static string[] items = new string[MAX_ITEMS];
        public static int[] quantity = new int[MAX_ITEMS];
        public static double[] price = new double[MAX_ITEMS];

        public static string[] itemsFinal = new string[MAX_ORDER];
        public static int[] quantityFinal = new int[MAX_ORDER];
        public static double[] priceFinal = new double[MAX_ORDER];

        /*
        public double estimateCalculator()
        {
            double sum = 0;
            MessageBox.Show("Itemcounter: "+itemCounterFinal.ToString());
            for(int i =0; i < itemCounterFinal; i++)
            {
                sum += priceFinal[i] * quantityFinal[i];
            }

            return sum;
        }
        */
        public frmMainMenu()
        {
            InitializeComponent();
        }

        // Salad Selection //
        private void picCapreseSalad_Click(object sender, EventArgs e)
        {
            nudCapreseSalad.Value++;
            nudCapreseSalad.Visible = true;
            lblCapreseSaladQuantity.Visible = true;
        }

        private void nudCapreseSalad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCapreseSalad.Value == 0)
            {
                lblCapreseSaladQuantity.Visible = false;
                nudCapreseSalad.Visible = false;
            }
        }

        private void picGreenSalad_Click(object sender, EventArgs e)
        {
            nudBigGreenSalad.Value++;
            nudBigGreenSalad.Visible = true;
            lblBigGreenSaladQuantity.Visible = true;
        }

        private void nudBigGreenSalad_ValueChanged(object sender, EventArgs e)
        {
            if (nudBigGreenSalad.Value == 0)
            {
                lblBigGreenSaladQuantity.Visible = false;
                nudBigGreenSalad.Visible = false;
            }
        }

        private void picAntiPastoSalad_Click(object sender, EventArgs e)
        {
            nudAntiPastoSalad.Value++;
            nudAntiPastoSalad.Visible = true;
            lblAntiPastoSaladQuantity.Visible = true;
        }

        private void nudAntiPastoSalad_ValueChanged(object sender, EventArgs e)
        {
            if (nudAntiPastoSalad.Value == 0)
            {
                lblAntiPastoSaladQuantity.Visible = false;
                nudAntiPastoSalad.Visible = false;
            }
        }

        // Main Menu Selection //
        private void picSpaghetti_Click(object sender, EventArgs e)
        {
            nudSpaghetti.Value++;
            nudSpaghetti.Visible = true;
            lblSpaghettiQuantity.Visible = true;

        }

        private void nudSpaghetti_ValueChanged(object sender, EventArgs e)
        {
            if (nudSpaghetti.Value == 0)
            {
                lblSpaghettiQuantity.Visible = false;
                nudSpaghetti.Visible = false;
            }
        }

        private void picLasagne_Click(object sender, EventArgs e) //Name was mispelled but changed to picLasagna
        {
            nudLasagna.Value++;
            nudLasagna.Visible = true;
            lblLasagnaQuantity.Visible = true;
        }

        private void nudLasagna_ValueChanged(object sender, EventArgs e)
        {
            if (nudLasagna.Value == 0)
            {
                lblLasagnaQuantity.Visible = false;
                nudLasagna.Visible = false;
            }
        }

        private void picRatatouille_Click(object sender, EventArgs e)
        {
            nudRatatouille.Value++;
            nudRatatouille.Visible = true;
            lblRatatouilleQuantity.Visible = true;

        }

        private void nudRatatouille_ValueChanged(object sender, EventArgs e)
        {
            if (nudRatatouille.Value == 0)
            {
                lblRatatouilleQuantity.Visible = false;
                nudRatatouille.Visible = false;
            }
        }

        private void picFettAlfredo_Click(object sender, EventArgs e)
        {
            nudFettAlfredo.Value++;
            nudFettAlfredo.Visible = true;
            lblFettAlfredoQuantity.Visible = true;
        }

        private void nudFettAlfredo_ValueChanged(object sender, EventArgs e)
        {
            if (nudFettAlfredo.Value == 0)
            {
                lblFettAlfredoQuantity.Visible = false;
                nudFettAlfredo.Visible = false;
            }
        }

        private void picStuffedShells_Click(object sender, EventArgs e)
        {
            nudStuffedShells.Value++;
            nudStuffedShells.Visible = true;
            lblStuffedShellsQuantity.Visible = true;
        }

        private void nudStuffedShells_ValueChanged(object sender, EventArgs e)
        {
            if (nudStuffedShells.Value == 0)
            {
                lblStuffedShellsQuantity.Visible = false;
                nudStuffedShells.Visible = false;
            }
        }

        private void picPizza_Click(object sender, EventArgs e)
        {
            nudPizza.Value++;
            nudPizza.Visible = true;
            lblPizzaQuantity.Visible = true;
        }

        private void nudPizza_ValueChanged(object sender, EventArgs e)
        {
            if (nudPizza.Value == 0)
            {
                lblPizzaQuantity.Visible = false;
                nudPizza.Visible = false;
            }
        }

        private void picPesto_Click(object sender, EventArgs e)
        {
            nudPesto.Value++;
            nudPesto.Visible = true;
            lblPestoQuantity.Visible = true;
        }

        private void nudPesto_ValueChanged(object sender, EventArgs e)
        {
            if (nudPesto.Value == 0)
            {
                lblPestoQuantity.Visible = false;
                nudPesto.Visible = false;
            }
        }

        private void picMacaroni_Click(object sender, EventArgs e)
        {
            nudMacaroni.Value++;
            nudMacaroni.Visible = true;
            lblMacaroniQuantity.Visible = true;
        }

        private void nudMacaroni_ValueChanged(object sender, EventArgs e)
        {
            if (nudMacaroni.Value == 0)
            {
                lblMacaroniQuantity.Visible = false;
                nudMacaroni.Visible = false;
            }
        }

        private void picSeafoodPasta_Click(object sender, EventArgs e)
        {
            nudSeafoodPasta.Value++;
            nudSeafoodPasta.Visible = true;
            lblSeafoodPastaQuantity.Visible = true;
        }

        private void nudSeafoodPasta_ValueChanged(object sender, EventArgs e)
        {
            if (nudSeafoodPasta.Value == 0)
            {
                lblSeafoodPastaQuantity.Visible = false;
                nudSeafoodPasta.Visible = false;
            }
        }

        private void picRavioli_Click(object sender, EventArgs e)
        {
            nudRavioli.Value++;
            nudRavioli.Visible = true;
            lblRavioliQuantity.Visible = true;

        }

        private void nudRavioli_ValueChanged(object sender, EventArgs e)
        {
            if (nudRavioli.Value == 0)
            {
                lblRavioliQuantity.Visible = false;
                nudRavioli.Visible = false;
            }
        }

        // Dessert Selection //
        private void picTiramisu_Click(object sender, EventArgs e)
        {
            nudTiramisu.Value++;
            nudTiramisu.Visible = true;
            lblTiramisuQuantity.Visible = true;
        }

        private void nudTiramisu_ValueChanged(object sender, EventArgs e)
        {
            if (nudTiramisu.Value == 0)
            {
                lblTiramisuQuantity.Visible = false;
                nudTiramisu.Visible = false;
            }
        }

        private void picGelato_Click(object sender, EventArgs e)
        {
            nudGelato.Value++;
            nudGelato.Visible = true;
            lblGelatoQuantity.Visible = true;
        }

        private void nudGelato_ValueChanged(object sender, EventArgs e)
        {
            if (nudGelato.Value == 0)
            {
                lblGelatoQuantity.Visible = false;
                nudGelato.Visible = false;
            }
        }

        private void picCannoli_Click(object sender, EventArgs e)
        {
            nudCannoli.Value++;
            nudCannoli.Visible = true;
            lblCannoliQuantity.Visible = true;
        }

        private void nudCannoli_ValueChanged(object sender, EventArgs e)
        {
            if (nudCannoli.Value == 0)
            {
                lblCannoliQuantity.Visible = false;
                nudCannoli.Visible = false;
            }

        }

        // Lee //
        // Beverages Selection //
        private void picRedWine_Click(object sender, EventArgs e)
        {
            nudRedWine.Value++;
            nudRedWine.Visible = true;
            lblQuantityRedWine.Visible = true;
        }

        private void nudRedWine_ValueChanged(object sender, EventArgs e)
        {
            if (nudRedWine.Value == 0)
            {
                lblQuantityRedWine.Visible = false;
                nudRedWine.Visible = false;
            }
        }

        private void picWhiteWine_Click(object sender, EventArgs e)
        {
            nudWhiteWine.Value++;
            nudWhiteWine.Visible = true;
            lblQuantityWhiteWine.Visible = true;
        }

        private void nudWhiteWine_ValueChanged(object sender, EventArgs e)
        {
            if (nudWhiteWine.Value == 0)
            {
                lblQuantityWhiteWine.Visible = false;
                nudWhiteWine.Visible = false;
            }
        }

        private void picItalianSoda_Click(object sender, EventArgs e)
        {
            nudItalianSoda.Value++;
            nudItalianSoda.Visible = true;
            lblQuantityItalianSoda.Visible = true;
        }

        private void nudItalianSoda_ValueChanged(object sender, EventArgs e)
        {
            if (nudItalianSoda.Value == 0)
            {
                lblQuantityItalianSoda.Visible = false;
                nudItalianSoda.Visible = false;
            }
        }

        private void picSanPellegrino_Click(object sender, EventArgs e) // Mispelled Perregrino //
        {
            nudSanPellegrino.Value++;
            nudSanPellegrino.Visible = true;
            lblQuantitySanPellegrino.Visible = true;
        }
        private void nudSanPerregrino_ValueChanged(object sender, EventArgs e)
        {
            if (nudSanPellegrino.Value == 0)
            {
                lblQuantitySanPellegrino.Visible = false;
                nudSanPellegrino.Visible = false;
            }
        }

        private void picPerregrinoWater_Click(object sender, EventArgs e)
        {
            nudPellegrinoWater.Value++;
            nudPellegrinoWater.Visible = true;
            lblQuantityPellegrinoWater.Visible = true;
        }

        private void nudPeregrinoWater_ValueChanged(object sender, EventArgs e)
        {
            if (nudPellegrinoWater.Value == 0)
            {
                lblQuantityPellegrinoWater.Visible = false;
                nudPellegrinoWater.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) // Coca Cola pic wasn't named //
        {
            nudCocaCola.Value++;
            nudCocaCola.Visible = true;
            lblQuantityCocaCola.Visible = true;
        }

        private void nudCocaCola_ValueChanged(object sender, EventArgs e)
        {
            if (nudCocaCola.Value == 0)
            {
                lblQuantityCocaCola.Visible = false;
                nudCocaCola.Visible = false;
            }
        }


        // Executes when View Order button is clicked //
        public void btnViewOrder_Click(object sender, EventArgs e)
        {
            // Checks is text box for CustName is empty or null //
            if (String.IsNullOrEmpty(txtCustomerName.Text))
            {
                // Displays an error message //
                MessageBox.Show("Please enter a name before viewing your order.");
            }
            // Else opens new form frmViewOrder and displays selected items //
            else
            {
                itemCounter = 0;
                //Array.Clear(items, 0, items.Length);
                //Array.Clear(quantity, 0, items.Length);
                //Array.Clear(price, 0, items.Length);

                // Create orderForm object //
                frmViewOrder orderForm = new frmViewOrder();

                customerName = txtCustomerName.Text;
                orderForm.txtCustomerName.Text = customerName;

                if (nudSpaghetti.Value >= 1)
                {
                    items[itemCounter] = (lblSpaghetti.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudSpaghetti.Value));
                    price[itemCounter] = (double.Parse(lblPriceSpaghetti.Text));
                    itemCounter++;
                }

                if (nudLasagna.Value >= 1)
                {
                    items[itemCounter] = (lblLasagna.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudLasagna.Value));
                    price[itemCounter] = (double.Parse(lblPriceLasagna.Text));
                    itemCounter++;
                }

                if (nudRatatouille.Value >= 1)
                {
                    items[itemCounter] = (lblRatatouille.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudRatatouille.Value));
                    price[itemCounter] = (double.Parse(lblPriceRatatouille.Text));
                    itemCounter++;
                }

                if (nudFettAlfredo.Value >= 1)
                {
                    items[itemCounter] = (lblFettAlfredo.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudFettAlfredo.Value));
                    price[itemCounter] = (double.Parse(lblPriceFettAlfredo.Text));
                    itemCounter++;
                }

                if (nudStuffedShells.Value >= 1)
                {
                    items[itemCounter] = (lblStuffedShells.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudStuffedShells.Value));
                    price[itemCounter] = (double.Parse(lblPriceStuffedShells.Text));
                    itemCounter++;
                }

                if (nudPizza.Value >= 1)
                {
                    items[itemCounter] = (lblPizza.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudPizza.Value));
                    price[itemCounter] = (double.Parse(lblPricePizza.Text));
                    itemCounter++;
                }

                if (nudPesto.Value >= 1)
                {
                    items[itemCounter] = (lblPesto.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudPesto.Value));
                    price[itemCounter] = (double.Parse(lblPricePesto.Text));
                    itemCounter++;
                }

                if (nudSeafoodPasta.Value >= 1)
                {
                    items[itemCounter] = (lblSeafoodPasta.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudSeafoodPasta.Value));
                    price[itemCounter] = (double.Parse(lblPriceSeafoodPasta.Text));
                    itemCounter++;
                }

                if (nudRavioli.Value >= 1)
                {
                    items[itemCounter] = (lblRavioli.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudRavioli.Value));
                    price[itemCounter] = (double.Parse(lblPriceRavioli.Text));
                    itemCounter++;
                }

                if (nudMacaroni.Value >= 1)
                {
                    items[itemCounter] = (lblMacaroni.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudMacaroni.Value));
                    price[itemCounter] = (double.Parse(lblPriceMacaroni.Text));
                    itemCounter++;
                }

                //SALADS
                if (nudCapreseSalad.Value >= 1)
                {
                    items[itemCounter] = (lblCapreseSalad.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudCapreseSalad.Value));
                    price[itemCounter] = (double.Parse(lblPriceCapreseSalad.Text));
                    itemCounter++;
                }

                if (nudBigGreenSalad.Value >= 1)
                {
                    items[itemCounter] = (lblGreenSalad.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudBigGreenSalad.Value));
                    price[itemCounter] = (double.Parse(lblPriceBigGreenSalad.Text));
                    itemCounter++;
                }

                if (nudAntiPastoSalad.Value >= 1)
                {
                    items[itemCounter] = (lblAntiPastoSalad.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudAntiPastoSalad.Value));
                    price[itemCounter] = (double.Parse(lblPriceAntiPastoSalad.Text));
                    itemCounter++;
                }

                // Lee //
                // Desserts //
                if (nudTiramisu.Value >= 1)
                {
                    items[itemCounter] = (lblTiramisu.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudTiramisu.Value));
                    price[itemCounter] = (double.Parse(lblPriceTiramisu.Text));
                    itemCounter++;
                }

                if (nudGelato.Value >= 1)
                {
                    items[itemCounter] = (lblGelato.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudGelato.Value));
                    price[itemCounter] = (double.Parse(lblPriceGelato.Text));
                    itemCounter++;
                }

                if (nudCannoli.Value >= 1)
                {
                    items[itemCounter] = (lblCannoli.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudCannoli.Value));
                    price[itemCounter] = (double.Parse(lblPriceCannoli.Text));
                    itemCounter++;
                }

                // Lee //
                // Beverages //
                if (nudRedWine.Value >= 1)
                {
                    items[itemCounter] = (lblRedWine.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudRedWine.Value));
                    price[itemCounter] = (double.Parse(lblPriceRedWine.Text));
                    itemCounter++;
                }

                if (nudWhiteWine.Value >= 1)
                {
                    items[itemCounter] = (lblWhiteWine.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudWhiteWine.Value));
                    price[itemCounter] = (double.Parse(lblPriceWhiteWine.Text));
                    itemCounter++;
                }

                if (nudItalianSoda.Value >= 1)
                {
                    items[itemCounter] = (lblItalianSoda.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudItalianSoda.Value));
                    price[itemCounter] = (double.Parse(lblPriceItalianSoda.Text));
                    itemCounter++;
                }

                if (nudSanPellegrino.Value >= 1)
                {
                    items[itemCounter] = (lblSanPellegrino.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudSanPellegrino.Value));
                    price[itemCounter] = (double.Parse(lblPriceSanPellegrino.Text));
                    itemCounter++;
                }

                if (nudPellegrinoWater.Value >= 1)
                {
                    items[itemCounter] = (lblPellegrinoWater.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudPellegrinoWater.Value));
                    price[itemCounter] = (double.Parse(lblPricePellegrinoWater.Text));
                    itemCounter++;
                }

                if (nudCocaCola.Value >= 1)
                {
                    items[itemCounter] = (lblCocaCola.Text);
                    quantity[itemCounter] = (Convert.ToInt32(nudCocaCola.Value));
                    price[itemCounter] = (double.Parse(lblPriceCocaCola.Text));
                    itemCounter++;
                }

                // For Loop displays items slected and adds them to a list //
                for (int i = 0; i < itemCounter; i++)
                    orderForm.lstItemsOrdered.Items.Add(quantity[i] + " " + items[i]);

                for (int i = 0; i < itemCounterFinal; i++)
                    orderForm.lstTotalItemsOrdered.Items.Add(quantityFinal[i] + " " + itemsFinal[i]);

                // estimate variable is assigned the return value of calling estimateCalculator //
                estimate = estimateCalculator();

                // Displays estimate total in lblEstimatedTotal //   instructor
                //orderForm.lblEstimatedTotal.Text = estimate.ToString("C");
                orderForm.ShowDialog();
            }


            if (nudGelato.Value >= 1)
            {
                items[itemCounter] = (lblGelato.Text);
                quantity[itemCounter] = (Convert.ToInt32(nudGelato.Value));
                price[itemCounter] = (double.Parse(lblPriceGelato.Text));
                itemCounter++;
            }

            if (nudCannoli.Value >= 1)
            {
                items[itemCounter] = (lblCannoli.Text);
                quantity[itemCounter] = (Convert.ToInt32(nudCannoli.Value));
                price[itemCounter] = (double.Parse(lblPriceCannoli.Text));
                itemCounter++;
            }

            // Lee //
            // Beverages //
            if (nudRedWine.Value >= 1)
            {
                items[itemCounter] = (lblRedWine.Text);
                quantity[itemCounter] = (Convert.ToInt32(nudRedWine.Value));
                price[itemCounter] = (double.Parse(lblPriceRedWine.Text));
                itemCounter++;
            }

            if (nudWhiteWine.Value >= 1)
            {
                items[itemCounter] = (lblWhiteWine.Text);
                quantity[itemCounter] = (Convert.ToInt32(nudWhiteWine.Value));
                price[itemCounter] = (double.Parse(lblPriceWhiteWine.Text));
                itemCounter++;
            }

            if (nudItalianSoda.Value >= 1)
            {
                items[itemCounter] = (lblItalianSoda.Text);
                quantity[itemCounter] = (Convert.ToInt32(nudItalianSoda.Value));
                price[itemCounter] = (double.Parse(lblPriceItalianSoda.Text));
                itemCounter++;
            }

            if (nudSanPellegrino.Value >= 1)
            {
                items[itemCounter] = (lblSanPellegrino.Text);
                quantity[itemCounter] = (Convert.ToInt32(nudSanPellegrino.Value));
                price[itemCounter] = (double.Parse(lblPriceSanPellegrino.Text));
                itemCounter++;
            }

            if (nudPellegrinoWater.Value >= 1)
            {
                items[itemCounter] = (lblPellegrinoWater.Text);
                quantity[itemCounter] = (Convert.ToInt32(nudPellegrinoWater.Value));
                price[itemCounter] = (double.Parse(lblPricePellegrinoWater.Text));
                itemCounter++;
            }

            if (nudCocaCola.Value >= 1)
            {
                items[itemCounter] = (lblCocaCola.Text);
                quantity[itemCounter] = (Convert.ToInt32(nudCocaCola.Value));
                price[itemCounter] = (double.Parse(lblPriceCocaCola.Text));
                itemCounter++;
            }

            // For Loop displays items slected and adds them to a list //
            for (int i = 0; i < itemCounter; i++)
                orderForm.lstItemsOrdered.Items.Add(quantity[i] + " " + items[i]);

            for (int i = 0; i < itemCounterFinal; i++)
                orderForm.lstTotalItemsOrdered.Items.Add(quantityFinal[i] + " " + itemsFinal[i]);

            // estimate variable is assigned the return value of calling estimateCalculator //
            //estimate = estimateCalculator();

            // Displays estimate total in lblEstimatedTotal //   instructor
            //orderForm.lblEstimatedTotal.Text = estimate.ToString("C");
            orderForm.ShowDialog();

          
        }

        // Lee //
        //Executes when Start Over button is clicked //
        // Resets Numeric up and down back to zero//
        public void btnStartOver_Click(object sender, EventArgs e)
        {
            // Main Courses //
            nudSpaghetti.Value = 0;
            nudLasagna.Value = 0;
            nudRatatouille.Value = 0;
            nudFettAlfredo.Value = 0;
            nudStuffedShells.Value = 0;
            nudPizza.Value = 0;
            nudPesto.Value = 0;
            nudSeafoodPasta.Value = 0;
            nudRavioli.Value = 0;
            nudMacaroni.Value = 0;
            // Salads//
            nudCapreseSalad.Value = 0;
            nudBigGreenSalad.Value = 0;
            nudAntiPastoSalad.Value = 0;
            // Desserts //
            nudTiramisu.Value = 0;
            nudGelato.Value = 0;
            nudCannoli.Value = 0;
            // Beverages //
            nudRedWine.Value = 0;
            nudWhiteWine.Value = 0;
            nudItalianSoda.Value = 0;
            nudSanPellegrino.Value = 0;
            nudPellegrinoWater.Value = 0;
            nudCocaCola.Value = 0;
        }







        private void MainMenu_Click(object sender, EventArgs e) 
        {
            // Accidental MainMenu Click created //
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
