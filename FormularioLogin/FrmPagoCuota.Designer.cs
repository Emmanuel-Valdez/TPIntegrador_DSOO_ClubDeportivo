namespace FormularioLogin
{
	partial class FrmPagoCuota
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>


		private void InitializeComponent()
		{
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDniId = new System.Windows.Forms.Label();
            this.txtDniId = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreValor = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblApellidoValor = new System.Windows.Forms.Label();
            this.lblMiembro = new System.Windows.Forms.Label();
            this.lblMiembroValor = new System.Windows.Forms.Label();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblEmision = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dateTimePickerVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEmision = new System.Windows.Forms.DateTimePicker();
            this.textBoxTipoPago = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.CmBxTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(180, 31);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(210, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pago de cuota";
            // 
            // lblDniId
            // 
            this.lblDniId.AutoSize = true;
            this.lblDniId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniId.Location = new System.Drawing.Point(45, 128);
            this.lblDniId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDniId.Name = "lblDniId";
            this.lblDniId.Size = new System.Drawing.Size(65, 20);
            this.lblDniId.TabIndex = 1;
            this.lblDniId.Text = "Dni/Id:";
            this.lblDniId.Click += new System.EventHandler(this.lblDniId_Click);
            // 
            // txtDniId
            // 
            this.txtDniId.Location = new System.Drawing.Point(150, 124);
            this.txtDniId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDniId.Name = "txtDniId";
            this.txtDniId.Size = new System.Drawing.Size(223, 26);
            this.txtDniId.TabIndex = 2;
            this.txtDniId.TextChanged += new System.EventHandler(this.txtDniId_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(390, 121);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(45, 174);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 20);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNombreValor
            // 
            this.lblNombreValor.AutoSize = true;
            this.lblNombreValor.Location = new System.Drawing.Point(150, 174);
            this.lblNombreValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreValor.Name = "lblNombreValor";
            this.lblNombreValor.Size = new System.Drawing.Size(14, 20);
            this.lblNombreValor.TabIndex = 5;
            this.lblNombreValor.Text = "-";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(45, 205);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(82, 20);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblApellidoValor
            // 
            this.lblApellidoValor.AutoSize = true;
            this.lblApellidoValor.Location = new System.Drawing.Point(150, 205);
            this.lblApellidoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoValor.Name = "lblApellidoValor";
            this.lblApellidoValor.Size = new System.Drawing.Size(14, 20);
            this.lblApellidoValor.TabIndex = 7;
            this.lblApellidoValor.Text = "-";
            // 
            // lblMiembro
            // 
            this.lblMiembro.AutoSize = true;
            this.lblMiembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiembro.Location = new System.Drawing.Point(45, 236);
            this.lblMiembro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiembro.Name = "lblMiembro";
            this.lblMiembro.Size = new System.Drawing.Size(87, 20);
            this.lblMiembro.TabIndex = 8;
            this.lblMiembro.Text = "Miembro:";
            // 
            // lblMiembroValor
            // 
            this.lblMiembroValor.AutoSize = true;
            this.lblMiembroValor.Location = new System.Drawing.Point(150, 236);
            this.lblMiembroValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiembroValor.Name = "lblMiembroValor";
            this.lblMiembroValor.Size = new System.Drawing.Size(14, 20);
            this.lblMiembroValor.TabIndex = 9;
            this.lblMiembroValor.Text = "-";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPago.Location = new System.Drawing.Point(45, 282);
            this.lblTipoPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(123, 20);
            this.lblTipoPago.TabIndex = 10;
            this.lblTipoPago.Text = "Tipo de pago:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(45, 328);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(66, 20);
            this.lblMonto.TabIndex = 12;
            this.lblMonto.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(180, 324);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(223, 26);
            this.txtMonto.TabIndex = 13;
            // 
            // lblEmision
            // 
            this.lblEmision.AutoSize = true;
            this.lblEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmision.Location = new System.Drawing.Point(45, 374);
            this.lblEmision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmision.Name = "lblEmision";
            this.lblEmision.Size = new System.Drawing.Size(82, 20);
            this.lblEmision.TabIndex = 14;
            this.lblEmision.Text = "Emision:";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.Location = new System.Drawing.Point(45, 416);
            this.lblVencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(118, 20);
            this.lblVencimiento.TabIndex = 16;
            this.lblVencimiento.Text = "Vencimiento:";
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Location = new System.Drawing.Point(120, 467);
            this.btnRegistrarPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(150, 46);
            this.btnRegistrarPago.TabIndex = 18;
            this.btnRegistrarPago.Text = "Registrar pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(300, 467);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 46);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dateTimePickerVencimiento
            // 
            this.dateTimePickerVencimiento.Location = new System.Drawing.Point(180, 414);
            this.dateTimePickerVencimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerVencimiento.Name = "dateTimePickerVencimiento";
            this.dateTimePickerVencimiento.Size = new System.Drawing.Size(320, 26);
            this.dateTimePickerVencimiento.TabIndex = 20;
            this.dateTimePickerVencimiento.Value = new System.DateTime(2025, 11, 9, 4, 26, 16, 0);
            // 
            // dateTimePickerEmision
            // 
            this.dateTimePickerEmision.Location = new System.Drawing.Point(180, 374);
            this.dateTimePickerEmision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerEmision.MinDate = new System.DateTime(2025, 11, 9, 0, 0, 0, 0);
            this.dateTimePickerEmision.Name = "dateTimePickerEmision";
            this.dateTimePickerEmision.Size = new System.Drawing.Size(320, 26);
            this.dateTimePickerEmision.TabIndex = 21;
            // 
            // textBoxTipoPago
            // 
            this.textBoxTipoPago.Location = new System.Drawing.Point(180, 278);
            this.textBoxTipoPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTipoPago.Name = "textBoxTipoPago";
            this.textBoxTipoPago.Size = new System.Drawing.Size(223, 26);
            this.textBoxTipoPago.TabIndex = 22;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(45, 86);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(45, 20);
            this.lblTipo.TabIndex = 23;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.Click += new System.EventHandler(this.label1_Click);
            // 
            // CmBxTipo
            // 
            this.CmBxTipo.FormattingEnabled = true;
            this.CmBxTipo.Location = new System.Drawing.Point(149, 78);
            this.CmBxTipo.Name = "CmBxTipo";
            this.CmBxTipo.Size = new System.Drawing.Size(224, 28);
            this.CmBxTipo.TabIndex = 24;
            this.CmBxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmPagoCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(555, 565);
            this.Controls.Add(this.CmBxTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.textBoxTipoPago);
            this.Controls.Add(this.dateTimePickerEmision);
            this.Controls.Add(this.dateTimePickerVencimiento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.lblEmision);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.lblMiembroValor);
            this.Controls.Add(this.lblMiembro);
            this.Controls.Add(this.lblApellidoValor);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombreValor);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDniId);
            this.Controls.Add(this.lblDniId);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPagoCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago de Cuota";
            this.Load += new System.EventHandler(this.FrmPagoCuota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblDniId;
		private System.Windows.Forms.TextBox txtDniId;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblNombreValor;
		private System.Windows.Forms.Label lblApellido;
		private System.Windows.Forms.Label lblApellidoValor;
		private System.Windows.Forms.Label lblMiembro;
		private System.Windows.Forms.Label lblMiembroValor;
		private System.Windows.Forms.Label lblTipoPago;
		private System.Windows.Forms.Label lblMonto;
		private System.Windows.Forms.TextBox txtMonto;
		private System.Windows.Forms.Label lblEmision;
		private System.Windows.Forms.Label lblVencimiento;
		private System.Windows.Forms.Button btnRegistrarPago;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.DateTimePicker dateTimePickerVencimiento;
		private System.Windows.Forms.DateTimePicker dateTimePickerEmision;
		private System.Windows.Forms.TextBox textBoxTipoPago;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox CmBxTipo;
    }
}