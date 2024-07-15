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

namespace PjEconomica.Formularios.formularios_Intereses
{
    public partial class FrmFuturo : Form
    {

        public List<InteresSimpleF> Fs = new List<InteresSimpleF>();
        public List<InteresSimpleP> Ps = new List<InteresSimpleP>();
        public List<InteresSimpleI> Is = new List<InteresSimpleI>();
        public List<InteresSimpleN> Ns = new List<InteresSimpleN>();
        public FrmFuturo()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {

            try
            {
                int ValorPresenteFu = Convert.ToInt32(txtValorPresenteF.Text);
                double TasaInteresFu = Convert.ToDouble(txtTasaInteresF.Text);
                double PeriodoFu = Convert.ToDouble(txtPeriodoF.Text);
                double Futuro = ValorPresenteFu * (1 + (TasaInteresFu * PeriodoFu));
                if (cmbInteresSimple.SelectedItem != null && cmbPeriodoSimple.SelectedItem != null)
                {
                    if (cmbInteresSimple.SelectedItem.Equals("Anual") && cmbPeriodoSimple.SelectedItem.Equals("Meses"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToDouble(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu / 12)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Anual") && cmbPeriodoSimple.SelectedItem.Equals("Años"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToDouble(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Anual") && cmbPeriodoSimple.SelectedItem.Equals("Semestres"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToDouble(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu / 2)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Anual") && cmbPeriodoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToDouble(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu / 4)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Mensual") && cmbPeriodoSimple.SelectedItem.Equals("Años"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToDouble(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu * 12)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Mensual") && cmbPeriodoSimple.SelectedItem.Equals("Meses"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToDouble(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Mensual") && cmbPeriodoSimple.SelectedItem.Equals("Semestres"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToDouble(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu * 6)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Mensual") && cmbPeriodoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToDouble(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu * 3)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Semestral") && cmbPeriodoSimple.SelectedItem.Equals("Años"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToDouble(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu * 2)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Semestral") && cmbPeriodoSimple.SelectedItem.Equals("Meses"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToDouble(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu / 6)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Semestral") && cmbPeriodoSimple.SelectedItem.Equals("Semestres"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToDouble(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Semestral") && cmbPeriodoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToDouble(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu / 2)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoSimple.SelectedItem.Equals("Años"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToDouble(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu * 4)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoSimple.SelectedItem.Equals("Meses"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToDouble(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu / 3)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoSimple.SelectedItem.Equals("Semestres"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToDouble(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu * 2)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                    else if (cmbInteresSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        Fs.Add(new InteresSimpleF
                        {
                            ValorPresenteF = Convert.ToInt32(txtValorPresenteF.Text),
                            TasaInteresF = Convert.ToDouble(txtTasaInteresF.Text),
                            PeriodoF = Convert.ToDouble(txtPeriodoF.Text),
                            Futuro = ValorPresenteFu * (1 + TasaInteresFu / 100 * PeriodoFu * 2)
                        });
                        dgvResultadosF.DataSource = null;
                        dgvResultadosF.DataSource = Fs;
                    }
                }

            }
            catch (FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios");
            }
        }
        private void btnLim_Click(object sender, EventArgs e)
        {
            txtPeriodoF.Clear();
            txtTasaInteresF.Clear();
            txtValorPresenteF.Clear();
        }

        private void dgvResultadosF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
