
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioLogin
{
    public partial class FrmLogin : Form
    {
		private DatabaseHelper dbHelper;
		public FrmLogin()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }
		
		private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

		private void btnCreateDatabase_Click(object sender, EventArgs e)
		{
			try
			{
				// Deshabilitar el botón durante la operación
				btnCreateDatabase.Enabled = false;
				btnCreateDatabase.Text = "Creando BD...";

				// Usar Task.Run para no bloquear la UI
				Task.Run(() =>
				{
					bool success = dbHelper.CreateDatabase();

					// Volver a habilitar el botón en el hilo de UI
					this.Invoke(new Action(() =>
					{
						btnCreateDatabase.Enabled = true;
						btnCreateDatabase.Text = "Crear Base de Datos";

						if (success)
						{
							// Opcional: actualizar algún label o status
							lblStatus.Text = "Base de datos creada - " + DateTime.Now.ToString();
						}
					}));
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
				btnCreateDatabase.Enabled = true;
				btnCreateDatabase.Text = "Crear Base de Datos";
			}
		}
	}
	
}
