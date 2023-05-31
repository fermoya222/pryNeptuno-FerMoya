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
            objClaseBD.CargarCmbProd(cmbCodigo);

        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            objClaseBD.CargarCmb(cmbCiudad, cmbPais.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPais_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            objClaseBD.CargarCmb(cmbCiudad, cmbPais.Text);

        }
    }
}
