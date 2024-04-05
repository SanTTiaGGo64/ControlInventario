namespace Presentacion
{
    partial class frmModificarProveedor
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btguardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.chkestado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btguardar);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Location = new System.Drawing.Point(260, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 178);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ACCIONES";
            // 
            // btguardar
            // 
            this.btguardar.Location = new System.Drawing.Point(7, 23);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(83, 26);
            this.btguardar.TabIndex = 6;
            this.btguardar.Text = "💾 Guardar";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(5, 73);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 26);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "🧹 Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.AllowUserToAddRows = false;
            this.dgvProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(362, 12);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.ReadOnly = true;
            this.dgvProveedor.Size = new System.Drawing.Size(367, 178);
            this.dgvProveedor.TabIndex = 9;
            this.dgvProveedor.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProveedor_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIdentificacion);
            this.groupBox1.Controls.Add(this.chkestado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 181);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "➕ MODIFICAR PROVEEDOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(96, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(120, 20);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Estado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(96, 82);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(120, 20);
            this.txtIdentificacion.TabIndex = 3;
            this.txtIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacion_KeyPress);
            // 
            // chkestado
            // 
            this.chkestado.AutoSize = true;
            this.chkestado.Location = new System.Drawing.Point(96, 143);
            this.chkestado.Name = "chkestado";
            this.chkestado.Size = new System.Drawing.Size(56, 17);
            this.chkestado.TabIndex = 5;
            this.chkestado.Text = "Activo";
            this.chkestado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefono";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(96, 115);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(120, 20);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Identificacion";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 52);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(44, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // frmModificarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 197);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmModificarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODIFICAR PROVEEDORES";
            this.Load += new System.EventHandler(this.frmModificarProveedor_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.CheckBox chkestado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
    }
}