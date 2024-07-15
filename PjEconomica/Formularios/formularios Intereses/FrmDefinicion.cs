using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjEconomica.Formularios.formularios_Intereses
{
    public partial class FrmDefinicion : Form
    {
        public FrmDefinicion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmIntereses frmIntereses = new FrmIntereses();
            frmIntereses.ShowDialog();
        }

        private List<object> ResultadosAcumulado = new List<object>();
        private void button2_Click(object sender, EventArgs e)
        {

            double P, i = 0, I = 0, n = 0;
            double i1, n1;
            P = double.Parse(txtValorPresente.Text);
            i1 = double.Parse(txtTasaInteres.Text);
            n1 = double.Parse(txtPeriodo.Text);

            try
            {
                if (cmbInteresAcum.SelectedItem != null && cmbPeriodoAcum.SelectedItem != null)
                {
                    if (cmbInteresAcum.SelectedItem.Equals("Anual") && cmbPeriodoAcum.SelectedItem.Equals("Años"))
                    {
                        n = n1;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Anual") && cmbPeriodoAcum.SelectedItem.Equals("Meses"))
                    {
                        n = n1;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Anual") && cmbPeriodoAcum.SelectedItem.Equals("Semestres"))
                    {
                        n = (int)(n1 * 0.5);
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Anual") && cmbPeriodoAcum.SelectedItem.Equals("Trimestres"))
                    {
                        n = n1 / 4;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Mensual") && cmbPeriodoAcum.SelectedItem.Equals("Años"))
                    {
                        n = n1 * 12;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Mensual") && cmbPeriodoAcum.SelectedItem.Equals("Meses"))
                    {
                        n = n1;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Mensual") && cmbPeriodoAcum.SelectedItem.Equals("Semestres"))
                    {
                        n = n1 * 6;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Mensual") && cmbPeriodoAcum.SelectedItem.Equals("Trimestres"))
                    {
                        n = n1 * 3;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Semestral") && cmbPeriodoAcum.SelectedItem.Equals("Años"))
                    {
                        n = n1 * 2;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Semestral") && cmbPeriodoAcum.SelectedItem.Equals("Meses"))
                    {
                        n = n1 / 6;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Semestral") && cmbPeriodoAcum.SelectedItem.Equals("Semestres"))
                    {
                        n = n1;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Semestral") && cmbPeriodoAcum.SelectedItem.Equals("Trimestral"))
                    {
                        n = n1 / 2;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Trimestral") && cmbPeriodoAcum.SelectedItem.Equals("Años"))
                    {
                        n = n1 * 4;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Trimestral") && cmbPeriodoAcum.SelectedItem.Equals("Meses"))
                    {
                        n = n1 / 3;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Trimestral") && cmbPeriodoAcum.SelectedItem.Equals("Semestres"))
                    {
                        n = n1 * 2;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                    else if (cmbInteresAcum.SelectedItem.Equals("Trimestral") && cmbPeriodoAcum.SelectedItem.Equals("Trimestres"))
                    {
                        n = n1;
                        i = i1 / 100;
                        I = P * i * n;

                        ResultadosAcumulado.Add(new { Presente = P, Periodo = n, Interes = i, TasaInteres = I });

                        dtgvResultadosAcumulados.DataSource = null;
                        dtgvResultadosAcumulados.DataSource = ResultadosAcumulado;
                    }
                }
            }
            catch (FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPeriodo.Clear();
            txtTasaInteres.Clear();
            txtValorPresente.Clear();
        }
    }
}

