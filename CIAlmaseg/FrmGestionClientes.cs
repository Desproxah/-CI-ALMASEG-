using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIAlmaseg.Clases;

namespace CIAlmaseg
{
    public partial class FrmGestionClientes : Form
    {
        public FrmGestionClientes()
        {
            InitializeComponent();
            Tema.AutoAplicar(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
