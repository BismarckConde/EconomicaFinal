using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjEconomica.Formularios.formularios_Intereses
{
    public partial class FrmPeriodoCompuesto : Form
    {
        public FrmPeriodoCompuesto()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {

        }

        private List<object> ResultadosPeriodo = new List<object>();
        private void btnCal_Click_1(object sender, EventArgs e)
        {

            double ValorFut, ValorPresente;
            double tasaint = 0, Periodo, i1, i2;
            try
            {
                ValorFut = Convert.ToDouble(txtValorFuturoN.Text);
                ValorPresente = Convert.ToDouble(txtValorPresenteN.Text);
                i2 = Convert.ToDouble(txtTasaInteresN.Text);
                /*periodo= Convert.ToDouble(txtPeriodoP.Text);
               baselog= Convert.ToDouble(txtPeriodoP.Text);
               baseF_P = Convert.ToDouble(txtPeriodoP.Text);
                */

                if (cmbInteresN.SelectedItem != null)
                {
                    /* baselog = 1 + tasaint;
                     baseF_P = Math.Log(ValorFut / ValorPresente);
                     periodo = ((int)(baseF_P/ Math.Log(baselog)));
                    */
                    if (cmbInteresN.SelectedItem.Equals("Anual"))
                    {
                        tasaint = i2 / 100; //  Esto pasar el valor del textob a decimal. Ejemplo: Si meto 5, pasa a 0.05
                        double Numerador = Math.Log(ValorFut / ValorPresente);
                        double Denominador = Math.Log(1 + tasaint);
                        Periodo = Numerador / Denominador;
                        ResultadosPeriodo.Add(new
                        {
                            ValorFuturo = ValorFut,
                            ValorPresente = ValorPresente,
                            TasaInteres = tasaint,
                            Periodo = Periodo,
                        });
                        dgvIntCompP.DataSource = null;
                        dgvIntCompP.DataSource = ResultadosPeriodo.ToList();
                    }
                    else if (cmbInteresN.SelectedItem.Equals("Semestral"))
                    {
                        /*baselog = 1 + tasaint;
                        baseF_P = Math.Log(ValorFut / ValorPresente);
                        Periodo = ((int)(baseF_P / Math.Log(baselog))) / 2;
                        */
                        i1 = i2 / 100; // Esto pasar el valor del textob a decimal. Ejemplo: Si meto 5, pasa a 0.05
                        tasaint = i1 / 2; // Una vez ya pasado a decimal, corvertimos a Semestres. Ejemplo: 0.05 pasa a 0.025
                        double Numerador = Math.Log(ValorFut / ValorPresente);
                        double Denominador = Math.Log(1 + tasaint);
                        Periodo = Numerador / Denominador;
                        ResultadosPeriodo.Add(new
                        {
                            ValorFuturo = ValorFut,
                            ValorPresente = ValorPresente,
                            TasaInteres = tasaint,
                            Periodo = Periodo

                        });
                        dgvIntCompP.DataSource = null;
                        dgvIntCompP.DataSource = ResultadosPeriodo.ToList();
                    }
                    else if (cmbInteresN.SelectedItem.Equals("Trimestral"))
                    {
                        /*baselog = 1 + tasaint;
                        baseF_P = Math.Log(ValorFut / ValorPresente);
                        Periodo = ((int)(baseF_P / Math.Log(baselog))) /4;
                        */
                        i1 = i2 / 100; // Esto pasar el valor del textob a decimal. Ejemplo: Si meto 5, pasa a 0.05
                        tasaint = i1 / 4; // Una vez ya pasado a decimal, corvertimos a trimestres. Ejemplo: 0.05 pasa a 0.125
                        double Numerador = Math.Log(ValorFut / ValorPresente);
                        double Denominador = Math.Log(1 + tasaint);
                        Periodo = Numerador / Denominador;
                        ResultadosPeriodo.Add(new
                        {
                            ValorFuturo = ValorFut,
                            ValorPresente = ValorPresente,
                            TasaInteres = tasaint,
                            Periodo = Periodo
                        });
                        dgvIntCompP.DataSource = null;
                        dgvIntCompP.DataSource = ResultadosPeriodo.ToList();
                    }
                    else if (cmbInteresN.SelectedItem.Equals("Mensual"))
                    {
                        /*baselog = 1 + tasaint;
                        baseF_P = Math.Log(ValorFut / ValorPresente);
                        Periodo = ((int)(baseF_P / Math.Log(baselog))) / 12;
                        */
                        i1 = i2 / 100; // Esto pasar el valor del textob a decimal. Ejemplo: Si meto 5, pasa a 0.05
                        tasaint = i1 / 12; // Una vez ya pasado a decimal, corvertimos a Mensual. Ejemplo: 0.05 pasa a 0.00416666666
                        double Numerador = Math.Log(ValorFut / ValorPresente);
                        double Denominador = Math.Log(1 + tasaint);
                        Periodo = Numerador / Denominador;
                        ResultadosPeriodo.Add(new
                        {
                            ValorFuturo = ValorFut,
                            ValorPresente = ValorPresente,
                            TasaInteres = tasaint,
                            Periodo = Periodo

                        });
                        dgvIntCompP.DataSource = null;
                        dgvIntCompP.DataSource = ResultadosPeriodo.ToList();
                    }
                }
            }
            catch (FormatException x)
            {

                MessageBox.Show("Rellene los campos necesarios " + x);
            }
        }


        private void btnLim_Click(object sender, EventArgs e)
        {
            txtValorPresenteN.Clear();
            txtValorFuturoN.Clear();
            txtTasaInteresN.Clear();
           
        }
    }
}


