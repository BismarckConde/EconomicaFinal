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
    public partial class FrmValorPresente : Form
    {
        public FrmValorPresente()
        {
            InitializeComponent();
        }

        private List<object> ResultadosCAUE2 = new List<object>();
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double ValorP = Convert.ToDouble(txtValorp.Text);
                double ValorVs = Convert.ToDouble(txtValorVs.Text);
                double Interes = Convert.ToDouble(txtInteres.Text) / 100;
                int Periodo1 = Convert.ToInt32(txtpla1.Text);
                int Periodo2 = Convert.ToInt32(txtPla2.Text);
                double ValorC = Convert.ToDouble(txtValorC.Text);
                double Cre = Convert.ToDouble(txtVCRE.Text);

                double Resultado1 = CalcularPresente(Interes, Periodo1);
                double Resultado2 = CalcularPresente(Interes, Periodo2);
                double Resultado3 = CalcularAnualidadVencidaPresente(Interes, Periodo1);

                double Caue = (ValorP - ValorVs * (Resultado1) + Cre * (Resultado2)) * (Resultado3) + ValorC;
                ResultadosCAUE2.Add(new { ValorP = ValorP, ValorVs = ValorVs, Interes = Interes, Plazo1 = Periodo1, Plazo2 = Periodo2, ValorC = ValorC, Cre = Cre, CAUE = Caue });
                dgvVP.DataSource = null;
                dgvVP.DataSource = ResultadosCAUE2.ToList();
            }
            catch (FormatException x)
            {
                MessageBox.Show("Rellene los campos necesarios" + x);
            }
        }

        private double CalcularAnualidadVencidaPresente(double i, int n)
        {
            double parteSuperior = i * Math.Pow(1 + i, n);
            double parteInferior = Math.Pow(1 + i, n) - 1;
            return parteSuperior / parteInferior;
        }

        private double CalcularPresente(double i, int n)
        {
            return Math.Pow(1 + i, -n);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            txtValorp.Clear();
            txtValorVs.Clear();
            txtInteres.Clear();
            txtpla1.Clear();
            txtPla2.Clear();
            txtValorC.Clear();
            txtVCRE.Clear();
        }
    }
}
