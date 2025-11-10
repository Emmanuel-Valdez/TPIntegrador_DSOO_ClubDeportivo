namespace FormularioLogin
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.panel1 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxUsuario = new System.Windows.Forms.TextBox();
			this.textBoxContraseña = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkCyan;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 330);
			this.panel1.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Location = new System.Drawing.Point(475, 169);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Arial", 12F);
			this.textBox1.ForeColor = System.Drawing.Color.DimGray;
			this.textBox1.Location = new System.Drawing.Point(320, 120);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(413, 19);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "USUARIO";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.Enter += new System.EventHandler(this.textBoxContraseña_Enter);
			this.textBox1.Leave += new System.EventHandler(this.textBoxContraseña_Leave);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.InfoText;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new System.Drawing.Font("Arial", 12F);
			this.textBox2.ForeColor = System.Drawing.Color.DimGray;
			this.textBox2.Location = new System.Drawing.Point(320, 191);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(413, 19);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "CONTRASEÑA";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 20F);
			this.label1.ForeColor = System.Drawing.Color.DimGray;
			this.label1.Location = new System.Drawing.Point(469, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 32);
			this.label1.TabIndex = 5;
			this.label1.Text = "LOGIN";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.LightGray;
			this.button1.Location = new System.Drawing.Point(320, 254);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(413, 40);
			this.button1.TabIndex = 6;
			this.button1.Text = "INGRESAR";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxUsuario
			// 
			this.textBoxUsuario.Location = new System.Drawing.Point(452, 119);
			this.textBoxUsuario.Name = "textBoxUsuario";
			this.textBoxUsuario.Size = new System.Drawing.Size(150, 20);
			this.textBoxUsuario.TabIndex = 7;
			this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
			// 
			// textBoxContraseña
			// 
			this.textBoxContraseña.Location = new System.Drawing.Point(452, 190);
			this.textBoxContraseña.Name = "textBoxContraseña";
			this.textBoxContraseña.Size = new System.Drawing.Size(150, 20);
			this.textBoxContraseña.TabIndex = 8;
			this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			this.textBoxContraseña.Enter += new System.EventHandler(this.textBoxContraseña_Enter);
			this.textBoxContraseña.Leave += new System.EventHandler(this.textBoxContraseña_Leave);
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlText;
			this.ClientSize = new System.Drawing.Size(780, 330);
			this.Controls.Add(this.textBoxContraseña);
			this.Controls.Add(this.textBoxUsuario);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.panel1);
			this.Name = "FrmLogin";
			this.Opacity = 0.9D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.FrmLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContraseña;
    }
}

