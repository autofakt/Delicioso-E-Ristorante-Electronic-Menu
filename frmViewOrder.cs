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
            this.Close();
        }
    }
}
