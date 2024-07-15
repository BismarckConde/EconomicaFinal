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
    public partial class FrmInteresSimple : Form
    {
        public FrmInteresSimple()
        {
            InitializeComponent();
        }

        private void FrmInteresSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnfuturo_Click(object sender, EventArgs e)
        {
            FrmFuturo frmFuturo = new FrmFuturo();
            frmFuturo.ShowDialog();

        }

        private void btnPresente_Click(object sender, EventArgs e)
        {
            FrmPresente frmPresente = new FrmPresente();
            frmPresente.ShowDialog();
        }

        private void btnPeriodo_Click(object sender, EventArgs e)
        {
            FrmPeriodo frmPeriodo = new FrmPeriodo();
            frmPeriodo.ShowDialog();
        }
    }
}
