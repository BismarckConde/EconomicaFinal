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

namespace PjEconomica.Formularios.Formularios_Anualidades.Anualidades_Vencidas
{
    public partial class FrmpresenVenci : Form
    {
        
        public FrmpresenVenci()
        {
            InitializeComponent();
           
        }
        private List<object> ResultadosPresente = new List<object>();
        private void btnCal_Click(object sender, EventArgs e)
        {
            int Anualidad, Periodo, p1;
            double Interes, i1;
            if (rdbNoFuturo.Checked == true)
            {
                try
                {
                    Anualidad = Convert.ToInt32(txtValorAnualidadPresente.Text);
                    i1 = Convert.ToDouble(txtTasaInteresAnualidadPresente.Text);
                    p1 = Convert.ToInt32(txtPeriodoAnualidadPresente.Text);
                    if (cmbInteresAnualidadPresente.SelectedItem != null && cmbPeriodoAnualidadPresente.SelectedItem != null)
                    {
                        if (cmbInteresAnualidadPresente.SelectedItem.Equals("Anual") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Años"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1;


                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Anual") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Meses"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 / 12;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Anual") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Semestres"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 / 2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Anual") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Trimestres"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 / 4;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        //Fin de interes anual
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Mensual") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Años"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 * 12;


                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Mensual") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Meses"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1;


                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Mensual") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Semestres"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 * 6;


                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Mensual") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Trimestres"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 * 3;


                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        //Fin de Interes Mensual
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Semestral") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Años"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 * 2;


                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Semestral") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Meses"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 / 6;


                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Semestral") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Semestres"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1;
                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Semestral") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Trimestres"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 / 2;


                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        // Fin de Tasa Interes Semestral
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Años"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 * 4;
                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Meses"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 / 3;
                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Semestres"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1 * 2;


                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresAnualidadPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoAnualidadPresente.SelectedItem.Equals("Trimestres"))
                        {
                            Interes = i1 / 100;
                            Periodo = p1;
                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo))));
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, PeriodoP = Periodo, Presente = P });
                            dgvResultadosPresente.DataSource = null;
                            dgvResultadosPresente.DataSource = ResultadosPresente.ToList();
                        }
                        //Fin Tasa Interes Trimestral
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Rellene los campos necesarios" + ex);
                }
            }
            else if (rdbSiFuturo.Checked == true)
            {
                var metodo3 = new Metodos();
                string interesPresente = cmbInteresAnualidadPresente.SelectedItem?.ToString()?? string.Empty;
                string periodoPresente = cmbPeriodoAnualidadPresente.SelectedItem?.ToString()?? string.Empty;
                double TasaperiodoPresente = Convert.ToDouble(txtTasaInteresAnualidadPresente.Text);
                double valorAnualidadPresente = Convert.ToDouble(txtValorAnualidadPresente.Text);
                int periodo1Presente = Convert.ToInt32(txtPeriodoAnualidadPresente.Text);
                metodo3.CalcularPresenteVencida(interesPresente, periodoPresente, TasaperiodoPresente, valorAnualidadPresente, periodo1Presente, ResultadosPresente, dgvResultadosPresente);
            }
        }

       

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtValorAnualidadPresente.Clear();
            txtTasaInteresAnualidadPresente.Clear();
            txtPeriodoAnualidadPresente.Clear();
           
        }
    }
}
