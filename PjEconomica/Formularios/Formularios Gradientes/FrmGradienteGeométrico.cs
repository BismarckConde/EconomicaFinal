using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjEconomica.Formularios.Formularios_Gradientes
{
    public partial class FrmGradienteGeométrico : Form
    {
        public FrmGradienteGeométrico()
        {
            InitializeComponent();
        }

        private void btnPresente_Click(object sender, EventArgs e)
        {
            FrmGeoPresent frmGeoPresent = new FrmGeoPresent();
            frmGeoPresent.ShowDialog();
        }

        private void btnFuturo_Click(object sender, EventArgs e)
        {
            FrmGeoFuturo frmGeoFuturo = new FrmGeoFuturo();
            frmGeoFuturo.ShowDialog();
        }

        private void btnAnualidad_Click(object sender, EventArgs e)
        {
            FrmGeoAnual frmGeoAnual = new FrmGeoAnual();
            frmGeoAnual.ShowDialog();
        }
    }
}
