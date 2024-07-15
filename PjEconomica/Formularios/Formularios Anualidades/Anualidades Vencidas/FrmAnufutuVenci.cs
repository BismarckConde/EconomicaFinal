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
    public partial class FrmAnufutuVenci : Form
    {
       
        public FrmAnufutuVenci()
        {
            InitializeComponent();
            
        }

        private List<object> ResultadosAf = new List<object>();
        private void btnCal_Click(object sender, EventArgs e)
        {
            int Futuro, Periodo, n;
            double TasaInteres, i1;
            if (rdbNoFuturo.Checked == true)
            {

                try
                {
                    Futuro = Convert.ToInt32(txtValorFuturoAnualidadFuturo.Text);
                    i1 = Convert.ToDouble(txtInteresAnualidadFuturo.Text);
                    n = Convert.ToInt32(txtPeriodoAnualidadFuturo.Text);

                    if (cmbInteresAF.SelectedItem != null && cmbPeriodoAF.SelectedItem != null)
                    {
                        if (cmbInteresAF.SelectedItem.Equals("Anual") && cmbPeriodoAF.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Anual") && cmbPeriodoAF.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n / 12;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();

                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Anual") && cmbPeriodoAF.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n / 2;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Anual") && cmbPeriodoAF.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n / 4;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        //Fin de interes anual 
                        else if (cmbInteresAF.SelectedItem.Equals("Mensual") && cmbPeriodoAF.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n * 12;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Mensual") && cmbPeriodoAF.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Mensual") && cmbPeriodoAF.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n * 6;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Mensual") && cmbPeriodoAF.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n * 3;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Semestral") && cmbPeriodoAF.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n * 2;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Semestral") && cmbPeriodoAF.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n / 6;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Semestral") && cmbPeriodoAF.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Semestral") && cmbPeriodoAF.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n / 2;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Trimestral") && cmbPeriodoAF.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n * 4;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Trimestral") && cmbPeriodoAF.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n / 3;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Trimestral") && cmbPeriodoAF.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n * 2;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAF.SelectedItem.Equals("Trimestral") && cmbPeriodoAF.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n;
                            double AnualidadFuturo = Futuro * (TasaInteres / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAf.Add(new { ValorFuturo = Futuro, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadFuturo });
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
            else if (rdbSiFuturo.Checked == true)
            {
                var metodos8 = new Metodos();
                string interesFuturoAf = cmbInteresAF.SelectedItem?.ToString() ?? string.Empty;
                string periodoFuturoAf = cmbPeriodoAF.SelectedItem?.ToString()?? string.Empty;
                double tasaInteresFuturoAf = Convert.ToDouble(txtInteresAnualidadFuturo.Text);
                double valorAnualidadFuturoAf = Convert.ToDouble(txtValorFuturoAnualidadFuturo.Text);
                int periodo1FuturoAf = Convert.ToInt32(txtPeriodoAnualidadFuturo.Text);

                metodos8.AnualidadFuturo(interesFuturoAf, periodoFuturoAf, tasaInteresFuturoAf, valorAnualidadFuturoAf, periodo1FuturoAf, ResultadosAf, dgvResultadosAnualidadFuturo);
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
