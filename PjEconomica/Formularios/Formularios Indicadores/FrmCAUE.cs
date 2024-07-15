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
    public partial class FrmCAUE : Form
    {
        public FrmCAUE()
        {
            InitializeComponent();
        }

        private void btnFondoAmort_Click(object sender, EventArgs e)
        {
            FrmFondoAmortizacion frmFondoAmortizacion = new FrmFondoAmortizacion();
            frmFondoAmortizacion.ShowDialog();
        }

        private void btnValorpresent_Click(object sender, EventArgs e)
        {
            FrmValorPresente frmValorPresente = new FrmValorPresente();
            frmValorPresente.ShowDialog();
        }
    }
}
