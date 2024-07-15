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
    public partial class FrmDefinicionGradientes : Form
    {
        public FrmDefinicionGradientes()
        {
            InitializeComponent();
        }

        private void btnMenuOp_Click(object sender, EventArgs e)
        {
            FrmGradientes frmGradientes = new FrmGradientes();
            frmGradientes.ShowDialog();
        }
    }
}
