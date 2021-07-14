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
        const int MAX_ITEMS = 22; // 22 Menu Items
        //static int itemCounter = 0;
        //Yongqin Lin
        //two counter to track the  
        static int newItemCounter = 0;
        static int totalItemCounter = 0;
        static double estimate = 0;

        public static int getItemCounter()
        {
                return newItemCounter; 
        }

        public static double getEstimate()
        {
            return estimate;
        }

        //Yongqin Lin 
       // create two arrays to store current order and total order

        //arrays to store current items info(items added in new order which will be sent to the kitchen)
        public static string[] currentItems = new string[MAX_ITEMS];
        public static int[] currentQuantity = new int[MAX_ITEMS];
        //arrays to store the total items info
        public static string[] totalItems = new string[MAX_ITEMS];
        public static int[] totalQuantity = new int[MAX_ITEMS];
        public static double[] price = new double[MAX_ITEMS];

        public double estimateCalculator()
        {
            double sum = 0;
            for (int i = 0; i < totalItemCounter; i++)
            {
                sum += price[i] * totalQuantity[i];
            }

            return sum;
        }

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
            newItemCounter = 0;
            Array.Clear(currentItems, 0, currentItems.Length);
            Array.Clear(currentQuantity, 0, currentQuantity.Length);
            Array.Clear(price, 0, currentItems.Length);

            // Create orderForm object //
            frmViewOrder orderForm = new frmViewOrder();

            if (nudSpaghetti.Value >= 1)
            {
                currentItems[newItemCounter] = (lblSpaghetti.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudSpaghetti.Value));
                price[newItemCounter] = (double.Parse(lblPriceSpaghetti.Text));
                newItemCounter++;
            }

            if (nudLasagna.Value >= 1)
            {
                currentItems[newItemCounter] = (lblLasagna.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudLasagna.Value));
                price[newItemCounter] = (double.Parse(lblPriceLasagna.Text));
                newItemCounter++;
            }

            if (nudRatatouille.Value >= 1)
            {
                currentItems[newItemCounter] = (lblRatatouille.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudRatatouille.Value));
                price[newItemCounter] = (double.Parse(lblPriceRatatouille.Text));
                newItemCounter++;
            }

            if (nudFettAlfredo.Value >= 1)
            {
                currentItems[newItemCounter] = (lblFettAlfredo.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudFettAlfredo.Value));
                price[newItemCounter] = (double.Parse(lblPriceFettAlfredo.Text));
                newItemCounter++;
            }

            if (nudStuffedShells.Value >= 1)
            {
                currentItems[newItemCounter] = (lblStuffedShells.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudStuffedShells.Value));
                price[newItemCounter] = (double.Parse(lblPriceStuffedShells.Text));
                newItemCounter++;
            }

            if (nudPizza.Value >= 1)
            {
                currentItems[newItemCounter] = (lblPizza.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudPizza.Value));
                price[newItemCounter] = (double.Parse(lblPricePizza.Text));
                newItemCounter++;
            }

            if (nudPesto.Value >= 1)
            {
                currentItems[newItemCounter] = (lblPesto.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudPesto.Value));
                price[newItemCounter] = (double.Parse(lblPricePesto.Text));
                newItemCounter++;
            }

            if (nudSeafoodPasta.Value >= 1)
            {
                currentItems[newItemCounter] = (lblSeafoodPasta.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudSeafoodPasta.Value));
                price[newItemCounter] = (double.Parse(lblPriceSeafoodPasta.Text));
                newItemCounter++;
            }

            if (nudRavioli.Value >= 1)
            {
                currentItems[newItemCounter] = (lblRavioli.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudRavioli.Value));
                price[newItemCounter] = (double.Parse(lblPriceRavioli.Text));
                newItemCounter++;
            }

            if (nudMacaroni.Value >= 1)
            {
                currentItems[newItemCounter] = (lblMacaroni.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudMacaroni.Value));
                price[newItemCounter] = (double.Parse(lblPriceMacaroni.Text));
                newItemCounter++;
            }

            //SALADS
            if (nudCapreseSalad.Value >= 1)
            {
                currentItems[newItemCounter] = (lblCapreseSalad.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudCapreseSalad.Value));
                price[newItemCounter] = (double.Parse(lblPriceCapreseSalad.Text));
                newItemCounter++;
            }

            if (nudBigGreenSalad.Value >= 1)
            {
                currentItems[newItemCounter] = (lblGreenSalad.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudBigGreenSalad.Value));
                price[newItemCounter] = (double.Parse(lblPriceBigGreenSalad.Text));
                newItemCounter++;
            }

            if (nudAntiPastoSalad.Value >= 1)
            {
                currentItems[newItemCounter] = (lblAntiPastoSalad.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudAntiPastoSalad.Value));
                price[newItemCounter] = (double.Parse(lblPriceAntiPastoSalad.Text));
                newItemCounter++;
            }

            // Lee //
            // Desserts //
            if (nudTiramisu.Value >= 1)
            {
                currentItems[newItemCounter] = (lblTiramisu.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudTiramisu.Value));
                price[newItemCounter] = (double.Parse(lblPriceTiramisu.Text));
                newItemCounter++;
            }

            if (nudGelato.Value >= 1)
            {
                currentItems[newItemCounter] = (lblGelato.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudGelato.Value));
                price[newItemCounter] = (double.Parse(lblPriceGelato.Text));
                newItemCounter++;
            }

            if (nudCannoli.Value >= 1)
            {
                currentItems[newItemCounter] = (lblCannoli.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudCannoli.Value));
                price[newItemCounter] = (double.Parse(lblPriceCannoli.Text));
                newItemCounter++;
            }

            // Lee //
            // Beverages //
            if (nudRedWine.Value >= 1)
            {
                currentItems[newItemCounter] = (lblRedWine.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudRedWine.Value));
                price[newItemCounter] = (double.Parse(lblPriceRedWine.Text));
                newItemCounter++;
            }

            if (nudWhiteWine.Value >= 1)
            {
                currentItems[newItemCounter] = (lblWhiteWine.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudWhiteWine.Value));
                price[newItemCounter] = (double.Parse(lblPriceWhiteWine.Text));
                newItemCounter++;
            }

            if (nudItalianSoda.Value >= 1)
            {
                currentItems[newItemCounter] = (lblItalianSoda.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudItalianSoda.Value));
                price[newItemCounter] = (double.Parse(lblPriceItalianSoda.Text));
                newItemCounter++;
            }

            if (nudSanPellegrino.Value >= 1)
            {
                currentItems[newItemCounter] = (lblSanPellegrino.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudSanPellegrino.Value));
                price[newItemCounter] = (double.Parse(lblPriceSanPellegrino.Text));
                newItemCounter++;
            }

            if (nudPellegrinoWater.Value >= 1)
            {
                currentItems[newItemCounter] = (lblPellegrinoWater.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudPellegrinoWater.Value));
                price[newItemCounter] = (double.Parse(lblPricePellegrinoWater.Text));
                newItemCounter++;
            }

            if (nudCocaCola.Value >= 1)
            {
                currentItems[newItemCounter] = (lblCocaCola.Text);
                currentQuantity[newItemCounter] = (Convert.ToInt32(nudCocaCola.Value));
                price[newItemCounter] = (double.Parse(lblPriceCocaCola.Text));
                newItemCounter++;
            }

            // For Loop displays items slected and adds them to a list //
            for (int i = 0; i < newItemCounter; i++)
                orderForm.lstCurrentItems.Items.Add(currentQuantity[i] + " " + currentItems[i] + " @ $" + price[i] + " each");

           

            // estimate variable is assigned the return value of calling estimateCalculator //
            estimate = estimateCalculator();

            // Displays estimate total in lblEstimatedTotal //
            orderForm.lblEstimatedTotal.Text = estimate.ToString("C");
            orderForm.ShowDialog();

        }

        //Yongqin Lin
        //Defined a method to update the totalItems & totalQuantity array for total Order
        public static void updateArray()
        {
            for (int i = 0; i < newItemCounter+1; i++)

            {
                bool itemExisted = false;
                for (int j = 0; j < totalItemCounter; j++)
                {
                    //if customer selected the item that exists in previous order, update the quantity in new array
                    if (string.Equals(totalItems[j], currentItems[i]))
                    {
                        totalQuantity[j] += currentQuantity[i];
                        itemExisted = true;
                        break;
                    }
                }
                if (!itemExisted)
                {
                    
                    totalItems[totalItemCounter] = currentItems[i];
                    totalQuantity[totalItemCounter] = currentQuantity[i];
                    totalItemCounter ++;
                }

            }
        }

        

        // Lee //
        //Executes when Start Over button is clicked //
        // Resets Numeric up and down back to zero//
        private void btnStartOver_Click(object sender, EventArgs e)
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


    }
}
