using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjEconomica.Formularios.formularios_Intereses
{
    public partial class FrmDefinicionCompuesto : Form
    {
        public FrmDefinicionCompuesto()
        {
            InitializeComponent();
        }

        private void btnfuturo_Click(object sender, EventArgs e)
        {
            FrmFuturoCompuesto frmFuturoCompuesto = new FrmFuturoCompuesto();
            frmFuturoCompuesto.ShowDialog();
        }

        private void btnPresente_Click(object sender, EventArgs e)
        {
            FrmPresenteCompuesto frmPresenteCompuesto = new FrmPresenteCompuesto();
            frmPresenteCompuesto.ShowDialog();
        }

        private void btnPeriodo_Click(object sender, EventArgs e)
        {
            FrmPeriodoCompuesto frmPeriodoCompuesto = new FrmPeriodoCompuesto();
            frmPeriodoCompuesto.ShowDialog();
        }
    }
}
