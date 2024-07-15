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
    public partial class FrmAnualidadPre : Form
    {
        
        public FrmAnualidadPre()
        {
            InitializeComponent();
           
        }

        List<object> ResultadosAp = new List<object>();
        private void btnCal_Click(object sender, EventArgs e)
        {
            double i1;
            int p1;
            double valorPresenteAp = Convert.ToDouble(txtVP.Text);
            double TasaInteresAp = Convert.ToDouble(txttasa.Text);
            int PeriodoAp = Convert.ToInt32(txtperi.Text);
            //double AnualidadPresente = valorPresenteAp * ((TasaInteresAp * Math.Pow(1 + TasaInteresAp, PeriodoAp)) / (Math.Pow(1 + TasaInteresAp, PeriodoAp) - 1));
            if (rdbNoFuturo.Checked == true)
            {

                if (cmbInteresAnualidadF.SelectedItem != null && cmbPeriodoFuturo.SelectedItem != null)
                {
                    if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp * 2;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        ResultadosAp.Add(new { ValorPresente = valorPresenteAp, Interes = i1, Periodo = p1, Anualidad = AnualidadPresente });
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ResultadosAp.ToList();

                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp / 6;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        ResultadosAp.Add(new { ValorPresente = valorPresenteAp, Interes = i1, Periodo = p1, Anualidad = AnualidadPresente });
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        ResultadosAp.Add(new { ValorPresente = valorPresenteAp, Interes = i1, Periodo = p1, Anualidad = AnualidadPresente });
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Semestral") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp / 2;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        ResultadosAp.Add(new { ValorPresente = valorPresenteAp, Interes = i1, Periodo = p1, Anualidad = AnualidadPresente });
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        ResultadosAp.Add(new { ValorPresente = valorPresenteAp, Interes = i1, Periodo = p1, Anualidad = AnualidadPresente });
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp / 12;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        ResultadosAp.Add(new { ValorPresente = valorPresenteAp, Interes = i1, Periodo = p1, Anualidad = AnualidadPresente });
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp / 2;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        ResultadosAp.Add(new { ValorPresente = valorPresenteAp, Interes = i1, Periodo = p1, Anualidad = AnualidadPresente });
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Anual") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp / 4;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        ResultadosAp.Add(new { ValorPresente = valorPresenteAp, Interes = i1, Periodo = p1, Anualidad = AnualidadPresente });
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ResultadosAp.ToList();
                    }

                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp * 12;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        ResultadosAp.Add(new { ValorPresente = valorPresenteAp, Interes = i1, Periodo = p1, Anualidad = AnualidadPresente });
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        ResultadosAp.Add(new { ValorPresente = valorPresenteAp, Interes = i1, Periodo = p1, Anualidad = AnualidadPresente });
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp * 6;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        ResultadosAp.Add(new { ValorPresente = valorPresenteAp, Interes = i1, Periodo = p1, Anualidad = AnualidadPresente });
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Mensual") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp * 3;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        ResultadosAp.Add(new { ValorPresente = valorPresenteAp, Interes = i1, Periodo = p1, Anualidad = AnualidadPresente });
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Años"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp * 4;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        dataGridView1.DataSource = null;
                        ResultadosAp.Add(new { ValorPresente = valorPresenteAp, Interes = i1, Periodo = p1, Anualidad = AnualidadPresente });
                        dataGridView1.DataSource = ResultadosAp.ToList();
                    }

                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Meses"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp / 3;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        ResultadosAp.Add(new { ValorPresente = valorPresenteAp, Interes = i1, Periodo = p1, Anualidad = AnualidadPresente });
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Semestres"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp * 2;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        ResultadosAp.Add(new { ValorPresente = valorPresenteAp, Interes = i1, Periodo = p1, Anualidad = AnualidadPresente });
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ResultadosAp.ToList();
                    }
                    else if (cmbInteresAnualidadF.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturo.SelectedItem.Equals("Trimestres"))
                    {
                        i1 = TasaInteresAp / 100;
                        p1 = PeriodoAp;
                        double AnualidadPresente = valorPresenteAp * ((i1 * Math.Pow(1 + i1, p1)) / (Math.Pow(1 + i1, p1) - 1));
                        ResultadosAp.Add(new { ValorPresente = valorPresenteAp, Interes = i1, Periodo = p1, Anualidad = AnualidadPresente });
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = ResultadosAp.ToList();
                    }
                }
            }
            else if (rdbSiFuturo.Checked == true)
            {
                var metodo9 = new Metodos();
                string interesPresenteAp = cmbInteresAnualidadF.SelectedItem?.ToString()?? string.Empty;
                string periodoPresenteAp = cmbPeriodoFuturo.SelectedItem?.ToString() ?? string.Empty;
                double TasaInteresPresente = Convert.ToDouble(txttasa.Text);
                double valorPresenteAp2 = Convert.ToDouble(txtVP.Text);
                int periodoAp = Convert.ToInt32(txtperi.Text);

                metodo9.AnualidadPresente(interesPresenteAp, periodoPresenteAp, TasaInteresPresente, valorPresenteAp2, periodoAp, ResultadosAp, dataGridView1);
            }
        }


        private void btnLim_Click(object sender, EventArgs e)
        {
            txtVP.Clear();
            txttasa.Clear();
            txtperi.Clear();
            
        }
    }
}
