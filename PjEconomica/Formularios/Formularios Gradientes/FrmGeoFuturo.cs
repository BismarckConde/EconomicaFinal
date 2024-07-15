using ProyectoIng_Economica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjEconomica.Formularios.Formularios_Gradientes
{
    public partial class FrmGeoFuturo : Form
    {
        public FrmGeoFuturo()
        {
            InitializeComponent();
        }

        private List<Resultado> ResultadosGeométricoFuturo = new List<Resultado>();
        private void btncal_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(txtAnualidadFuturo.Text) ||
                    string.IsNullOrEmpty(txtPeriodoF.Text) ||
                    string.IsNullOrEmpty(txtInteresFuturo.Text) ||
                    string.IsNullOrEmpty(txtInteresJ.Text))
                {
                    MessageBox.Show("Rellene todos los campos necesarios.");
                    return;
                }

                
                if (cmbInteresF.SelectedItem == null ||
                    cmbperi.SelectedItem == null ||
                    cmbTasaNomF.SelectedItem == null)
                {
                    MessageBox.Show("Verifique que tiene ya Seleccionada su opción.");
                    return;
                }

                
                double Valor_Anualidad = Convert.ToDouble(txtAnualidadFuturo.Text);
                double Periodo = Convert.ToDouble(txtPeriodoF.Text);
                double tasaInteres = Convert.ToDouble(txtInteresFuturo.Text) / 100;
                double tasaNominal = Convert.ToDouble(txtInteresJ.Text) / 100;

                
                string periodicidadInteres = cmbInteresF.SelectedItem?.ToString()?? string.Empty;
                string unidadPeriodo = cmbperi.SelectedItem?.ToString()?? string.Empty;
                string periodicidadNominal = cmbTasaNomF.SelectedItem?.ToString() ?? string.Empty   ;

                int periodicidadInteresNum = ObtenerPeriodicidad(periodicidadInteres);
                int periodicidadNominalNum = ObtenerPeriodicidad(periodicidadNominal);
                double PeriodoConvertido = ConvertirPeriodoAnios(Periodo, unidadPeriodo);

                
                double i = ConvertirTasaNominalAEfectivaAnual(tasaNominal, periodicidadNominalNum);
                double g = tasaInteres / periodicidadInteresNum;
                i = Math.Round(i, 4, MidpointRounding.AwayFromZero);

                
                double resultados = CalcularValorFuturo(Valor_Anualidad, g, PeriodoConvertido, i);
                resultados = Math.Round(resultados, 2);

                
                ResultadosGeométricoFuturo.Add(new Resultado
                {
                    ValorAnualidad = Valor_Anualidad,
                    TasaInteres = tasaInteres * 100,
                    TasaNominal = tasaNominal * 100,
                    Periodo = Periodo,
                    ValorFuturo = resultados
                });

                // Actualizar el DataGridView
                dgvFuturoGeometrico.DataSource = null;
                dgvFuturoGeometrico.DataSource = ResultadosGeométricoFuturo.ToList();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato inválido: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private double CalcularValorFuturo(double A1, double g, double n, double i)
        {
            return A1 * (Math.Pow(1 + g, n) - Math.Pow(1 + i, n)) / (g - i);
        }

        private double ConvertirTasaNominalAEfectivaAnual(double tasaNominal, int periodicidad)
        {
            return Math.Pow(1 + tasaNominal / periodicidad, periodicidad) - 1;
        }

        private double ConvertirPeriodoAnios(double n, string unidadPeriodo)
        {

            switch (unidadPeriodo)
            {
                case "Años":
                    return n;
                case "Meses":
                    return n / 12; 
                case "Trimestres":
                    return n / 4; 
                case "Semestres":
                    return n / 2; 
                default:
                    return n; 
            }
        }

        private int ObtenerPeriodicidad(string periodicidad)
        {

            switch (periodicidad)
            {
                case "Anual":
                    return 1; 
                case "Semestral":
                    return 2; 
                case "Trimestral":
                    return 4; 
                case "Mensual":
                    return 12; 
                default:
                    return 1; 
            }
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtPeriodoF.Clear();
            txtInteresJ.Clear();
            txtInteresFuturo.Clear();
            txtAnualidadFuturo.Clear();
        }
    }
}

