using PjEconomica.Clases;
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
    public partial class FrmFutuAri : Form
    {
        public FrmFutuAri()
        {
            InitializeComponent();
        }

        List<object> resultadosFG = new List<object>();
        private void btncalcular_Click(object sender, EventArgs e)
        {

            if (rdbIncrementaFG.Checked == true)
            {
                var FG = new Metodos();
                string interesF = cmbInteresFG.SelectedItem?.ToString() ?? string.Empty;
                string periodoF = cmbPeriodoFG.SelectedItem?.ToString()?? string.Empty;
                double Anualidad = Convert.ToDouble(txtAnualidadFG.Text);
                double interes = Convert.ToDouble(txtInteresFG.Text);
                int periodo1 = Convert.ToInt32(txtPeriodoFG.Text);
                double gradiente = Convert.ToDouble(txtGradienteFG.Text);
                FG.FuturoCrece(interesF, periodoF, interes, Anualidad, periodo1, resultadosFG, dgvResultadosFG, gradiente);
            }
            else if (rdbDecreceFG.Checked == true)
            {
                var FG = new Metodos();
                string interesF = cmbInteresFG.SelectedItem?.ToString()?? string.Empty;
                string periodoF = cmbPeriodoFG.SelectedItem?.ToString()?? string.Empty;
                double Anualidad = Convert.ToDouble(txtAnualidadFG.Text);
                double interes = Convert.ToDouble(txtInteresFG.Text);
                int periodo1 = Convert.ToInt32(txtPeriodoFG.Text);
                double gradiente = Convert.ToDouble(txtGradienteFG.Text);
                FG.FuturoDecrece(interesF, periodoF, interes, Anualidad, periodo1, resultadosFG, dgvResultadosFG, gradiente);
            }
        }
    }
}
