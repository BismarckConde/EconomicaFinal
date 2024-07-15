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

namespace PjEconomica.Formularios.Formularios_Gradientes
{
    public partial class FrmGeoAnual : Form
    {
       
        public FrmGeoAnual()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            cmbTasaNomF.Items.AddRange(new string[] { "Anual", "Trimestral", "Mensual", "Semestral" });
            cmbInteresF.Items.AddRange(new string[] { "Anual", "Trimestral", "Mensual", "Semestral" });
            cmbperi.Items.AddRange(new string[] { "Años", "Meses", "Trimestres", "Semestres" });
            cmbTasaNomF.SelectedIndex = 0;
            cmbInteresF.SelectedIndex = 0;
            cmbperi.SelectedIndex = 0;
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            try
            {
                double A1 = Convert.ToDouble(txtanu.Text);
                double j = Convert.ToDouble(txtNominal.Text) / GetRateDivisor(cmbTasaNomF.SelectedItem?.ToString()?? string.Empty);
                double i = Convert.ToDouble(txtinte.Text) / GetRateDivisor(cmbInteresF.SelectedItem?.ToString() ?? string.Empty);
                double n = Convert.ToDouble(txtPeri.Text) * GetPeriodMultiplier(cmbperi.SelectedItem?.ToString() ?? string.Empty);

                double numerator1 = Math.Pow(1 + j, n) - Math.Pow(1 + i, n);
                double denominator = j - i;
                double fraction = i / (Math.Pow(1 + i, n) - 1);
                double AE = A1 * (numerator1 / denominator) * fraction;

                dataGridView1.Rows.Add(A1.ToString("C2"), j.ToString("P2"), i.ToString("P2"), n, AE.ToString("C2"));
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
            txtPeri.Clear();
            txtNominal.Clear();
            txtinte.Clear();
            txtanu.Clear();
        }
    }
}
