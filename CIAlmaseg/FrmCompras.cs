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
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
            Tema.AutoAplicar(this);
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
