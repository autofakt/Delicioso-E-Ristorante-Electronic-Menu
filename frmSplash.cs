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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        // Lee Salazar Chavez //
        // Added timer to Splash screen //
        private void timerSplash_Tick(object sender, EventArgs e)
        {
            timerSplash.Start();
            this.Close();
        }
    }
}
