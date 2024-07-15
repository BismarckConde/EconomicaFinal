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

namespace PjEconomica.Formularios.Formularios_Anualidades.Anualidad_Anticipada
{
    public partial class FrmPresenteAnual : Form
    {

        public FrmPresenteAnual()
        {
            InitializeComponent();

        }

        List<object> ResultadosPresente = new List<object>();
        private void btnCal_Click(object sender, EventArgs e)
        {

            if (rdbNoFuturo.Checked == true)
            {
                try
                {
                    double ValorAnualidadPresente, Interes, i1, AnualidadPresente;
                    int periodo1, p1;

                    ValorAnualidadPresente = Convert.ToDouble(txtanu.Text);
                    i1 = Convert.ToDouble(txttasa.Text);
                    p1 = Convert.ToInt32(txtperi.Text);
                    if (cmbInteresPresente.SelectedItem != null && cmbPeriodoPresente.SelectedItem != null)
                    {
                        if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                        {
                            Interes = i1 / 100;
                            periodo1 = p1;
                            AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();


                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                        {

                            Interes = i1 / 100;
                            periodo1 = p1 / 12;
                            AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                        {

                            Interes = i1 / 100;
                            periodo1 = p1 / 2;
                            AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                        {

                            Interes = i1 / 100;
                            periodo1 = p1 / 4;
                            AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                        {

                            Interes = i1 / 100;
                            periodo1 = p1 * 12;
                            AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                        {

                            Interes = i1 / 100;
                            periodo1 = p1;
                            AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                        {

                            Interes = i1 / 100;
                            periodo1 = p1 * 6;
                            AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                        {

                            Interes = i1 / 100;
                            periodo1 = p1 * 3;
                            AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                        {

                            Interes = i1 / 100;
                            periodo1 = p1 * 2;
                            AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                        {

                            Interes = i1 / 100;
                            periodo1 = p1 / 6;
                            AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                        {

                            Interes = i1 / 100;
                            periodo1 = p1;
                            AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                        {

                            Interes = i1 / 100;
                            periodo1 = p1 / 2;
                            AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Años"))
                        {

                            Interes = i1 / 100;
                            periodo1 = p1 * 4;
                            AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Meses"))
                        {

                            Interes = i1 / 100;
                            periodo1 = p1 / 3;
                            AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Semestres"))
                        {

                            Interes = i1 / 100;
                            periodo1 = p1 * 2;
                            AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres"))
                        {

                            Interes = i1 / 100;
                            periodo1 = p1;
                            AnualidadPresente = ValorAnualidadPresente + ValorAnualidadPresente * ((Math.Pow(1 + Interes, periodo1 - 1) - 1) / (Interes * Math.Pow(1 + Interes, periodo1 - 1)));
                            ResultadosPresente.Add(new { Anualidad = ValorAnualidadPresente, Interes = Interes, Periodo = periodo1, Presente = AnualidadPresente });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                    }
                }
                catch (FormatException x)
                {
                    MessageBox.Show("Rellene los campos necesarios " + x);
                }
            }
            else if (rdbSiFuturo.Checked == true)
            {
                var metodo3 = new Metodos();
                string interesPresente = cmbInteresPresente.SelectedItem?.ToString()?? string.Empty;
                string periodoPresente = cmbPeriodoPresente.SelectedItem?.ToString()?? string.Empty;
                double TasaperiodoPresente = Convert.ToDouble(txttasa.Text);
                double valorAnualidadPresente = Convert.ToDouble(txtanu.Text);
                int periodo1Presente = Convert.ToInt32(txtperi.Text);
                metodo3.CalcularPresenteAnticipado(interesPresente, periodoPresente, TasaperiodoPresente, valorAnualidadPresente, periodo1Presente, ResultadosPresente, dgvResultadosPresente);
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





