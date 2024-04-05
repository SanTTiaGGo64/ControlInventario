using System.Windows.Forms;

namespace Presentacion
{
    partial class frmReporteInventario
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
            this.components = new System.ComponentModel.Container();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btExportalExcel = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtFiltroTabla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblReloj = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.Mes = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.btnReporteMes = new System.Windows.Forms.Button();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.pbLimpiar = new System.Windows.Forms.PictureBox();
            this.clickAnimator1 = new Zeroit.Framework.Metro.ClickAnimator();
            this.gbxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpiar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxBotones
            // 
            this.gbxBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxBotones.Controls.Add(this.btExportalExcel);
            this.gbxBotones.Controls.Add(this.btnSalir);
            this.gbxBotones.Controls.Add(this.btnEliminar);
            this.gbxBotones.Location = new System.Drawing.Point(12, 439);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(896, 43);
            this.gbxBotones.TabIndex = 20;
            this.gbxBotones.TabStop = false;
            // 
            // btExportalExcel
            // 
            this.btExportalExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btExportalExcel.Location = new System.Drawing.Point(25, 12);
            this.btExportalExcel.Name = "btExportalExcel";
            this.btExportalExcel.Size = new System.Drawing.Size(115, 26);
            this.btExportalExcel.TabIndex = 5;
            this.btExportalExcel.Text = "📃 Exportar a Excel";
            this.btExportalExcel.UseVisualStyleBackColor = true;
            this.btExportalExcel.Click += new System.EventHandler(this.btExportalExcel_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(797, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 26);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "❌ Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.Location = new System.Drawing.Point(361, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(155, 25);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "🗑️ Eliminar Articulo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtFiltroTabla
            // 
            this.txtFiltroTabla.Location = new System.Drawing.Point(157, 19);
            this.txtFiltroTabla.Name = "txtFiltroTabla";
            this.txtFiltroTabla.Size = new System.Drawing.Size(241, 20);
            this.txtFiltroTabla.TabIndex = 1;
            this.txtFiltroTabla.TextChanged += new System.EventHandler(this.txtFiltroTabla_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "🔍 Buscar descripcion:";
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Location = new System.Drawing.Point(588, 505);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(0, 13);
            this.lblReloj.TabIndex = 28;
            this.lblReloj.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 27;
            this.label2.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(79, 505);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblUsuario.TabIndex = 26;
            this.lblUsuario.Visible = false;
            // 
            // Mes
            // 
            this.Mes.AutoSize = true;
            this.Mes.Location = new System.Drawing.Point(486, 22);
            this.Mes.Name = "Mes";
            this.Mes.Size = new System.Drawing.Size(45, 13);
            this.Mes.TabIndex = 30;
            this.Mes.Text = "🔍 Mes:";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 67);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.Size = new System.Drawing.Size(896, 366);
            this.dgvArticulos.TabIndex = 8;
            this.dgvArticulos.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvArticulos_CellBeginEdit);
            this.dgvArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbMes);
            this.groupBox1.Controls.Add(this.btnReporteMes);
            this.groupBox1.Controls.Add(this.cmbAnio);
            this.groupBox1.Controls.Add(this.pbLimpiar);
            this.groupBox1.Controls.Add(this.Mes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFiltroTabla);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 57);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Año:";
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(537, 19);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(87, 21);
            this.cmbMes.TabIndex = 2;
            // 
            // btnReporteMes
            // 
            this.btnReporteMes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporteMes.Location = new System.Drawing.Point(758, 17);
            this.btnReporteMes.Name = "btnReporteMes";
            this.btnReporteMes.Size = new System.Drawing.Size(82, 26);
            this.btnReporteMes.TabIndex = 4;
            this.btnReporteMes.Text = "🔍  Filtrar";
            this.btnReporteMes.UseVisualStyleBackColor = true;
            this.btnReporteMes.Click += new System.EventHandler(this.btnReporteMes_Click);
            // 
            // cmbAnio
            // 
            this.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(665, 19);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(87, 21);
            this.cmbAnio.TabIndex = 3;
            // 
            // pbLimpiar
            // 
            this.pbLimpiar.Image = global::Presentacion.Properties.Resources.icons8_limpiar_80;
            this.pbLimpiar.Location = new System.Drawing.Point(846, 13);
            this.pbLimpiar.Name = "pbLimpiar";
            this.pbLimpiar.Size = new System.Drawing.Size(33, 30);
            this.pbLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLimpiar.TabIndex = 42;
            this.pbLimpiar.TabStop = false;
            this.pbLimpiar.Tag = "Salir";
            this.pbLimpiar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // clickAnimator1
            // 
            this.clickAnimator1.Shape = Zeroit.Framework.Metro.ClickAnimator.DrawMode.Circle;
            // 
            // frmReporteInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.gbxBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReporteInventario";
            this.Text = "REPORTE INVENTARIO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLimpiar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private TextBox txtFiltroTabla;
        private Label label1;
        private Button btExportalExcel;
        private Timer timer1;
        private Label lblReloj;
        private Label label2;
        private Label lblUsuario;
        private Label Mes;
        private DataGridView dgvArticulos;
        private GroupBox groupBox1;
        private PictureBox pbLimpiar;
        private ComboBox cmbAnio;
        private Button btnReporteMes;
        private ComboBox cmbMes;
        private Label label3;
        private Zeroit.Framework.Metro.ClickAnimator clickAnimator1;
    }
}

