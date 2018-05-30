using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESquare.Paparazzi.Forms
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void ucSettings1_Load(object sender, EventArgs e)
        {

        }

        private void ucSettings1_AfterOkPressed()
        {
            Close();
        }

        private void ucSettings1_AfterCancelPressed()
        {
            Close();
        }
    }
}
