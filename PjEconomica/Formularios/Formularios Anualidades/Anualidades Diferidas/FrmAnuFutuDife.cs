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
    public partial class FrmAnuFutuDife : Form
    {
       
        public FrmAnuFutuDife()
        {
            InitializeComponent();
           
        }
        List<object> ResultadosAf = new List<object>(); 
        private void btnCal_Click(object sender, EventArgs e)
        {

            double ValorFuturoAf, i1, TasaInteresAf;
            int n, PeriodoAf;
            if (rdbno.Checked == true)
            {
                try
                {
                    ValorFuturoAf = Convert.ToDouble(txtValorFuturoAnualidadFuturo.Text);
                    i1 = Convert.ToDouble(txtInteresAnualidadFuturo.Text);
                    n = Convert.ToInt32(txtPeriodoAnualidadFuturo.Text);

                    if (cmbInteresAf.SelectedItem != null && cmbPeriodoAf.SelectedItem != null)
                    {
                        if (cmbInteresAf.SelectedItem.Equals("Anual") && cmbPeriodoAf.SelectedItem.Equals("Años"))
                        {
                            TasaInteresAf = i1 / 100;
                            PeriodoAf = n;
                            double AnualidadFuturo = ValorFuturoAf * (TasaInteresAf / (Math.Pow(1 + TasaInteresAf, PeriodoAf) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = TasaInteresAf, Periodo = PeriodoAf, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Anual") && cmbPeriodoAf.SelectedItem.Equals("Meses"))
                        {
                            TasaInteresAf = i1 / 100;
                            PeriodoAf = n / 12;
                            double AnualidadFuturo = ValorFuturoAf * (TasaInteresAf / (Math.Pow(1 + TasaInteresAf, PeriodoAf) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = TasaInteresAf, Periodo = PeriodoAf, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Anual") && cmbPeriodoAf.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteresAf = i1 / 100;
                            PeriodoAf = n / 2;
                            double AnualidadFuturo = ValorFuturoAf * (TasaInteresAf / (Math.Pow(1 + TasaInteresAf, PeriodoAf) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = TasaInteresAf, Periodo = PeriodoAf, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Anual") && cmbPeriodoAf.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteresAf = i1 / 100;
                            PeriodoAf = n / 2;
                            double AnualidadFuturo = ValorFuturoAf * (TasaInteresAf / (Math.Pow(1 + TasaInteresAf, PeriodoAf) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = TasaInteresAf, Periodo = PeriodoAf, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Anual") && cmbPeriodoAf.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteresAf = i1 / 100;
                            PeriodoAf = n / 4;
                            double AnualidadFuturo = ValorFuturoAf * (TasaInteresAf / (Math.Pow(1 + TasaInteresAf, PeriodoAf) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = TasaInteresAf, Periodo = PeriodoAf, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        //Final de tasa interes anual
                        else if (cmbInteresAf.SelectedItem.Equals("Mensual") && cmbPeriodoAf.SelectedItem.Equals("Años"))
                        {
                            TasaInteresAf = i1 / 100;
                            PeriodoAf = n * 12;
                            double AnualidadFuturo = ValorFuturoAf * (TasaInteresAf / (Math.Pow(1 + TasaInteresAf, PeriodoAf) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = TasaInteresAf, Periodo = PeriodoAf, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Mensual") && cmbPeriodoAf.SelectedItem.Equals("Meses"))
                        {
                            TasaInteresAf = i1 / 100;
                            PeriodoAf = n;
                            double AnualidadFuturo = ValorFuturoAf * (TasaInteresAf / (Math.Pow(1 + TasaInteresAf, PeriodoAf) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = TasaInteresAf, Periodo = PeriodoAf, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Mensual") && cmbPeriodoAf.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteresAf = i1 / 100;
                            PeriodoAf = n * 6;
                            double AnualidadFuturo = ValorFuturoAf * (TasaInteresAf / (Math.Pow(1 + TasaInteresAf, PeriodoAf) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = TasaInteresAf, Periodo = PeriodoAf, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Mensual") && cmbPeriodoAf.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteresAf = i1 / 100;
                            PeriodoAf = n * 3;
                            double AnualidadFuturo = ValorFuturoAf * (TasaInteresAf / (Math.Pow(1 + TasaInteresAf, PeriodoAf) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = TasaInteresAf, Periodo = PeriodoAf, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        //Fin de interes Mensual

                        else if (cmbInteresAf.SelectedItem.Equals("Semestral") && cmbPeriodoAf.SelectedItem.Equals("Años"))
                        {
                            TasaInteresAf = i1 / 100;
                            PeriodoAf = n * 2;
                            double AnualidadFuturo = ValorFuturoAf * (TasaInteresAf / (Math.Pow(1 + TasaInteresAf, PeriodoAf) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = TasaInteresAf, Periodo = PeriodoAf, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Semestral") && cmbPeriodoAf.SelectedItem.Equals("Meses"))
                        {
                            TasaInteresAf = i1 / 100;
                            PeriodoAf = n / 6;
                            double AnualidadFuturo = ValorFuturoAf * (TasaInteresAf / (Math.Pow(1 + TasaInteresAf, PeriodoAf) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = TasaInteresAf, Periodo = PeriodoAf, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Semestral") && cmbPeriodoAf.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteresAf = i1 / 100;
                            PeriodoAf = n;
                            double AnualidadFuturo = ValorFuturoAf * (TasaInteresAf / (Math.Pow(1 + TasaInteresAf, PeriodoAf) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = TasaInteresAf, Periodo = PeriodoAf, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Semestral") && cmbPeriodoAf.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteresAf = i1 / 100;
                            PeriodoAf = n / 2;
                            double AnualidadFuturo = ValorFuturoAf * (TasaInteresAf / (Math.Pow(1 + TasaInteresAf, PeriodoAf) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = TasaInteresAf, Periodo = PeriodoAf, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        // Fin de Interes Semestral
                        else if (cmbInteresAf.SelectedItem.Equals("Trimestral") && cmbPeriodoAf.SelectedItem.Equals("Años"))
                        {
                            TasaInteresAf = i1 / 100;
                            PeriodoAf = n * 4;
                            double AnualidadFuturo = ValorFuturoAf * (TasaInteresAf / (Math.Pow(1 + TasaInteresAf, PeriodoAf) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = TasaInteresAf, Periodo = PeriodoAf, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Trimestral") && cmbPeriodoAf.SelectedItem.Equals("Meses"))
                        {
                            TasaInteresAf = i1 / 100;
                            PeriodoAf = n / 3;
                            double AnualidadFuturo = ValorFuturoAf * (TasaInteresAf / (Math.Pow(1 + TasaInteresAf, PeriodoAf) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = TasaInteresAf, Periodo = PeriodoAf, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Trimestral") && cmbPeriodoAf.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteresAf = i1 / 100;
                            PeriodoAf = n * 2;
                            double AnualidadFuturo = ValorFuturoAf * (TasaInteresAf / (Math.Pow(1 + TasaInteresAf, PeriodoAf) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = TasaInteresAf, Periodo = PeriodoAf, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Trimestral") && cmbPeriodoAf.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteresAf = i1 / 100;
                            PeriodoAf = n;
                            double AnualidadFuturo = ValorFuturoAf * (TasaInteresAf / (Math.Pow(1 + TasaInteresAf, PeriodoAf) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = TasaInteresAf, Periodo = PeriodoAf, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                    }
                }
                catch (FormatException x)
                {
                    MessageBox.Show("Rellene los campos necesarios" + x);
                }
            }
            else if (rdbSi.Checked == true)
            {
                var metodos5 = new Metodos();
                string interesFuturoAf = cmbInteresAf.SelectedItem?.ToString()?? string.Empty;
                string periodoFuturoAf = cmbPeriodoAf.SelectedItem?.ToString()?? string.Empty;
                double tasaInteresFuturoAf = Convert.ToDouble(txtInteresAnualidadFuturo.Text);
                double valorFuturoAf = Convert.ToDouble(txtValorFuturoAnualidadFuturo.Text);
                int periodo1Af = Convert.ToInt32(txtPeriodoAnualidadFuturo.Text);

                metodos5.AnualidadFuturo(interesFuturoAf, periodoFuturoAf, tasaInteresFuturoAf, valorFuturoAf, periodo1Af, ResultadosAf, dgvResultadosAnualidadFuturo);
            }
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtValorFuturoAnualidadFuturo.Clear();
            txtInteresAnualidadFuturo.Clear();
            txtPeriodoAnualidadFuturo.Clear();
            
        }
    }
}
