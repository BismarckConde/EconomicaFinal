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
    public partial class FrmAnualidades : Form
    {
        public FrmAnualidades()
        {
            InitializeComponent();
        }

        private void btnAnuVencida_Click(object sender, EventArgs e)
        {
            FrmAnualidadVencida frmAnualidadVencida = new FrmAnualidadVencida();
            frmAnualidadVencida.ShowDialog();
        }

        private void btnAnuAnticipadas_Click(object sender, EventArgs e)
        {
            FrmAnualidadAnticipada frmAnualidadAnticipada = new FrmAnualidadAnticipada();
            frmAnualidadAnticipada.ShowDialog();

        }

        private void btnAnuDiferidas_Click(object sender, EventArgs e)
        {
            FrmAnualidadDiferida frmAnualidadDiferida = new FrmAnualidadDiferida();
            frmAnualidadDiferida.ShowDialog();
        }

        private void btnAnuPerpetuas_Click(object sender, EventArgs e)
        {
            FrmAnualidadPerpetua frmAnualidadPerpetua = new FrmAnualidadPerpetua();
            frmAnualidadPerpetua.ShowDialog();
        }
    }
}
