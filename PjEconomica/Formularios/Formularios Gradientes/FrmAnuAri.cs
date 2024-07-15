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
    public partial class FrmAnuAri : Form
    {
        public FrmAnuAri()
        {
            InitializeComponent();
        }

        List<object> resultadosGA = new List<object>();
        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbPresenteIncrementa.Checked == true)
                {
                    var GA = new Metodos();
                    string interesA = cmbInteresGA.SelectedItem?.ToString()?? string.Empty;
                    string periodoA = cmbPeriodoGA.SelectedItem?.ToString() ?? string.Empty;
                    double Anualidad = Convert.ToDouble(txtAnualidadGA.Text);
                    double interes = Convert.ToDouble(txtInteresGA.Text);
                    int periodo1 = Convert.ToInt32(txtPeriodoGA.Text);
                    double gradiente = Convert.ToDouble(txtGradienteGA.Text);

                    GA.PresenteCreciente(interesA, periodoA, interes, Anualidad, periodo1, resultadosGA, dgvResultadosGA, gradiente);
                }
                else if (rdbPresenteDecrece.Checked == true)
                {
                    var GA = new Metodos();
                    string interesA = cmbInteresGA.SelectedItem?.ToString()?? string.Empty;
                    string periodoA = cmbPeriodoGA.SelectedItem?.ToString() ?? string.Empty;
                    double Anualidad = Convert.ToDouble(txtAnualidadGA.Text);
                    double interes = Convert.ToDouble(txtInteresGA.Text);
                    int periodo1 = Convert.ToInt32(txtPeriodoGA.Text);
                    double gradiente = Convert.ToDouble(txtGradienteGA.Text);
                    GA.AnualidadDecreciente(interesA, periodoA, interes, Anualidad, periodo1, resultadosGA, dgvResultadosGA, gradiente);
                }
            }
            catch (FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios" + x);
            }
        }
    }
}
