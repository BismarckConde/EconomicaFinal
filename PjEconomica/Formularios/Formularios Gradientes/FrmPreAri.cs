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
    public partial class FrmPreAri : Form
    {
        public FrmPreAri()
        {
            InitializeComponent();
        }

        List<object> resultadosPG = new List<object>();
        private void btncalcular_Click(object sender, EventArgs e)
        {

            if (rdbIncrementaPG.Checked == true)
            {
                var PG = new Metodos();
                string interesP = cmbInteresPG.SelectedItem?.ToString()?? string.Empty;
                string periodoP = cmbPeriodoPG.SelectedItem?.ToString() ?? string.Empty;
                double Anualidad = Convert.ToDouble(txtAnualidadPG.Text);
                double interes = Convert.ToDouble(txtInteresPG.Text);
                int Periodo1 = Convert.ToInt32(txtPeriodoPG.Text);
                double gradiente = Convert.ToDouble(txtGradientePG.Text);
                PG.preseCreciente(interesP, periodoP, interes, Anualidad, Periodo1, resultadosPG, dgvResultadosPG, gradiente);
            }
            else if (rdbDecrecePG.Checked == true)
            {
                var PG = new Metodos();
                string interesP = cmbInteresPG.SelectedItem?.ToString() ?? string.Empty;
                string periodoP = cmbPeriodoPG.SelectedItem?.ToString() ?? string.Empty;
                double Anualidad = Convert.ToDouble(txtAnualidadPG.Text);
                double interes = Convert.ToDouble(txtInteresPG.Text);
                int Periodo1 = Convert.ToInt32(txtPeriodoPG.Text);
                double gradiente = Convert.ToDouble(txtGradientePG.Text);
                PG.preseDecrece(interesP, periodoP, interes, Anualidad, Periodo1, resultadosPG, dgvResultadosPG, gradiente);
            }
        }
    }
}
