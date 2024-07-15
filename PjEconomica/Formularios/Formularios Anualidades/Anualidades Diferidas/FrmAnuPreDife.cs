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
    public partial class FrmAnuPreDife : Form
    {
       
        public FrmAnuPreDife()
        {
            InitializeComponent();
       
        }
        List<object> ResultadosAp = new List<object>();
        private void btnCal_Click(object sender, EventArgs e)
        {
            int Periodo, n;
            double TasaInteres, i1, Presente;
            if (rdbno.Checked == true)
            //Presente
            {
                try
                {
                    Presente = Convert.ToDouble(txtValorPresenteAnualidadVencida.Text);
                    i1 = Convert.ToDouble(txtInteresAnualidadVencida.Text);
                    n = Convert.ToInt32(txtPeriodoAnualidadVencida.Text);

                    if (cmbInteresA.SelectedItem != null && cmbPeriodoA.SelectedItem != null)
                    {
                        if (cmbInteresA.SelectedItem.Equals("Anual") && cmbPeriodoA.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n;
                            double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                            dgvResultadosAnualidadPresente.DataSource = null;
                            dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                        }
                        else if (cmbInteresA.SelectedItem.Equals("Anual") && cmbPeriodoA.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n / 12;
                            double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                            dgvResultadosAnualidadPresente.DataSource = null;
                            dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                        }
                        else if (cmbInteresA.SelectedItem.Equals("Anual") && cmbPeriodoA.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n / 2;
                            double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                            dgvResultadosAnualidadPresente.DataSource = null;
                            dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                        }
                        else if (cmbInteresA.SelectedItem.Equals("Anual") && cmbPeriodoA.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n / 4;
                            double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                            dgvResultadosAnualidadPresente.DataSource = null;
                            dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                        }
                        //Fin de interes anual 
                        else if (cmbInteresA.SelectedItem.Equals("Mensual") && cmbPeriodoA.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n * 12;
                            double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                            dgvResultadosAnualidadPresente.DataSource = null;
                            dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                        }
                        else if (cmbInteresA.SelectedItem.Equals("Mensual") && cmbPeriodoA.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n;
                            double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                            dgvResultadosAnualidadPresente.DataSource = null;
                            dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                        }
                        else if (cmbInteresA.SelectedItem.Equals("Mensual") && cmbPeriodoA.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n * 6;
                            double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                            dgvResultadosAnualidadPresente.DataSource = null;
                            dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                        }
                        else if (cmbInteresA.SelectedItem.Equals("Mensual") && cmbPeriodoA.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n * 3;
                            double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                            dgvResultadosAnualidadPresente.DataSource = null;
                            dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                        }
                        else if (cmbInteresA.SelectedItem.Equals("Semestral") && cmbPeriodoA.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n * 2;
                            double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                            dgvResultadosAnualidadPresente.DataSource = null;
                            dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                        }
                        else if (cmbInteresA.SelectedItem.Equals("Semestral") && cmbPeriodoA.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n / 6;
                            double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                            dgvResultadosAnualidadPresente.DataSource = null;
                            dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                        }
                        else if (cmbInteresA.SelectedItem.Equals("Semestral") && cmbPeriodoA.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n;
                            double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                            dgvResultadosAnualidadPresente.DataSource = null;
                            dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                        }
                        else if (cmbInteresA.SelectedItem.Equals("Semestral") && cmbPeriodoA.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n / 2;
                            double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                            dgvResultadosAnualidadPresente.DataSource = null;
                            dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                        }
                        else if (cmbInteresA.SelectedItem.Equals("Trimestral") && cmbPeriodoA.SelectedItem.Equals("Años"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n * 4;
                            double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                            dgvResultadosAnualidadPresente.DataSource = null;
                            dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                        }
                        else if (cmbInteresA.SelectedItem.Equals("Trimestral") && cmbPeriodoA.SelectedItem.Equals("Meses"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n / 3;
                            double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                            dgvResultadosAnualidadPresente.DataSource = null;
                            dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                        }
                        else if (cmbInteresA.SelectedItem.Equals("Trimestral") && cmbPeriodoA.SelectedItem.Equals("Semestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n * 2;
                            double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                            dgvResultadosAnualidadPresente.DataSource = null;
                            dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
                        }
                        else if (cmbInteresA.SelectedItem.Equals("Trimestral") && cmbPeriodoA.SelectedItem.Equals("Trimestres"))
                        {
                            TasaInteres = i1 / 100;
                            Periodo = n;
                            double AnualidadPresente = Presente * ((TasaInteres * Math.Pow(1 + TasaInteres, Periodo)) / (Math.Pow(1 + TasaInteres, Periodo) - 1));

                            ResultadosAp.Add(new { ValorPresente = Presente, Interes = TasaInteres, Periodo = Periodo, Anualidad = AnualidadPresente });
                            dgvResultadosAnualidadPresente.DataSource = null;
                            dgvResultadosAnualidadPresente.DataSource = ResultadosAp.ToList();
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
                var metodos6 = new Metodos();
                string interesPresenteAp = cmbInteresA.SelectedItem?.ToString()?? string.Empty;
                string periodoPresenteAp = cmbPeriodoA.SelectedItem?.ToString()?? string.Empty;
                double TasaInteresPresenteAp = Convert.ToDouble(txtInteresAnualidadVencida.Text);
                double valorPresenteAp = Convert.ToDouble(txtValorPresenteAnualidadVencida.Text);
                int periodo1Ap = Convert.ToInt32(txtPeriodoAnualidadVencida.Text);

                metodos6.AnualidadPresente(interesPresenteAp, periodoPresenteAp, TasaInteresPresenteAp, valorPresenteAp, periodo1Ap, ResultadosAp, dgvResultadosAnualidadPresente);
            }
        }


        private void btnLim_Click(object sender, EventArgs e)
        {
            txtValorPresenteAnualidadVencida.Clear();
            txtInteresAnualidadVencida.Clear();
            txtPeriodoAnualidadVencida.Clear();
           
        }
    }
}
