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
        public frmMainMenu()
        {
            InitializeComponent();
        }

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

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            frmViewOrder orderForm = new frmViewOrder();
            orderForm.Show();
            
        }
    }
}
