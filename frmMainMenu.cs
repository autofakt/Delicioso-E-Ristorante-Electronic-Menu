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
    }
}
