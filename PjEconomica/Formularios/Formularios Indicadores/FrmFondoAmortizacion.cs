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

namespace PjEconomica.Formularios.Formularios_Indicadores
{
    public partial class FrmFondoAmortizacion : Form
    {
        public FrmFondoAmortizacion()
        {
            InitializeComponent();
        }

        private List<object> ResultadosCAUE1 = new List<object>();
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double ValorI = Convert.ToDouble(txtValorI.Text);
                double ValorVs = Convert.ToDouble(txtValorVs.Text);
                double Interes = Convert.ToDouble(txtInteres.Text) / 100;
                int Periodo = Convert.ToInt32(txtperiodo.Text);
                double ValorC = Convert.ToDouble(txtValorC.Text);

                double Resultado1 = CalcularAnualidadVencidaPresente(Interes, Periodo);
                double Resultado2 = CalcularAnualidadVencipdaFuturo(Interes, Periodo);
                double CAUE = ValorI * (Resultado1) - 2600 * (Resultado2) + 500;
                ResultadosCAUE1.Add(new { ValorI = ValorI, ValorVs = ValorVs, Interes = Interes, Periodo = Periodo, ValorC = ValorC, Caue = CAUE });
                dgvAmort.DataSource = null;
                dgvAmort.DataSource = ResultadosCAUE1.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Rellene los campos necesarios " + ex);
            }
        }

        private double CalcularAnualidadVencipdaFuturo(double i, int n)
        {

            double parteInferior = Math.Pow(1 + i, n) - 1;
            return i / parteInferior;
        }

        private double CalcularAnualidadVencidaPresente(double i, int n)
        {

            double parteSuperior = i * Math.Pow(1 + i, n);
            double parteInferior = Math.Pow(1 + i, n) - 1;
            return parteSuperior / parteInferior;
        }

        private void FrmFondoAmortizacion_Load(object sender, EventArgs e)
        {

            dgvAmort.ColumnCount = 6;
            dgvAmort.Columns[0].Name = "Inversión Inicial (I)";
            dgvAmort.Columns[1].Name = "Valor Salvamento (Vs)";
            dgvAmort.Columns[2].Name = "Interés (%)";
            dgvAmort.Columns[3].Name = "Periodo (n)";
            dgvAmort.Columns[4].Name = "Costo Adicional (C)";
            dgvAmort.Columns[5].Name = "CAUE";


            var culture = new CultureInfo("es-NI");
            dgvAmort.Columns[0].DefaultCellStyle.Format = "C2";
            dgvAmort.Columns[1].DefaultCellStyle.Format = "C2";
            dgvAmort.Columns[4].DefaultCellStyle.Format = "C2";
            dgvAmort.Columns[5].DefaultCellStyle.Format = "C2";
            dgvAmort.Columns[0].DefaultCellStyle.FormatProvider = culture;
            dgvAmort.Columns[1].DefaultCellStyle.FormatProvider = culture;
            dgvAmort.Columns[4].DefaultCellStyle.FormatProvider = culture;
            dgvAmort.Columns[5].DefaultCellStyle.FormatProvider = culture;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtInteres.Clear();
            txtperiodo.Clear();
            txtValorC.Clear();
            txtValorI.Clear();
            txtValorVs.Clear();
        }
    }
}
