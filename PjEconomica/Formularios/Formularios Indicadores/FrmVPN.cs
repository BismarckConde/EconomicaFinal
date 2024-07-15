using DocumentFormat.OpenXml.Drawing.Charts;
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
    public partial class FrmVPN : Form
    {
        public FrmVPN()
        {
            InitializeComponent();
            
            cboNomi.Items.AddRange(new object[] { "Anual", "Trimestral", "Mensual", "Semestral" });
            cboPeri.Items.AddRange(new object[] { "Años", "Meses", "Trimestres", "Semestres" });

            
            cboNomi.SelectedIndex = 0; 
            cboPeri.SelectedIndex = 0; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
               
                double inversionInicial = Convert.ToDouble(txtInverIni.Text);
                double tasaInteres = Convert.ToDouble(txtTasaDescuento.Text);
                double tasaNominal = ObtenerTasaNominal();
                double periodo = ObtenerPeriodo();
                string[] strFNE = txtFne.Text.Split(',');
                double[] flujosNetosEfectivo = new double[strFNE.Length];

                for (int i = 0; i < strFNE.Length; i++)
                {
                    flujosNetosEfectivo[i] = Convert.ToDouble(strFNE[i]);
                }

                
                double vpn = CalcularVPN(inversionInicial, tasaInteres, tasaNominal, periodo, flujosNetosEfectivo);



                MostrarResultado(inversionInicial, tasaInteres, tasaNominal, periodo, flujosNetosEfectivo, vpn);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el VPN: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarResultado(double inversionInicial, double tasaInteres, double tasaNominal, double periodo, double[] flujosNetosEfectivo, double vpn)
        {
            dataGridView1.Columns.Add("Detalle", "Detalle");
            dataGridView1.Columns.Add("Valor", "Valor");

            
            dataGridView1.Rows.Add("Inversión Inicial", inversionInicial.ToString("C"));
            dataGridView1.Rows.Add("Tasa de Interés", tasaInteres.ToString("P"));
            dataGridView1.Rows.Add("Tasa Nominal", tasaNominal.ToString("P"));
            dataGridView1.Rows.Add("Periodo", periodo.ToString("N2"));

            
            for (int i = 0; i < flujosNetosEfectivo.Length; i++)
            {
                dataGridView1.Rows.Add($"FNE {i + 1}", flujosNetosEfectivo[i].ToString("C"));
            }

            
            dataGridView1.Rows.Add("Valor Presente Neto", vpn.ToString("C"));
        }

       

        private double CalcularVPN(double inversionInicial, double tasaInteres, double tasaNominal, double periodo, double[] flujosNetosEfectivo)
        {
            double vpn = -inversionInicial; 

   
            double tasaPeriodica = ConvertirTasaNominal(tasaNominal, periodo);

            
            for (int i = 0; i < flujosNetosEfectivo.Length; i++)
            {
                vpn += flujosNetosEfectivo[i] / Math.Pow(1 + tasaPeriodica, i + 1);
            }

            return vpn;
        }

        private double ConvertirTasaNominal(double tasaNominal, double periodo)
        {
            return Math.Pow(1 + tasaNominal, 1 / periodo) - 1;
        }

        private double ObtenerPeriodo()
        {
            switch (cboPeri.SelectedIndex)
            {
                case 0: // Años
                    return Convert.ToDouble(txtAños.Text);
                case 1: // Meses
                    return Convert.ToDouble(txtAños.Text) / 12;
                case 2: // Trimestres
                    return Convert.ToDouble(txtAños.Text) / 4;
                case 3: // Semestres
                    return Convert.ToDouble(txtAños.Text) / 2;
                default:
                    throw new InvalidOperationException("Selección de periodo no válida.");
            }
        }

        private double ObtenerTasaNominal()
        {
           
            switch (cboNomi.SelectedIndex)
            {
                case 0: // Anual
                    return Convert.ToDouble(txtnomi.Text);
                case 1: // Trimestral
                    return Convert.ToDouble(txtnomi.Text) / 4;
                case 2: // Mensual
                    return Convert.ToDouble(txtnomi.Text) / 12;
                case 3: // Semestral
                    return Convert.ToDouble(txtnomi.Text) / 2;
                default:
                    throw new InvalidOperationException("Selección de tasa nominal no válida.");
            }
        }
    }
}

