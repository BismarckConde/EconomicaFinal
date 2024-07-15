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
    public partial class FrmTIR : Form
    {
        public FrmTIR()
        {
            InitializeComponent();
        }
        private List<object> ResultadosTIR = new List<object>();
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double VPN1, VPN2, INT1, INT2, TIR;
            try
            {
                VPN1 = Convert.ToDouble(txtVP1.Text);
                INT1 = Convert.ToDouble(txtIn1.Text);
                VPN2 = Convert.ToDouble(txtVP2.Text);
                INT2 = Convert.ToDouble(txtInt2.Text);


                TIR = INT1 - (VPN1 * (INT2 - INT1) / (VPN2 - VPN1));
                ResultadosTIR.Add(new
                {

                    ValorPresenteNeto1 = VPN1,
                    ValorPresenteNeto2 = VPN2,
                    Interes1 = INT1,
                    Interes2 = INT2,
                    TIR = TIR,


                });
                dgvTIR.DataSource = null;
                dgvTIR.DataSource = ResultadosTIR.ToList();
            }
            catch (FormatException ex)
            {

                MessageBox.Show("Rellene los campos necesarios " + ex);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtVP1.Clear();
            txtVP2.Clear();
            txtIn1.Clear();
            txtInt2.Clear();
        }
    }
}

