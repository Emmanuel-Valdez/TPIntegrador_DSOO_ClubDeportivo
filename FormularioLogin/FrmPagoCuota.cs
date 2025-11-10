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

	}
}
