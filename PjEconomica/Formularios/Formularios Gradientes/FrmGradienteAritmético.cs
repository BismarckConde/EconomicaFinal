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
    public partial class FrmGradienteAritmético : Form
    {
        public FrmGradienteAritmético()
        {
            InitializeComponent();
        }

        private void btnPresente_Click(object sender, EventArgs e)
        {
            FrmPreAri frmGradinteAritPresent = new FrmPreAri();
            frmGradinteAritPresent.ShowDialog();
        }

        private void btnFuturo_Click(object sender, EventArgs e)
        {
            FrmFutuAri frmGraAritFuturo = new FrmFutuAri();
            frmGraAritFuturo.ShowDialog();
        }

        private void btnAnualidad_Click(object sender, EventArgs e)
        {
            FrmAnuAri frmGradienteAnuaarit = new FrmAnuAri();
            frmGradienteAnuaarit.ShowDialog();
        }
    }
}
