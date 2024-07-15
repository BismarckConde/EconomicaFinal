using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjEconomica.Formularios.Formularios_Indicadores
{
    public partial class FrmDefinicionCAUE : Form
    {
        public FrmDefinicionCAUE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCAUE frmCAUE = new FrmCAUE();
            frmCAUE.ShowDialog();
        }
    }
}
