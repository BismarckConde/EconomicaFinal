using PjEconomica.Formularios.Formularios_Anualidades.Anualidades_Vencidas;
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
    public partial class FrmAnualidadVencida : Form
    {
        public FrmAnualidadVencida()
        {
            InitializeComponent();
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            FrmpresenVenci frmpresenVenci = new FrmpresenVenci();
            frmpresenVenci.ShowDialog();
        }

        private void btnFu_Click(object sender, EventArgs e)
        {
            FrmfuturoVenci frmfuturoVenci = new FrmfuturoVenci();
            frmfuturoVenci.ShowDialog();
        }

        private void btnAnuPre_Click(object sender, EventArgs e)
        {
            FrmAnuPreVenci frmAnuPreVenci = new FrmAnuPreVenci();
            frmAnuPreVenci.ShowDialog();
        }

        private void btnAnuFu_Click(object sender, EventArgs e)
        {
            FrmAnufutuVenci frmAnufutuVenci = new FrmAnufutuVenci();
            frmAnufutuVenci.ShowDialog();
        }
    }
}
