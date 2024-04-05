namespace Presentacion
{
    partial class frmModificarUsuarios
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
            this.btguardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.chkestado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // btguardar
            // 
            this.btguardar.Location = new System.Drawing.Point(7, 254);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(83, 26);
            this.btguardar.TabIndex = 9;
            this.btguardar.Text = "💾 Guardar";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(96, 254);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 26);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "🧹 Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(254, 15);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.Size = new System.Drawing.Size(446, 286);
            this.dgvUsuario.TabIndex = 11;
            this.dgvUsuario.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsuario_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.pbSalir);
            this.groupBox1.Controls.Add(this.btguardar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtContraseña);
            this.groupBox1.Controls.Add(this.Usuario);
            this.groupBox1.Controls.Add(this.txtUsuarioLogin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIdentificacion);
            this.groupBox1.Controls.Add(this.chkestado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 289);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "➕ MODIFICAR USUARIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(96, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(120, 20);
            this.txtId.TabIndex = 1;
            // 
            // pbSalir
            // 
            this.pbSalir.Image = global::Presentacion.Properties.Resources.salida;
            this.pbSalir.Location = new System.Drawing.Point(198, 254);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(33, 27);
            this.pbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSalir.TabIndex = 39;
            this.pbSalir.TabStop = false;
            this.pbSalir.Tag = "Salir";
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Contraseña";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(96, 197);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(120, 20);
            this.txtContraseña.TabIndex = 7;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(20, 170);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 13;
            this.Usuario.Text = "Usuario";
            this.Usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(96, 167);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(120, 20);
            this.txtUsuarioLogin.TabIndex = 6;
            this.txtUsuarioLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuarioLogin_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(96, 82);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(120, 20);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Estado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(96, 108);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(120, 20);
            this.txtIdentificacion.TabIndex = 4;
            this.txtIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacion_KeyPress);
            // 
            // chkestado
            // 
            this.chkestado.AutoSize = true;
            this.chkestado.Location = new System.Drawing.Point(100, 231);
            this.chkestado.Name = "chkestado";
            this.chkestado.Size = new System.Drawing.Size(56, 17);
            this.chkestado.TabIndex = 8;
            this.chkestado.Text = "Activo";
            this.chkestado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefono";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(96, 137);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(120, 20);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Identificacion";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 59);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(44, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // frmModificarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 307);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmModificarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODIFICAR USUARIOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.CheckBox chkestado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pbSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
    }
}