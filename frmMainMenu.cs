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
        const int MAX_ITEMS = 22;
        int itemCounter = 0;
        double estimate = 0;

        string[] items = new string[MAX_ITEMS];
        int[] quantity = new int[MAX_ITEMS];
        double[] price = new double[MAX_ITEMS];

        public double estimateCalculator()
        {
            double sum = 0;
            for(int i =0; i < itemCounter; i++)
            {
                sum += price[i] * quantity[i];
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



        public void btnViewOrder_Click(object sender, EventArgs e)
        {
            itemCounter = 0;
            Array.Clear(items, 0, items.Length);
            Array.Clear(quantity, 0, items.Length);
            Array.Clear(price, 0, items.Length);

            frmViewOrder orderForm = new frmViewOrder();

            if (nudSpaghetti.Value >= 1)
            {
                //orderForm.lstItemsOrdered.Items.Add(lblSpaghetti.Text + " - " + nudSpaghetti.Value);
                items[itemCounter] =(lblSpaghetti.Text);
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

            for (int i = 0; i < itemCounter; i++)
                orderForm.lstItemsOrdered.Items.Add(quantity[i] + " " + items[i] + " @ $" + price[i] + " each");

            estimate = estimateCalculator();
            orderForm.lblEstimatedTotal.Text = estimate.ToString("C");
            orderForm.ShowDialog();
            
        }

        private void MainMenu_Click(object sender, EventArgs e) 
        {
            // Accidental MainMenu Click created //
        }
    }
}
