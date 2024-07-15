using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjEconomica.Formularios.formularios_Intereses
{
    public partial class FrmFuturoCompuesto : Form
    {
        public FrmFuturoCompuesto()
        {
            InitializeComponent();
        }

        private List<object> resultados = new List<object>();
        private void btnCal_Click(object sender, EventArgs e)
        {
            //SI en dado caso que quiera capitalizarlo
            if (rdbSi.Checked == true)
            {
                double p, i, n, f;
                double i1, n1, i2;

                try
                {
                    p = double.Parse(txtValorPresenteF.Text);
                    i1 = double.Parse(txtTasaInteresF.Text);
                    n1 = double.Parse(txtPeriodoF.Text);

                    if (cmbInteresF.SelectedItem != null && cmbPeriodoF.SelectedItem != null)
                    {
                        if (cmbInteresF.SelectedItem.Equals("Anual") && cmbPeriodoF.SelectedItem.Equals("Años"))
                        {
                            i = i1 / 100;
                            f = p * Math.Pow((1 + i), n1);


                            resultados.Add(new { Presente = p, Interes = i, Periodo = n1, Futuro = f });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();

                        }

                        else if (cmbInteresF.SelectedItem.Equals("Anual") && cmbPeriodoF.SelectedItem.Equals("Semestres"))
                        {
                            i = (i1 / 100);
                            n = n1 / 2;
                            f = p * Math.Pow((1 + i), n);


                            resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Anual") && cmbPeriodoF.SelectedItem.Equals("Trimestres"))
                        {
                            i = i1 / 100;
                            n = n1 / 4;
                            f = p * Math.Pow((1 + i), n);


                            resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        if (cmbInteresF.SelectedItem.Equals("Anual") && cmbPeriodoF.SelectedItem.Equals("Meses"))
                        {
                            i = i1 / 100;
                            n = n1 / 12;
                            f = p * Math.Pow((1 + i), n);


                            resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        // Cuando tenemos interes semestral con los diferentes periodos
                        else if (cmbInteresF.SelectedItem.Equals("Semestral") && cmbPeriodoF.SelectedItem.Equals("Años"))
                        {
                            i = (i1 / 100) / 2;
                            n = n1 * 2;
                            f = p * Math.Pow((1 + i), n);


                            resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Semestral") && cmbPeriodoF.SelectedItem.Equals("Semestres"))
                        {
                            i = (i1 / 100) / 2;
                            f = p * Math.Pow((1 + i), n1);


                            resultados.Add(new { Presente = p, Interes = i, Periodo = n1, Futuro = f });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Semestral") && cmbPeriodoF.SelectedItem.Equals("Trimestres"))
                        {
                            i = (i1 / 100) / 2;
                            n = n1 * 2;
                            f = p * Math.Pow((1 + i), n);


                            resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Semestral") && cmbPeriodoF.SelectedItem.Equals("Meses"))
                        {
                            i = (i1 / 100) / 2;
                            n = n1 / 6;
                            f = p * Math.Pow((1 + i), n);


                            resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        // Cuando tenemos interes trimestral con los diferentes periodos
                        else if (cmbInteresF.SelectedItem.Equals("Trimestral") && cmbPeriodoF.SelectedItem.Equals("Años"))
                        {
                            i = (i1 / 100) / 4;
                            n = n1 * 4;
                            f = p * Math.Pow((1 + i), n);


                            resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Trimestral") && cmbPeriodoF.SelectedItem.Equals("Semestres"))
                        {
                            i = (i1 / 100) / 4;
                            n = n1 * 2;
                            f = p * Math.Pow((1 + i), n);


                            resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Trimestral") && cmbPeriodoF.SelectedItem.Equals("Trimestres"))
                        {
                            i = (i1 / 100) / 4;
                            f = p * Math.Pow((1 + i), n1);


                            resultados.Add(new { Presente = p, Interes = i, Periodo = n1, Futuro = f });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Trimestral") && cmbPeriodoF.SelectedItem.Equals("Meses"))
                        {
                            i = (i1 / 100) / 4;
                            n = n1 / 3;
                            f = p * Math.Pow((1 + i), n);


                            resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        // Cuando tenemos interes mensual con los diferentes periodos
                        else if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Años"))
                        {
                            i = (i1 / 100) / 12;
                            n = n1 * 12;
                            f = p * Math.Pow((1 + i), n);


                            resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Semestres"))
                        {
                            i = (i1 / 100) / 12;
                            n = n1 * 6;
                            f = p * Math.Pow((1 + i), n);


                            resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Trimestres"))
                        {
                            i = (i1 / 100) / 12;
                            n = n1 * 3;
                            f = p * Math.Pow((1 + i), n);


                            resultados.Add(new { Presente = p, Interes = i, Periodo = n, Futuro = f });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                        else if (cmbInteresF.SelectedItem.Equals("Mensual") && cmbPeriodoF.SelectedItem.Equals("Meses"))
                        {
                            i = (i1 / 100) / 12;
                            f = p * Math.Pow((1 + i), n1);


                            resultados.Add(new { Presente = p, Interes = i, Periodo = n1, Futuro = f });

                            dgvResultadosFU.DataSource = null;
                            dgvResultadosFU.DataSource = resultados.ToList();
                        }

                    }
                }
                catch (FormatException x)
                {

                    MessageBox.Show("Rellene los campos necasarios");
                }
            } // NO en dado caso que no quiera capitalizarlo
            else if (rdbNo.Checked == true)
            {
                double Pno = double.Parse(txtValorPresenteF.Text);
                double Ino = double.Parse(txtTasaInteresF.Text);
                double Nno = double.Parse(txtPeriodoF.Text);
                double Fo;

                Fo = Pno * Math.Pow((1 + Ino / 100), Nno);

                resultados.Add(new { Presente = Pno, Interes = Ino, Periodo = Nno, Futuro = Fo });

                dgvResultadosFU.DataSource = null;
                dgvResultadosFU.DataSource = resultados.ToList();

            }

        }



        private void btnLim_Click(object sender, EventArgs e)
        {
            txtValorPresenteF.Clear();
            txtTasaInteresF.Clear();
            txtPeriodoF.Clear();
        }

        private void txtPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTasaInteres_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void txtpe_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void txtVp_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmFuturoCompuesto_Load(object sender, EventArgs e)
        {

        }
    }
}
