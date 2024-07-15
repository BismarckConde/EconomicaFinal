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
    public partial class FrmIndicadores : Form
    {
        public FrmIndicadores()
        {
            InitializeComponent();
        }

        private void btnTir_Click(object sender, EventArgs e)
        {
            FrmTIR frmTIR = new FrmTIR();
            frmTIR.ShowDialog();
        }

        private void btnVpn_Click(object sender, EventArgs e)
        {
            FrmVPN frmVPN = new FrmVPN();
            frmVPN.ShowDialog();
        }

        private void btnCaue_Click(object sender, EventArgs e)
        {
            FrmDefinicionCAUE frmDefinicionCAUE = new FrmDefinicionCAUE();
            frmDefinicionCAUE.ShowDialog();
        }

        private void btntmar_Click(object sender, EventArgs e)
        {
            FrmTMAR frmTMAR = new FrmTMAR();
            frmTMAR.ShowDialog();
        }
    }
}
