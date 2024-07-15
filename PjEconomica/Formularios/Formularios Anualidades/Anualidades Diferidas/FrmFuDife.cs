using PjEconomica.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjEconomica.Formularios.Formularios_Anualidades.Anualidades_Diferidas
{
    public partial class FrmFuDife : Form
    {

        public FrmFuDife()
        {
            InitializeComponent();

        }

        private void cmbPeriodoPresente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        List<object> ResultadosFuturo = new List<object>();
        private void btnCal_Click(object sender, EventArgs e)
        {
            int p1, p2, Periodo1, Periodo2;
            double TasaInteres, i1, AnualidadFuturo = 0;
            if (rdbno.Checked == true)
            {
                try
                {
                    AnualidadFuturo = Convert.ToDouble(txtValorAnualidadFuturo.Text);
                    i1 = Convert.ToDouble(txtTasaInteresFuturo.Text);
                    p1 = Convert.ToInt32(txtPeriodo1Futuro.Text);
                    p2 = Convert.ToInt32(txtPeriodo2Futuro.Text);

                    if (cmbInteresFuturo.SelectedItem != null && cmbPeriodoFuturo.SelectedItem != null && cmbPeriodoFuturo2.SelectedItem != null)
                    {
                        if (cmbInteresFuturo.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Años") && cmbPeriodoFuturo2.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1;
                            Periodo2 = p2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Meses") && cmbPeriodoFuturo2.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 / 12;
                            Periodo2 = p2 / 12;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres") && cmbPeriodoFuturo2.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 / 2;
                            Periodo2 = p2 / 2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres") && cmbPeriodoFuturo2.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 / 4;
                            Periodo2 = p2 / 4;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        //Fin de tasa Interes Anual

                        else if (cmbInteresFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Años") && cmbPeriodoFuturo2.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 * 12;
                            Periodo2 = p2 * 12;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Meses") && cmbPeriodoFuturo2.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1;
                            Periodo2 = p2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres") && cmbPeriodoFuturo2.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 * 6;
                            Periodo2 = p2 * 6;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres") && cmbPeriodoFuturo2.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 * 3;
                            Periodo2 = p2 * 3;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        //Fin de Tasa Interes Mensual
                        else if (cmbInteresFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Años") && cmbPeriodoFuturo2.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 * 2;
                            Periodo2 = p2 * 2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Meses") && cmbPeriodoFuturo2.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 / 6;
                            Periodo2 = p2 / 6;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres") && cmbPeriodoFuturo2.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1;
                            Periodo2 = p2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres") && cmbPeriodoFuturo2.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 / 2;
                            Periodo2 = p2 / 2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        // Fin de Tasa Interes Semestral

                        else if (cmbInteresFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Años") && cmbPeriodoFuturo2.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 * 4;
                            Periodo2 = p2 * 4;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }

                        else if (cmbInteresFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Meses") && cmbPeriodoFuturo2.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 / 3;
                            Periodo2 = p2 / 3;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres") && cmbPeriodoFuturo2.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo1 = p1 * 2;
                            Periodo2 = p2 * 2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres") && cmbPeriodoFuturo2.SelectedItem.Equals("Trimestres"))
                        {

                            TasaInteres = i1 / 100;
                            Periodo1 = p1;
                            Periodo2 = p2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo1 - Periodo2)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, Periodo1F = Periodo1, Periodo2F = Periodo2, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        //Fin de Tasa interes Trimestral
                    }
                }
                catch (FormatException x)
                {
                    MessageBox.Show("Rellene los campos necesarios" + x);
                }
            }
            else if (rdbSi.Checked == true)
            {
                var metodos = new Metodos();
                string interesFuturo = cmbInteresFuturo.SelectedItem?.ToString() ?? string.Empty;
                string periodoFuturo = cmbPeriodoFuturo.SelectedItem?.ToString() ?? string.Empty;
                double tasaInteresFuturo = Convert.ToDouble(txtTasaInteresFuturo.Text);
                double valorAnualidadFuturo = Convert.ToDouble(txtValorAnualidadFuturo.Text);
                int periodo1Futuro = Convert.ToInt32(txtPeriodo1Futuro.Text);
                int periodo2Futuro = Convert.ToInt32(txtPeriodo2Futuro.Text);

                metodos.CalcularFuturo(interesFuturo, periodoFuturo, tasaInteresFuturo, valorAnualidadFuturo, periodo1Futuro, periodo2Futuro, ResultadosFuturo, dgvResultadosFuturo);

            }
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtValorAnualidadFuturo.Text = "";
            txtTasaInteresFuturo.Text = "";
            txtPeriodo1Futuro.Text = "";
            txtPeriodo2Futuro.Text = "";
        }
    }
}
