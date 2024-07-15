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

namespace PjEconomica.Formularios.Formularios_Anualidades.Anualidad_Anticipada
{
    public partial class FrmFuturoAnual : Form
    {
        
        public FrmFuturoAnual()
        {
            InitializeComponent();
           
        }

        List<object> ResultadosFuturo = new List<object>();
        private void btnCal_Click(object sender, EventArgs e)
        {
            double AnualidadFuturo, TasaInteresFuturo, i1;
            int Periodo, p1;
            if (rdbNoFuturo.Checked == true)
            {
                try
                {
                    AnualidadFuturo = Convert.ToDouble(txtanu.Text);
                    i1 = Convert.ToDouble(txttasa.Text);
                    p1 = Convert.ToInt32(txtperi.Text);
                    if (cmbInteresAnualidadF.SelectedItem != null && cmbPeriodoFuturo.SelectedItem != null)
                    {
                        if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 12;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();

                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 2;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 4;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();

                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 * 12;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 * 6;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 * 3;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 * 2;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 6;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 2;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 * 4;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 3;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 * 2;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                        else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteresFuturo = i1 / 100;
                            Periodo = p1 / 2;
                            double Futuro = (AnualidadFuturo + AnualidadFuturo * ((Math.Pow(1 + TasaInteresFuturo, Periodo - 1) - 1) / (TasaInteresFuturo * Math.Pow(1 + TasaInteresFuturo, Periodo - 1)))) * Math.Pow(1 + TasaInteresFuturo, Periodo);
                            ResultadosFuturo.Add(new { Anualidad = AnualidadFuturo, InteresFuturo = TasaInteresFuturo, PeriodoF = Periodo, Futuro = Futuro });
                            dgvResultadosFuturo.DataSource = null;
                            dgvResultadosFuturo.DataSource = ResultadosFuturo.ToList();
                        }
                    }
                }
                catch (FormatException x)
                {
                    MessageBox.Show("Rellene los campos necesarios" + x);
                }
            }
            else if (rdbSiFuturo.Checked == true)
            {
                var metodos4 = new Metodos();
                string InteresFuturo = cmbInteresAnualidadF.SelectedItem?.ToString()?? string.Empty;
                string PeriodoFuturo = cmbPeriodoFuturo.SelectedItem?.ToString() ?? string.Empty;
                double TasaInteres = Convert.ToDouble(txttasa.Text);
                double valorAnualidadFuturo = Convert.ToDouble(txtanu.Text);
                int Periodo1 = Convert.ToInt32(txtperi.Text);

                metodos4.CalcularFuturoAnticipado(InteresFuturo, PeriodoFuturo, TasaInteres, valorAnualidadFuturo, Periodo1, ResultadosFuturo, dgvResultadosFuturo);
            }

        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtanu.Clear();
            txttasa.Clear();
            txtperi.Clear();
            
        }
    }
}
