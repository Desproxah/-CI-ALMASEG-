using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIAlmaseg
{
    public partial class FrmMenuCliente : Form
    {
        public FrmMenuCliente()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }
    }
}
