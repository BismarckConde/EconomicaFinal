using PjEconomica.Formularios.Formularios_Anualidades.Anualidades_Diferidas;
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
    public partial class FrmAnualidadDiferida : Form
    {
        public FrmAnualidadDiferida()
        {
            InitializeComponent();
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            FrmPreDife frmPreDife = new FrmPreDife();
            frmPreDife.ShowDialog();
        }

        private void btnFu_Click(object sender, EventArgs e)
        {
            FrmFuDife frmFuDife = new FrmFuDife();
            frmFuDife.ShowDialog();
        }

        private void btnAnuPre_Click(object sender, EventArgs e)
        {
            FrmAnuPreDife frmAnuPreDife = new FrmAnuPreDife();
            frmAnuPreDife.ShowDialog();
        }

        private void btnAnuFu_Click(object sender, EventArgs e)
        {
            FrmAnuFutuDife frmAnuFutuDife = new FrmAnuFutuDife();
            frmAnuFutuDife.ShowDialog();
        }
    }
}
