using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryNeptuno_FerMoya
{
    public partial class FrmPrincipal : Form
    {
        ClaseBD objClaseBD = new ClaseBD();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            objClaseBD.ConectarBD();
            objClaseBD.CargarCmb(cmbPais);

        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            objClaseBD.CargarCmb(cmbCiudad, cmbPais.Text);
        }
    }
}
