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
    public partial class FrmAnualidadFutu : Form
    {

        
        public FrmAnualidadFutu()
        {
            InitializeComponent(); 
           
        }

        List<object> ResultadosAf = new List<object>();
        private void btnCal_Click(object sender, EventArgs e)
        {

            if (rdbNoAnualidadAnticipadaAF.Checked == true)
            {
                try
                {
                    double i1;
                    int p1;
                    double ValorFuturoAf = Convert.ToDouble(txtValorFuturoAnualidadFuturo.Text);
                    double TasaInteresAf = Convert.ToDouble(txtInteresAnualidadFuturo.Text);
                    int PeriodoAf = Convert.ToInt32(txtPeriodoAnualidadFuturo.Text);


                    if (cmbInteresAf.SelectedItem != null && cmbPeriodoAf.SelectedItem != null)
                    {
                        if (cmbInteresAf.SelectedItem.Equals("Anual") && cmbPeriodoAf.SelectedItem.Equals("Años"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = i1, Periodo = p1, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Anual") && cmbPeriodoAf.SelectedItem.Equals("Meses"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf / 12;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = i1, Periodo = p1, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Anual") && cmbPeriodoAf.SelectedItem.Equals("Semestres"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf / 2;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = i1, Periodo = p1, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Anual") && cmbPeriodoAf.SelectedItem.Equals("Trimestres"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf / 4;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = i1, Periodo = p1, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Mensual") && cmbPeriodoAf.SelectedItem.Equals("Años"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf * 12;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = i1, Periodo = p1, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Mensual") && cmbPeriodoAf.SelectedItem.Equals("Meses"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = i1, Periodo = p1, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Mensual") && cmbPeriodoAf.SelectedItem.Equals("Semestres"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf * 6;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = i1, Periodo = p1, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Mensual") && cmbPeriodoAf.SelectedItem.Equals("Trimestres"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf * 3;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = i1, Periodo = p1, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Semestral") && cmbPeriodoAf.SelectedItem.Equals("Años"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf * 2;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = i1, Periodo = p1, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Semestral") && cmbPeriodoAf.SelectedItem.Equals("Meses"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf / 6;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = i1, Periodo = p1, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Semestral") && cmbPeriodoAf.SelectedItem.Equals("Semestres"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = i1, Periodo = p1, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Semestral") && cmbPeriodoAf.SelectedItem.Equals("Trimestres"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf / 2;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = i1, Periodo = p1, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Trimestral") && cmbPeriodoAf.SelectedItem.Equals("Años"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf * 4;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = i1, Periodo = p1, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Trimestral") && cmbPeriodoAf.SelectedItem.Equals("Meses"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf / 3;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = i1, Periodo = p1, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Trimestral") && cmbPeriodoAf.SelectedItem.Equals("Semestres"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf * 2;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = i1, Periodo = p1, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }
                        else if (cmbInteresAf.SelectedItem.Equals("Trimestral") && cmbPeriodoAf.SelectedItem.Equals("Trimestres"))
                        {
                            i1 = TasaInteresAf / 100;
                            p1 = PeriodoAf;
                            double AnualidadFuturo = ValorFuturoAf * (i1 / (Math.Pow(1 + i1, p1) - 1));
                            ResultadosAf.Add(new { Futuro = ValorFuturoAf, Interes = i1, Periodo = p1, Anualidad = AnualidadFuturo });
                            dgvResultadosAnualidadFuturo.DataSource = null;
                            dgvResultadosAnualidadFuturo.DataSource = ResultadosAf.ToList();
                        }

                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Rellene los campos necesarios" + ex);
                }
            }
            else if (rdbSiAnualidadAnticipadaAF.Checked == true)
            {
                var metodos8 = new Metodos();
                string interesFuturoAf = cmbInteresAf.SelectedItem?.ToString()?? string.Empty;
                string periodoFuturoAf = cmbPeriodoAf.SelectedItem?.ToString() ?? string.Empty;
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
