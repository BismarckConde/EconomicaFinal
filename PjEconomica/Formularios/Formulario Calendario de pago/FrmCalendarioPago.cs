using ClosedXML.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using LicenseContext = OfficeOpenXml.LicenseContext;


namespace PjEconomica.Formularios.Formulario_Calendario_de_pago
{
    public partial class FrmCalendarioPago : Form
    {


        public FrmCalendarioPago()
        {
            InitializeComponent();
        }

        private void FrmCalendarioPago_Load(object sender, EventArgs e)
        {
            dgvCalendario.Columns.Add("Periodo", "Periodo");
            dgvCalendario.Columns.Add("Saldo", "Saldo");
            dgvCalendario.Columns.Add("Interes", "Interés");
            dgvCalendario.Columns.Add("Cuota", "Cuota");
            dgvCalendario.Columns.Add("Amortizacion", "Amortización");

            dgvCalendario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCalendario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvCalendario.Rows.Clear();


            double tasaInteres = Convert.ToDouble(txtInteres.Text) / 100;
            int numPeriodos = Convert.ToInt32(txtPeriodos.Text);
            double saldoInicial = Convert.ToDouble(txtSaldo.Text);

            // Calcular la cuota fija (Anualidad)
            double cuota = saldoInicial * (tasaInteres * Math.Pow(1 + tasaInteres, numPeriodos)) / (Math.Pow(1 + tasaInteres, numPeriodos) - 1);
            cuota = Math.Round(cuota, 2);

            // Generar el calendario de pagos
            double saldo = saldoInicial;

            for (int i = 1; i <= numPeriodos; i++)
            {
                double interes = Math.Round(saldo * tasaInteres, 2);
                double amortizacion = Math.Round(cuota - interes, 2);

                if (i == numPeriodos)
                {
                    amortizacion = saldo;
                    saldo = 0;
                }
                else
                {
                    saldo -= amortizacion;
                }

                dgvCalendario.Rows.Add(i, FormatMoney(saldo), FormatMoney(interes), FormatMoney(cuota), FormatMoney(amortizacion));

            }
        }

        private object FormatMoney(double valor)
        {
            return "C$" + valor.ToString("N2");
        }

        private void cboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarDatosExcel();
        }

        private void MostrarDatosExcel()
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    using (ExcelPackage pck = new ExcelPackage())
                    {
                        ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Calendario de Pago");

                        // Añadir encabezados
                        ws.Cells[1, 1].Value = "Número de Pago";
                        ws.Cells[1, 2].Value = "Cuota ";
                        ws.Cells[1, 3].Value = "Pago de Interés";
                        ws.Cells[1, 4].Value = "Amortización";
                        ws.Cells[1, 5].Value = "Saldo Restante";

                        // Añadir datos del DataGridView
                        for (int i = 0; i < dgvCalendario.Rows.Count; i++)
                        {
                            ws.Cells[i + 2, 1].Value = dgvCalendario.Rows[i].Cells[0].Value;
                            ws.Cells[i + 2, 2].Value = dgvCalendario.Rows[i].Cells[1].Value;
                            ws.Cells[i + 2, 3].Value = dgvCalendario.Rows[i].Cells[2].Value;
                            ws.Cells[i + 2, 4].Value = dgvCalendario.Rows[i].Cells[3].Value;
                            ws.Cells[i + 2, 5].Value = dgvCalendario.Rows[i].Cells[4].Value;
                        }

                        // Guardar el archivo
                        FileInfo fi = new FileInfo(sfd.FileName);
                        pck.SaveAs(fi);
                    }
                    MessageBox.Show("Calendario de pago exportado exitosamente.", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtSaldo.Clear();
            txtInteres.Clear();
            txtPeriodos.Clear();
            
        }
    }
}


