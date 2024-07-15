using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2021.DocumentTasks;
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

namespace PjEconomica.Formularios.Formularios_Gradientes
{
    public partial class FrmGeoPresent : Form
    {
        public FrmGeoPresent()
        {
            InitializeComponent();
            InitializeComboBoxes();
            
        }

        

        private void InitializeComboBoxes()
        {
            cmbTasaNom.Items.AddRange(new string[] { "Anual", "Trimestral", "Mensual", "Semestral" });
            cmbTasaInt.Items.AddRange(new string[] { "Anual", "Trimestral", "Mensual", "Semestral" });
            cmbPeriodo.Items.AddRange(new string[] { "Años", "Meses", "Trimestres", "Semestres" });
            cmbTasaNom.SelectedIndex = 0;
            cmbTasaInt.SelectedIndex = 0;
            cmbPeriodo.SelectedIndex = 0;
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            try
            {
                double A1 = Convert.ToDouble(txtAnuualidadPGeom.Text);
                double j = Convert.ToDouble(txtIntNomPGeom.Text) / GetRateDivisor(cmbTasaNom.SelectedItem?.ToString()?? string.Empty);
                double i = Convert.ToDouble(txtIntPGeom.Text) / GetRateDivisor(cmbTasaInt.SelectedItem?.ToString()?? string.Empty);
                double n = Convert.ToDouble(txtPeriodoPGeom.Text) * GetPeriodMultiplier(cmbPeriodo.SelectedItem?.ToString()?? string.Empty);

                double numerator = Math.Pow((1 + j) / (1 + i), n) - 1;
                double denominator = j - i;
                double PE = A1 * (numerator / denominator);

                dgvCalculoPGeometrico.Rows.Add(A1.ToString("C2"), j.ToString("P2"), i.ToString("P2"), n, PE.ToString("C2"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private double GetPeriodMultiplier(string periodType)
        {
            switch (periodType)
            {
                case "Años":
                    return 1;
                case "Semestres":
                    return 2;
                case "Trimestres":
                    return 4;
                case "Meses":
                    return 12;
                default:
                    throw new ArgumentException("Tipo de periodo no válido");
            }
        }

        private double GetRateDivisor(string rateType)
        {
            switch (rateType)
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
                    throw new ArgumentException("Tipo de tasa no válido");
            }
        }

        private void btnLim_Click(object sender, EventArgs e)
        {
            txtPeriodoPGeom.Clear();
            txtIntNomPGeom.Clear();
            txtIntPGeom.Clear();
            txtAnuualidadPGeom.Clear();
        }
    }
}