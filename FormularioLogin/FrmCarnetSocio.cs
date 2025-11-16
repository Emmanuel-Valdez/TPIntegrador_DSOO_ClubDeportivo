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
	public partial class FrmCarnetSocio : Form
	{
		private Form FrmPago;
		public FrmCarnetSocio(Form frmPago)
		{
			InitializeComponent();
			FrmPago = frmPago;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FrmPago.Show();
			this.Close();
		}
	}
}
