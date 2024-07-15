using PjEconomica.Formularios.Formulario_Calendario_de_pago;
using PjEconomica.Formularios.Formularios_Anualidades;
using PjEconomica.Formularios.Formularios_Gradientes;
using PjEconomica.Formularios.Formularios_Indicadores;
using PjEconomica.Formularios.formularios_Intereses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjEconomica
{
    public partial class FrmPincipal : Form
    {
        public FrmPincipal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDefinicionIndicadores frmDefinicion = new FrmDefinicionIndicadores();
            frmDefinicion.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmPincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnInteres_Click(object sender, EventArgs e)
        {
            FrmDefinicion frmDefinicion = new FrmDefinicion();
            frmDefinicion.ShowDialog();
        }

        private void btnGradientes_Click(object sender, EventArgs e)
        {
            FrmGradientes frmGradientes = new FrmGradientes();
            frmGradientes.ShowDialog();
        }

        private void btnAnualidades_Click(object sender, EventArgs e)
        {
            FrmAnualidades frmAnualidades = new FrmAnualidades();
            frmAnualidades.ShowDialog();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            FrmCalendarioPago frmCalendario = new FrmCalendarioPago();
            frmCalendario.ShowDialog();
        }
    }
}
