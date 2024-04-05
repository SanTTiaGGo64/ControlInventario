namespace Presentacion
{
    partial class frmModificarArticulos
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
            this.gpxModif = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.btnRestar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.Stock = new System.Windows.Forms.Label();
            this.lclIdModif = new System.Windows.Forms.Label();
            this.txtIdArticuloModif = new System.Windows.Forms.TextBox();
            this.txtStockModif = new System.Windows.Forms.TextBox();
            this.chkEstadoModif = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioModif = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcionModif = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodArticuloModif = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.gpxModif.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpxModif
            // 
            this.gpxModif.Controls.Add(this.label2);
            this.gpxModif.Controls.Add(this.cmbProveedor);
            this.gpxModif.Controls.Add(this.btnRestar);
            this.gpxModif.Controls.Add(this.label1);
            this.gpxModif.Controls.Add(this.btnSumar);
            this.gpxModif.Controls.Add(this.Stock);
            this.gpxModif.Controls.Add(this.lclIdModif);
            this.gpxModif.Controls.Add(this.txtIdArticuloModif);
            this.gpxModif.Controls.Add(this.txtStockModif);
            this.gpxModif.Controls.Add(this.chkEstadoModif);
            this.gpxModif.Controls.Add(this.label7);
            this.gpxModif.Controls.Add(this.txtPrecioModif);
            this.gpxModif.Controls.Add(this.label5);
            this.gpxModif.Controls.Add(this.txtDescripcionModif);
            this.gpxModif.Controls.Add(this.label9);
            this.gpxModif.Controls.Add(this.txtCodArticuloModif);
            this.gpxModif.Controls.Add(this.groupBox5);
            this.gpxModif.Location = new System.Drawing.Point(12, 12);
            this.gpxModif.Name = "gpxModif";
            this.gpxModif.Size = new System.Drawing.Size(737, 81);
            this.gpxModif.TabIndex = 22;
            this.gpxModif.TabStop = false;
            this.gpxModif.Text = "✏️ MODIFICAR ARTICULO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(605, 47);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(96, 21);
            this.cmbProveedor.TabIndex = 7;
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(527, 47);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(25, 25);
            this.btnRestar.TabIndex = 26;
            this.btnRestar.Text = "➖";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Estado";
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(549, 47);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(25, 25);
            this.btnSumar.TabIndex = 25;
            this.btnSumar.Text = "➕";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Location = new System.Drawing.Point(378, 53);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(35, 13);
            this.Stock.TabIndex = 21;
            this.Stock.Text = "Stock";
            // 
            // lclIdModif
            // 
            this.lclIdModif.AutoSize = true;
            this.lclIdModif.Location = new System.Drawing.Point(22, 26);
            this.lclIdModif.Name = "lclIdModif";
            this.lclIdModif.Size = new System.Drawing.Size(16, 13);
            this.lclIdModif.TabIndex = 20;
            this.lclIdModif.Text = "Id";
            // 
            // txtIdArticuloModif
            // 
            this.txtIdArticuloModif.Enabled = false;
            this.txtIdArticuloModif.Location = new System.Drawing.Point(67, 23);
            this.txtIdArticuloModif.Name = "txtIdArticuloModif";
            this.txtIdArticuloModif.Size = new System.Drawing.Size(91, 20);
            this.txtIdArticuloModif.TabIndex = 1;
            // 
            // txtStockModif
            // 
            this.txtStockModif.Location = new System.Drawing.Point(430, 50);
            this.txtStockModif.Name = "txtStockModif";
            this.txtStockModif.Size = new System.Drawing.Size(100, 20);
            this.txtStockModif.TabIndex = 5;
            this.txtStockModif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockModif_KeyPress);
            // 
            // chkEstadoModif
            // 
            this.chkEstadoModif.AutoSize = true;
            this.chkEstadoModif.Location = new System.Drawing.Point(506, 25);
            this.chkEstadoModif.Name = "chkEstadoModif";
            this.chkEstadoModif.Size = new System.Drawing.Size(56, 17);
            this.chkEstadoModif.TabIndex = 6;
            this.chkEstadoModif.Text = "Activo";
            this.chkEstadoModif.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Precio";
            // 
            // txtPrecioModif
            // 
            this.txtPrecioModif.Location = new System.Drawing.Point(237, 49);
            this.txtPrecioModif.Name = "txtPrecioModif";
            this.txtPrecioModif.Size = new System.Drawing.Size(87, 20);
            this.txtPrecioModif.TabIndex = 4;
            this.txtPrecioModif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioModif_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descripcion";
            // 
            // txtDescripcionModif
            // 
            this.txtDescripcionModif.Location = new System.Drawing.Point(237, 23);
            this.txtDescripcionModif.Name = "txtDescripcionModif";
            this.txtDescripcionModif.Size = new System.Drawing.Size(198, 20);
            this.txtDescripcionModif.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Codigo";
            // 
            // txtCodArticuloModif
            // 
            this.txtCodArticuloModif.Location = new System.Drawing.Point(67, 52);
            this.txtCodArticuloModif.Name = "txtCodArticuloModif";
            this.txtCodArticuloModif.Size = new System.Drawing.Size(91, 20);
            this.txtCodArticuloModif.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(0, 219);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(751, 197);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(30, 46);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 26);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "🧹 Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(848, 494);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 26);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "✖️ Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(30, 13);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 26);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "💾 Guardar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Location = new System.Drawing.Point(769, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 81);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 99);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.Size = new System.Drawing.Size(935, 389);
            this.dgvArticulos.TabIndex = 24;
            this.dgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellDoubleClick);
            // 
            // frmModificarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 530);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpxModif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmModificarArticulos";
            this.Text = "MODIFICAR ARTICULOS";
            this.Load += new System.EventHandler(this.frmModificarArticulos_Load);
            this.gpxModif.ResumeLayout(false);
            this.gpxModif.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpxModif;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.Label lclIdModif;
        private System.Windows.Forms.TextBox txtIdArticuloModif;
        private System.Windows.Forms.TextBox txtStockModif;
        private System.Windows.Forms.CheckBox chkEstadoModif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecioModif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcionModif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodArticuloModif;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.DataGridView dgvArticulos;
    }
}