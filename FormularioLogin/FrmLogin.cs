using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FormularioLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Esto es para asegurar que las cajas de textos no estén vacias
            if (string.IsNullOrWhiteSpace(textBoxUsuario.Text) || string.IsNullOrWhiteSpace(textBoxContraseña.Text))
            {
                MessageBox.Show("Por favor, ingresar usuario y contraseña.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (textBoxUsuario.Text == "admin" && textBoxContraseña.Text == "admin")
            {
                // Si el usuario y la contraseña son correctos, abrir el formulario de inicio
                FrmInicio frminicio = new FrmInicio();
                frminicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContraseña.Clear();
                textBoxUsuario.Clear();
                textBoxUsuario.Focus();
            }
            {

            }
        }

        private void textBoxContraseña_Enter(object sender, EventArgs e)
        {
            textBoxContraseña.UseSystemPasswordChar = true;

        }
        private void textBoxContraseña_Leave(object sender, EventArgs e)
        {
            if (textBoxContraseña.Text == "")
            {
                textBoxContraseña.UseSystemPasswordChar = false;
            }
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
