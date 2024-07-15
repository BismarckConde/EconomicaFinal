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
    public partial class FrmPresente : Form
    {
        public List<InteresSimpleP> Ps = new List<InteresSimpleP>();
        public FrmPresente()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {

            try
            {
                int ValorFuturoPe = Convert.ToInt32(txtValorFuturoP.Text);
                double TasaInteresPe = Convert.ToDouble(txtTasaInteresP.Text);
                double PeriodoPe = Convert.ToDouble(txtPeriodoP.Text);
                double Presente = ValorFuturoPe / 1 + (TasaInteresPe * PeriodoPe);

                if (cmbInteresFuturoSimple.SelectedItem != null && cmbPeriodoFuturoSimple.SelectedItem != null)
                {
                    if (cmbInteresFuturoSimple.SelectedItem.Equals("Anual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Años"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToDouble(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Anual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Meses"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToDouble(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe / 12)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Anual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Semestres"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToDouble(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe / 2)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Anual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToDouble(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe / 4)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Mensual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Años"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToDouble(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe * 12)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Mensual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Meses"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToDouble(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Mensual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Semestres"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToDouble(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe * 6)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Mensual") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToDouble(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe * 3)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Semestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Años"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToDouble(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe * 2)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Semestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Meses"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToDouble(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe / 6)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Semestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Semestres"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToDouble(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe * 2)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Semestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Trimestres"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToDouble(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe / 2)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Años"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToDouble(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe * 4)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Meses"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToDouble(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe / 3)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Semestres"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToDouble(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe * 2)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
                    }
                    else if (cmbInteresFuturoSimple.SelectedItem.Equals("Trimestral") && cmbPeriodoFuturoSimple.SelectedItem.Equals("Años"))
                    {
                        Ps.Add(new InteresSimpleP
                        {
                            ValorFuturoP = Convert.ToInt32(txtValorFuturoP.Text),
                            TasaInteresP = Convert.ToDouble(txtTasaInteresP.Text),
                            PeriodoP = Convert.ToDouble(txtPeriodoP.Text),
                            Presente = ValorFuturoPe / (1 + (TasaInteresPe / 100 * PeriodoPe)),
                        });
                        dgvResultadosP.DataSource = null;
                        dgvResultadosP.DataSource = Ps;
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
            txtValorFuturoP.Clear();
            txtTasaInteresP.Clear();
            txtPeriodoP.Clear();
        }
    }
}
