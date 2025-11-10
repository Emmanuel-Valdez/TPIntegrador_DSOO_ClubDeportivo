using MySql.Data.MySqlClient; // Acuerdensen que para que esto funcione tienen que hacer click derecho en 
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//formularioLogin -> Administrar paquetes NuGet -> Buscar MySql.Data y luego lo tienen que instalar, sino no funciona.

namespace FormularioLogin
{
    public partial class FrmRegistro : Form
    {
		private  Form formularioInicio;
		public FrmRegistro(Form frmInicio)
        {
            InitializeComponent();
            formularioInicio = frmInicio;
        }

      
        private void btn_registrar(object sender, EventArgs e)
        {
            // Esto es para asegurarse que está todo completo.
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(textBoxApellido.Text) ||
                string.IsNullOrWhiteSpace(textBoxDNI.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxTipo.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se asegura que el mail tenga @ y .
            if (!textBoxEmail.Text.Contains("@") || !textBoxEmail.Text.Contains("."))
            {
                MessageBox.Show("El email parece inválido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Acá obtenemos los datos que se pone en el formulario
            string nombre = textBoxNombre.Text.Trim();
            string apellido = textBoxApellido.Text.Trim();
            string dni = textBoxDNI.Text.Trim();
            DateTime fechaNac = dateTimeNac.Value.Date; // .Date para que solo sea la fecha sin la hora.
            string email = textBoxEmail.Text.Trim();
            DateTime fechaEmision = dateTimeEmision.Value.Date;
            string tipo = textBoxTipo.Text.Trim();

			string query = "INSERT INTO socio (nombre, apellido, dni, fecha_nac, email, fecha_emision, tipo) " +
			   "VALUES (@nombre, @apellido, @dni, @fechaNac, @correo, @fechaEmision, @tipo)";

			int result = DatabaseHelper.ExecuteNonQuery(
				query,
				new MySqlParameter("@nombre", nombre),
				new MySqlParameter("@apellido", apellido),
				new MySqlParameter("@dni", dni),
				new MySqlParameter("@fechaNac", fechaNac),
				new MySqlParameter("@correo", email),
				new MySqlParameter("@fechaEmision", fechaEmision),
				new MySqlParameter("@tipo", tipo)
			);

			if (result > 0)
			{
				MessageBox.Show("Socio registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LimpiarCampos();
			}
			
        }

		private void CargarComboBox()
		{
			comboBoxTipo.Items.Clear();

			// Agregar items con texto y valor
			comboBoxTipo.Items.Add(new { Text = "Socio", Value = "1" });
			comboBoxTipo.Items.Add(new { Text = "No Socio", Value = "2" });
		

			// Configurar qué propiedad mostrar
			comboBoxTipo.DisplayMember = "Text";
		}


		// este es el metodo para que se limpien los campos, no es necesario pero queda mas lindo. 
		private void LimpiarCampos()
        {
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxDNI.Clear();
            textBoxEmail.Clear();
            textBoxTipo.Clear();
            dateTimeNac.Value = DateTime.Today; // Esto hace que se restablezca a la fecha actual. 
            dateTimeEmision.Value = DateTime.Today;
        }

        

        private void FrmRegistro_Load(object sender, EventArgs e) {
            CargarComboBox();

		}

        private void textBoxApellido_TextChanged(object sender, EventArgs e) { }
        private void textBoxDNI_TextChanged(object sender, EventArgs e) { }
        private void textBoxNombre_TextChanged(object sender, EventArgs e) { }
        private void dateTimeNac_ValueChanged(object sender, EventArgs e) { }
        private void textBoxEmail_TextChanged(object sender, EventArgs e) { }
        private void dateTimeEmision_ValueChanged(object sender, EventArgs e) { }
        private void textBoxTipo_TextChanged(object sender, EventArgs e) { }



		private void btn_volverInicio(object sender, EventArgs e)
		{
			formularioInicio.Show();
			this.Close();
		}

		private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}