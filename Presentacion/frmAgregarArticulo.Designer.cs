using System.Windows.Forms;

namespace Presentacion
{
    partial class frmAgregarArticulo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoProveedor = new System.Windows.Forms.Button();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.chkestado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btguardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.gbxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnNuevoProveedor);
            this.groupBox1.Controls.Add(this.cmbProveedor);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.chkestado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 92);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "➕ NUEVO ARTICULO";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(531, 54);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(98, 20);
            this.dtpFecha.TabIndex = 7;
            this.dtpFecha.Value = new System.DateTime(2024, 1, 12, 18, 11, 9, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Fecha Registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Proveedor";
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.Location = new System.Drawing.Point(658, 23);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(28, 21);
            this.btnNuevoProveedor.TabIndex = 6;
            this.btnNuevoProveedor.Text = "+";
            this.btnNuevoProveedor.UseVisualStyleBackColor = true;
            this.btnNuevoProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(531, 22);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(121, 21);
            this.cmbProveedor.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(104, 57);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(120, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // chkestado
            // 
            this.chkestado.AutoSize = true;
            this.chkestado.Location = new System.Drawing.Point(643, 57);
            this.chkestado.Name = "chkestado";
            this.chkestado.Size = new System.Drawing.Size(59, 17);
            this.chkestado.TabIndex = 8;
            this.chkestado.Text = "Estado";
            this.chkestado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(305, 55);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(120, 20);
            this.txtStock.TabIndex = 4;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio c/u";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(305, 24);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(120, 20);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripcion";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 26);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(78, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo Articulo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(104, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(120, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnLimpiar);
            this.gbxBotones.Controls.Add(this.btguardar);
            this.gbxBotones.Location = new System.Drawing.Point(730, 12);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(109, 92);
            this.gbxBotones.TabIndex = 21;
            this.gbxBotones.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(13, 50);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 26);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "🧹 Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btguardar
            // 
            this.btguardar.Location = new System.Drawing.Point(13, 13);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(83, 26);
            this.btguardar.TabIndex = 8;
            this.btguardar.Text = "💾 Guardar";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(757, 459);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 26);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "❌ Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 110);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.Size = new System.Drawing.Size(826, 337);
            this.dgvArticulos.TabIndex = 25;
            this.dgvArticulos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvArticulos_CellFormatting);
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 497);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbxBotones);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAgregarArticulo";
            this.Text = "NUEVO ARTICULO";
            this.Load += new System.EventHandler(this.frmAgregarArticulo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.CheckBox chkestado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Button btnNuevoProveedor;
        private Label label1;
        private DateTimePicker dtpFecha;
        private Label label5;
        private DataGridView dgvArticulos;
    }
}