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
    public partial class FrmPeriodo : Form
    {
        public List<InteresSimpleN> Ns = new List<InteresSimpleN>();
        public FrmPeriodo()
        {
            InitializeComponent();
        }

        private void FrmPeriodo_Load(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                int ValorFuturoNe = Convert.ToInt32(txtValorFuturoN.Text);
                int ValorPresenteNe = Convert.ToInt32(txtValorPresenteN.Text);
                double TasaInteresNe = Convert.ToDouble(txtTasaInteresN.Text);
                int Periodo = (int)((ValorFuturoNe / ValorPresenteNe - 1) / (TasaInteresNe));

                Ns.Add(new InteresSimpleN
                {
                    ValorFuturoN = Convert.ToInt32(txtValorFuturoN.Text),
                    ValorPresenteN = Convert.ToInt32(txtValorPresenteN.Text),
                    TasaInteresN = Convert.ToDouble(txtTasaInteresN.Text),
                    Periodo = (ValorFuturoNe - ValorPresenteNe) / (ValorPresenteNe * (TasaInteresNe / 100)),
                });
                dgvResultadosN.DataSource = null;
                dgvResultadosN.DataSource = Ns;

            }
            catch (FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios " + x);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("El periodo no puede ser cero.", "Error de division por cero" + ex);
            }
        }


        private void btnLim_Click(object sender, EventArgs e)
        {
            txtValorPresenteN.Clear();
            txtValorFuturoN.Clear();
            txtTasaInteresN.Clear();
        }

        private void txtVF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

