using DocumentFormat.OpenXml.Office2021.DocumentTasks;
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
    public partial class FrmPresenteCompuesto : Form
    {
        public FrmPresenteCompuesto()
        {
            InitializeComponent();
        }
        private List<object> resultados = new List<object>();
        private void btnCal_Click(object sender, EventArgs e)
        {
            // SI en dado caso que quiera capitalizar
            if (rdbSi1.Checked == true)
            {
                double p, i, n, f;
                double i1, n1, i2;

                try
                {
                    f = double.Parse(txtValorFuturoP.Text);
                    i1 = double.Parse(txtTasaInteresP.Text);
                    n1 = double.Parse(txtPeriodoP.Text);

                    if (cmbInteresP.SelectedItem != null && cmbPeriodoP.SelectedItem != null)
                    {
                        if (cmbInteresP.SelectedItem.Equals("Anual") && cmbPeriodoP.SelectedItem.Equals("Años"))
                        {
                            i = i1 / 100;
                            p = f / (Math.Pow((1 + i), n1));


                            resultados.Add(new { Futuro = f, Interes = i, Periodo = n1, Presente = p });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultados.ToList();

                        }

                        else if (cmbInteresP.SelectedItem.Equals("Anual") && cmbPeriodoP.SelectedItem.Equals("Semestres"))
                        {
                            i = i1 / 100;
                            n = n1 / 2;
                            p = f / (Math.Pow((1 + i), n));


                            resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Anual") && cmbPeriodoP.SelectedItem.Equals("Trimestres"))
                        {
                            i = i1 / 100;
                            n = n1 / 4;
                            p = f / (Math.Pow((1 + i), n));


                            resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultados.ToList();
                        }

                        if (cmbInteresP.SelectedItem.Equals("Anual") && cmbPeriodoP.SelectedItem.Equals("Meses"))
                        {
                            i = i1 / 100;
                            n = n1 / 12;
                            p = f / (Math.Pow((1 + i), n));


                            resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultados.ToList();
                        }

                        // Cuando tenemos interes semestral con los diferentes periodos
                        else if (cmbInteresP.SelectedItem.Equals("Semestral") && cmbPeriodoP.SelectedItem.Equals("Años"))
                        {
                            i = (i1 / 100) / 2;
                            n = n1 * 2;
                            p = f / (Math.Pow((1 + i), n));


                            resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Semestral") && cmbPeriodoP.SelectedItem.Equals("Semestres"))
                        {
                            i = (i1 / 100) / 2;
                            p = f / (Math.Pow((1 + i), n1));


                            resultados.Add(new { Futuro = f, Interes = i, Periodo = n1, Presente = p });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Semestral") && cmbPeriodoP.SelectedItem.Equals("Trimestres"))
                        {
                            i = (i1 / 100) / 2;
                            n = n1 * 2;
                            p = f / (Math.Pow((1 + i), n));


                            resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Semestral") && cmbPeriodoP.SelectedItem.Equals("Meses"))
                        {
                            i = (i1 / 100) / 2;
                            n = n1 / 6;
                            p = f / (Math.Pow((1 + i), n));


                            resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultados.ToList();
                        }

                        // Cuando tenemos interes trimestral con los diferentes periodos
                        else if (cmbInteresP.SelectedItem.Equals("Trimestral") && cmbPeriodoP.SelectedItem.Equals("Años"))
                        {
                            i = (i1 / 100) / 4;
                            n = n1 * 4;
                            p = f / (Math.Pow((1 + i), n));


                            resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Trimestral") && cmbPeriodoP.SelectedItem.Equals("Semestres"))
                        {
                            i = (i1 / 100) / 4;
                            n = n1 * 2;
                            p = f / (Math.Pow((1 + i), n));


                            resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Trimestral") && cmbPeriodoP.SelectedItem.Equals("Trimestres"))
                        {
                            i = (i1 / 100) / 4;
                            p = f / (Math.Pow((1 + i), n1));


                            resultados.Add(new { Futuro = f, Interes = i, Periodo = n1, Presente = p });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Trimestral") && cmbPeriodoP.SelectedItem.Equals("Meses"))
                        {
                            i = (i1 / 100) / 4;
                            n = n1 / 3;
                            p = f / (Math.Pow((1 + i), n));


                            resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultados.ToList();
                        }

                        // Cuando tenemos interes mensual con los diferentes periodos
                        else if (cmbInteresP.SelectedItem.Equals("Mensual") && cmbPeriodoP.SelectedItem.Equals("Años"))
                        {
                            i = (i1 / 100) / 12;
                            n = n1 * 12;
                            p = f / (Math.Pow((1 + i), n));


                            resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Mensual") && cmbPeriodoP.SelectedItem.Equals("Semestres"))
                        {
                            i = (i1 / 100) / 12;
                            n = n1 * 6;
                            p = f / (Math.Pow((1 + i), n));


                            resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Mensual") && cmbPeriodoP.SelectedItem.Equals("Trimestres"))
                        {
                            i = (i1 / 100) / 12;
                            n = n1 * 3;
                            p = f / (Math.Pow((1 + i), n));


                            resultados.Add(new { Futuro = f, Interes = i, Periodo = n, Presente = p });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresP.SelectedItem.Equals("Mensual") && cmbPeriodoP.SelectedItem.Equals("Meses"))
                        {
                            i = (i1 / 100) / 12;
                            p = f / (Math.Pow((1 + i), n1));


                            resultados.Add(new { Futuro = f, Interes = i, Periodo = n1, Presente = p });

                            dgvResultadosP.DataSource = null;
                            dgvResultadosP.DataSource = resultados.ToList();
                        }

                    }
                }
                catch (FormatException x)
                {

                    MessageBox.Show("Rellene los campos necasarios");
                }
            } // NO en dado caso que no desea capitalizar
            else if (rdbNo1.Checked == true)
            {
                double Fno = double.Parse(txtValorFuturoP.Text);
                double Ino = double.Parse(txtTasaInteresP.Text);
                double Nno = double.Parse(txtPeriodoP.Text);
                double P;
                double Int = Ino / 100;

                P = Fno / (Math.Pow((1 + Int), Nno));


                resultados.Add(new { Futuro = Fno, Interes = Int, Periodo = Nno, Presente = P });

                dgvResultadosP.DataSource = null;
                dgvResultadosP.DataSource = resultados.ToList();
            }
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtValorFuturoP.Clear();
            txtTasaInteresP.Clear();
            txtPeriodoP.Clear();
        }
    }
}
