using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjEconomica.Formularios.Formularios_Indicadores
{
    public partial class FrmTMAR : Form
    {
        private List<object> resultadosTMAR;
        public FrmTMAR()
        {
            InitializeComponent();
            resultadosTMAR = new List<object>();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (string.IsNullOrWhiteSpace(txtITP.Text) ||
                    string.IsNullOrWhiteSpace(txtMD.Text) ||
                    string.IsNullOrWhiteSpace(txtCD.Text) ||
                    string.IsNullOrWhiteSpace(txtPA.Text) ||
                    string.IsNullOrWhiteSpace(txtCPP.Text))
                {
                    MessageBox.Show("Por favor, ingrese todos los valores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtITP.Text, out double inversionTotal) ||
                    !double.TryParse(txtMD.Text, out double deuda) ||
                    !double.TryParse(txtCD.Text, out double costoDeuda) ||
                    !double.TryParse(txtPA.Text, out double patrimonio) ||
                    !double.TryParse(txtCPP.Text, out double costoPatrimonio))
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (inversionTotal <= 0 || deuda < 0 || costoDeuda < 0 || patrimonio < 0 || costoPatrimonio < 0)
                {
                    MessageBox.Show("Por favor, ingrese valores positivos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                costoDeuda /= 100;
                costoPatrimonio /= 100;

                
                double tmarMixta = (costoDeuda * deuda / inversionTotal) + (costoPatrimonio * patrimonio / inversionTotal);

              
                tmarMixta *= 100;

                
                resultadosTMAR.Add(new
                {
                    InversionTotal = inversionTotal,
                    MontoCapitalPropio = deuda,
                    CostoDeuda = costoDeuda * 100,
                    PatrimonioAportado = patrimonio,
                    CostoPatrimonio = costoPatrimonio * 100, 
                    TMARMixta = tmarMixta
                });

                
                dgvResultados.DataSource = null;
                dgvResultados.DataSource = resultadosTMAR.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCD.Clear();
            txtCPP.Clear();
            txtITP.Clear();
            txtMD.Clear();
            txtPA.Clear();
        }
    }
}
