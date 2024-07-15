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
    public partial class FrmPreDife : Form
    {
       
        public FrmPreDife()
        {
            InitializeComponent();
            
        }

        List<object> ResultadosPresente = new List<object>();
        private void btnCal_Click(object sender, EventArgs e)
        {

            int Periodo1, Periodo2, p1, p2;
            double Anualidad;
            double Interes, i1, i2;
            if (rdbno.Checked == true)
            {
                try
                {
                    Anualidad = Convert.ToDouble(txtValorAnualidadPresente.Text);
                    i1 = Convert.ToDouble(txttasa.Text);
                    p1 = Convert.ToInt32(txtp1.Text);
                    p2 = Convert.ToInt32(txtp2.Text);

                    if (cmbInteresPresente.SelectedItem != null && cmbPeriodoPresente.SelectedItem != null && cmbPeriodoPresente2.SelectedItem != null)
                    {
                        if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Años") && cmbPeriodoPresente2.SelectedItem.Equals("Años"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Meses") && cmbPeriodoPresente2.SelectedItem.Equals("Meses"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 / 12;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Semestres") && cmbPeriodoPresente2.SelectedItem.Equals("Semestres"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 / 2;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Anual") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres") && cmbPeriodoPresente2.SelectedItem.Equals("Trimestres"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 / 4;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = ResultadosPresente.ToList();
                        }
                        //Fin de interes anual
                        else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Años") && cmbPeriodoPresente2.SelectedItem.Equals("Años"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 * 12;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Meses") && cmbPeriodoPresente2.SelectedItem.Equals("Meses"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Semestres") && cmbPeriodoPresente2.SelectedItem.Equals("Semestres"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 * 6;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Mensual") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres") && cmbPeriodoPresente2.SelectedItem.Equals("Trimestres"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 * 3;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = ResultadosPresente.ToList();
                        }
                        //Fin de Interes Mensual
                        else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Años") && cmbPeriodoPresente2.SelectedItem.Equals("Años"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 * 2;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Meses") && cmbPeriodoPresente2.SelectedItem.Equals("Meses"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 / 6;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Semestres") && cmbPeriodoPresente2.SelectedItem.Equals("Semestres"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Semestral") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres") && cmbPeriodoPresente2.SelectedItem.Equals("Trimestres"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 / 2;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = ResultadosPresente.ToList();
                        }
                        // Fin de Tasa Interes Semestral
                        else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Años") && cmbPeriodoPresente2.SelectedItem.Equals("Años"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 * 4;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Meses") && cmbPeriodoPresente2.SelectedItem.Equals("Meses"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 / 3;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Meses") && cmbPeriodoPresente2.SelectedItem.Equals("Meses"))
                        {
                            Interes = i1 / 100;
                            Periodo1 = p1 * 2;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = ResultadosPresente.ToList();
                        }
                        else if (cmbInteresPresente.SelectedItem.Equals("Trimestral") && cmbPeriodoPresente.SelectedItem.Equals("Trimestres") && cmbPeriodoPresente2.SelectedItem.Equals("Trimestres"))
                        {

                            Interes = i1 / 100;
                            Periodo1 = p1;
                            Periodo2 = p2;

                            double P = (Anualidad * (Math.Pow((1 + Interes), (Periodo1 - Periodo2)) - 1) / (Interes * Math.Pow((1 + Interes), (Periodo1 - Periodo2)))) * Math.Pow((1 + Interes), -Periodo2);
                            ResultadosPresente.Add(new { AnualidadP = Anualidad, InteresP = Interes, Periodo1P = Periodo1, Periodo2P = Periodo2, Presente = P });
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = ResultadosPresente.ToList();
                        }
                        //Fin Tasa Interes Trimestral
                    }

                }
                catch (FormatException x)
                {
                    MessageBox.Show("Rellene los campos necesarios" + x);
                }
            }
            else if (rdbSi.Checked == true)
            {
                var metodos2 = new Metodos();
                string InteresPresente = cmbInteresPresente.SelectedItem?.ToString()?? string.Empty;
                string PeriodoPresente = cmbPeriodoPresente.SelectedItem?.ToString()?? string.Empty;
                double TasaInteresPresente = Convert.ToDouble(txttasa.Text);
                double ValorAnualidadPresente = Convert.ToDouble(txtValorAnualidadPresente.Text);
                int Periodo1Futuro = Convert.ToInt32(txtp1.Text);
                int Periodo2Futuro = Convert.ToInt32(txtp2.Text);

                // metodos2.CalcularPresente(InteresPresente, PeriodoPresente, TasaInteresPresente, ValorAnualidadPresente, Periodo1Futuro, Periodo2Futuro);
                metodos2.CalcularPresente(InteresPresente, PeriodoPresente, TasaInteresPresente, ValorAnualidadPresente, Periodo1Futuro, Periodo2Futuro, ResultadosPresente, dataGridView1);
            }
        }

        

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtValorAnualidadPresente.Clear();
            txttasa.Clear();
            txtp1.Clear();
            txtp2.Clear();
          
        }
    }
}
