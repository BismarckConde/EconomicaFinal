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
    public partial class FrmGradientes : Form
    {
        public FrmGradientes()
        {
            InitializeComponent();
        }

        private void btnGraArit_Click(object sender, EventArgs e)
        {
            FrmGradienteAritmético frmGradienteAritmético = new FrmGradienteAritmético();
            frmGradienteAritmético.ShowDialog();
        }

        private void btnGraGeo_Click(object sender, EventArgs e)
        {
            FrmGradienteGeométrico frmGradienteGeométrico = new FrmGradienteGeométrico();
            frmGradienteGeométrico.ShowDialog();
        }
    }
}
