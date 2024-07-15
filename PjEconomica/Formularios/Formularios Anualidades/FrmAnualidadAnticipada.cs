using PjEconomica.Formularios.Formularios_Anualidades.Anualidad_Anticipada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjEconomica.Formularios.Formularios_Anualidades
{
    public partial class FrmAnualidadAnticipada : Form
    {
        public FrmAnualidadAnticipada()
        {
            InitializeComponent();
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            FrmPresenteAnual frmPresenteAnual = new FrmPresenteAnual();
            frmPresenteAnual.ShowDialog();
        }

        private void btnFu_Click(object sender, EventArgs e)
        {
            FrmFuturoAnual frmFuturoAnual = new FrmFuturoAnual();
            frmFuturoAnual.ShowDialog();
        }

        private void btnAnuPre_Click(object sender, EventArgs e)
        {
            FrmAnualidadPre frmAnualidad = new FrmAnualidadPre();
            frmAnualidad.ShowDialog();
        }

        private void btnAnuFu_Click(object sender, EventArgs e)
        {
            FrmAnualidadFutu frmAnualidadFutu = new FrmAnualidadFutu();
            frmAnualidadFutu.ShowDialog();
        }
    }
}
