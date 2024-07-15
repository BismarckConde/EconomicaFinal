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

namespace PjEconomica.Formularios.Formularios_Anualidades.Anualidades_Vencidas
{
    public partial class FrmfuturoVenci : Form
    {
        public FrmfuturoVenci()
        {
            InitializeComponent();
           
        }
        private List<object> ResultadosFuturo = new List<object>();
        private void btnCal_Click(object sender, EventArgs e)
        {
            int AnualidadFuturo, p1, Periodo;
            double TasaInteres, i1;
            if (rdbNoFuturo.Checked == true)
            {
                try
                {
                    AnualidadFuturo = Convert.ToInt32(txtanu.Text);
                    i1 = Convert.ToDouble(txtInteresFuturo.Text);
                    p1 = Convert.ToInt32(txtPeriodoFuturo.Text);


                    if (cmbInteresAnualidadVencidaFuturo.SelectedItem != null && cmbPeriodoAnualidadVencida.SelectedItem != null)
                    {
                        if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Anual") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1;

                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Anual") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 / 12;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Anual") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 / 2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Anual") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 / 4;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        //Fin de tasa Interes Anual

                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 * 12;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 * 6;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Mensual") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 * 3;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        //Fin de Tasa Interes Mensual
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 * 2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 / 6;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Semestral") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 / 2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        // Fin de Tasa Interes Semestral


                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 * 4;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();

                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 / 3;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1 * 2;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadVencidaFuturo.SelectedItem.Equals("Trimestral") && cmbPeriodoAnualidadVencida.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = p1;
                            double F = (AnualidadFuturo * (Math.Pow((1 + TasaInteres), (Periodo)) - 1) / TasaInteres);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, Interes = TasaInteres, PeriodoF = Periodo, Futuro = F });

                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        //Fin de Tasa interes Trimestral
                    }
                }
                catch (FormatException x)
                {
                    MessageBox.Show("Rellene los campos necesarios");
                }
            }
            else if (rdbSiFuturo.Checked == true)
            {
                var metodos4 = new Metodos();
                string InteresFuturo = cmbInteresAnualidadVencidaFuturo.SelectedItem?.ToString()?? string.Empty;
                string PeriodoFuturo = cmbPeriodoAnualidadVencida.SelectedItem?.ToString()?? string.Empty;
                double TasaInteres1 = Convert.ToDouble(txtInteresFuturo.Text);
                double valorAnualidadFuturo = Convert.ToDouble(txtanu.Text);
                int Periodo1 = Convert.ToInt32(txtPeriodoFuturo.Text);

                metodos4.CalcularFuturoAnualidadVencida(InteresFuturo, PeriodoFuturo, TasaInteres1, valorAnualidadFuturo, Periodo1, ResultadosFuturo, dgvResultadosFuturo);

            }

        }



        private void btnLim_Click(object sender, EventArgs e)
        {
            txtanu.Clear();
            txtInteresFuturo.Clear();
            txtPeriodoFuturo.Clear();
            
        }
    }
}
