using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioLogin
{
	public partial class FrmPagoCuota : Form
	{
		private Form FormInicio;
		public FrmPagoCuota(Form formInicio)
		{
			InitializeComponent();
			FormInicio = formInicio;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			FormInicio.Show();
			this.Close();
		}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
			//agregar buscar por dni
        }

        private void FrmPagoCuota_Load(object sender, EventArgs e)
        {

        }

        private void txtDniId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDniId_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
