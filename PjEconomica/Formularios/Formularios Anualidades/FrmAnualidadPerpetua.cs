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

namespace PjEconomica.Formularios.Formularios_Anualidades
{
    public partial class FrmAnualidadPerpetua : Form
    {
        private List<Tuple<double, double>> datosIngresados = new List<Tuple<double, double>>();
        public FrmAnualidadPerpetua()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Anualidad";
            dataGridView1.Columns[1].Name = "Tasa ";
            dataGridView1.Columns[2].Name = "Total";

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                double anualidad = double.Parse(txtanu.Text);
                double tasaInteres = double.Parse(txttasa.Text) / 100;

                double valorPresente = anualidad / tasaInteres;


                datosIngresados.Add(new Tuple<double, double>(anualidad,tasaInteres));

                foreach (var dato in datosIngresados)
                {
                    dataGridView1.Rows.Add(dato.Item1, dato.Item2, $"C$ {valorPresente.ToString("C")}");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
