using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjEconomica
{
    public partial class FrmDfinicionEconomica : Form
    {
        public FrmDfinicionEconomica()
        {
            InitializeComponent();
        }

        private void btnMenuOp_Click(object sender, EventArgs e)
        {
            FrmPincipal frmPincipal = new FrmPincipal();
            frmPincipal.ShowDialog();
        }
    }
}
