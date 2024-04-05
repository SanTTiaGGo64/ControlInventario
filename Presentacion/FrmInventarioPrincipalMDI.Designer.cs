using System.Windows.Forms;

namespace Presentacion
{
    partial class FrmInventarioPrincipalMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventarioPrincipalMDI));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReporteArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionProveeorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cambiarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblReloj = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(798, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.gestionProveeorToolStripMenuItem,
            this.gestionUsuarioToolStripMenuItem,
            this.toolStripSeparator3,
            this.cambiarUsuarioToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(63, 21);
            this.fileMenu.Text = "&Archivo";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoArticuloToolStripMenuItem,
            this.modificarArticuloToolStripMenuItem,
            this.ReporteArticulos});
            this.newToolStripMenuItem.Image = global::Presentacion.Properties.Resources.bolsa_de_la_compra;
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.newToolStripMenuItem.Text = "&Gestion Articulos";
            // 
            // agregarNuevoArticuloToolStripMenuItem
            // 
            this.agregarNuevoArticuloToolStripMenuItem.Image = global::Presentacion.Properties.Resources.agregar_archivo;
            this.agregarNuevoArticuloToolStripMenuItem.Name = "agregarNuevoArticuloToolStripMenuItem";
            this.agregarNuevoArticuloToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.agregarNuevoArticuloToolStripMenuItem.Text = "Nuevo Articulo";
            this.agregarNuevoArticuloToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoArticuloToolStripMenuItem_Click);
            // 
            // modificarArticuloToolStripMenuItem
            // 
            this.modificarArticuloToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icons8_editar_propiedad_64;
            this.modificarArticuloToolStripMenuItem.Name = "modificarArticuloToolStripMenuItem";
            this.modificarArticuloToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.modificarArticuloToolStripMenuItem.Text = "Modificar Articulo";
            this.modificarArticuloToolStripMenuItem.Click += new System.EventHandler(this.modificarArticuloToolStripMenuItem_Click);
            // 
            // ReporteArticulos
            // 
            this.ReporteArticulos.Image = global::Presentacion.Properties.Resources.icons8_microsoft_excel_2019_96;
            this.ReporteArticulos.Name = "ReporteArticulos";
            this.ReporteArticulos.Size = new System.Drawing.Size(183, 22);
            this.ReporteArticulos.Text = "Reportes Articulos";
            this.ReporteArticulos.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // gestionProveeorToolStripMenuItem
            // 
            this.gestionProveeorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedorToolStripMenuItem,
            this.modificarProveedorToolStripMenuItem});
            this.gestionProveeorToolStripMenuItem.Image = global::Presentacion.Properties.Resources.repartidor;
            this.gestionProveeorToolStripMenuItem.Name = "gestionProveeorToolStripMenuItem";
            this.gestionProveeorToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.gestionProveeorToolStripMenuItem.Text = "Gestion Proveedor";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.Image = global::Presentacion.Properties.Resources.agregar_archivo;
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.proveedorToolStripMenuItem.Text = "Nuevo Proveedor";
            this.proveedorToolStripMenuItem.Click += new System.EventHandler(this.proveedorToolStripMenuItem_Click);
            // 
            // modificarProveedorToolStripMenuItem
            // 
            this.modificarProveedorToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icons8_editar_propiedad_64;
            this.modificarProveedorToolStripMenuItem.Name = "modificarProveedorToolStripMenuItem";
            this.modificarProveedorToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.modificarProveedorToolStripMenuItem.Text = "Modificar Proveedor";
            this.modificarProveedorToolStripMenuItem.Click += new System.EventHandler(this.modificarProveedorToolStripMenuItem_Click);
            // 
            // gestionUsuarioToolStripMenuItem
            // 
            this.gestionUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.mToolStripMenuItem});
            this.gestionUsuarioToolStripMenuItem.Image = global::Presentacion.Properties.Resources.hombre__1_;
            this.gestionUsuarioToolStripMenuItem.Name = "gestionUsuarioToolStripMenuItem";
            this.gestionUsuarioToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.gestionUsuarioToolStripMenuItem.Text = "Gestion Usuario";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::Presentacion.Properties.Resources.agregar_archivo;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.usuariosToolStripMenuItem.Text = "Nuevo Usuario";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icons8_editar_propiedad_64;
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.mToolStripMenuItem.Text = "Modificar Usuario";
            this.mToolStripMenuItem.Click += new System.EventHandler(this.mToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(182, 6);
            // 
            // cambiarUsuarioToolStripMenuItem
            // 
            this.cambiarUsuarioToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icons8_cambiar_usuario_masculino_94;
            this.cambiarUsuarioToolStripMenuItem.Name = "cambiarUsuarioToolStripMenuItem";
            this.cambiarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cambiarUsuarioToolStripMenuItem.Text = "Cambiar Usuario";
            this.cambiarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cambiarUsuarioToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Presentacion.Properties.Resources.icons8_fire_exit_96;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator6,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator7,
            this.selectAllToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(54, 21);
            this.editMenu.Text = "&Editar";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.undoToolStripMenuItem.Text = "&Deshacer";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
            this.redoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.redoToolStripMenuItem.Text = "&Rehacer";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(216, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.cutToolStripMenuItem.Text = "Cor&tar";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.copyToolStripMenuItem.Text = "&Copiar";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.pasteToolStripMenuItem.Text = "&Pegar";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(216, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.selectAllToolStripMenuItem.Text = "Seleccionar &todo";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(39, 21);
            this.viewMenu.Text = "&Ver";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.toolBarToolStripMenuItem.Text = "&Barra de herramientas";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.statusBarToolStripMenuItem.Text = "&Barra de estado";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(56, 21);
            this.helpMenu.Text = "Ay&uda";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.aboutToolStripMenuItem.Text = "&Acerca de..";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton6,
            this.toolStripButton5,
            this.toolStripSeparator4,
            this.toolStripButton4,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.helpToolStripButton,
            this.toolStripButton8,
            this.toolStripButton9});
            this.toolStrip.Location = new System.Drawing.Point(0, 25);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(798, 33);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::Presentacion.Properties.Resources.estar;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripButton7.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton7.Text = "Nuevo";
            this.toolStripButton7.ToolTipText = "Nuevo Articulo";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::Presentacion.Properties.Resources.redaccion;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripButton6.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton6.Text = "Nuevo";
            this.toolStripButton6.ToolTipText = "Modificar Articulo";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::Presentacion.Properties.Resources.icons8_microsoft_excel_2019_96;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 30);
            this.toolStripButton5.Text = "Nuevo";
            this.toolStripButton5.ToolTipText = "Reportes Articulos";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Presentacion.Properties.Resources.icons8_proveedor_16;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 30);
            this.toolStripButton4.Text = "Nuevo";
            this.toolStripButton4.ToolTipText = "Nuevo Proveedor";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Presentacion.Properties.Resources.icons8_editar_propiedad_16;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 30);
            this.toolStripButton3.Text = "Nuevo";
            this.toolStripButton3.ToolTipText = "Modificar Proveedor";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Presentacion.Properties.Resources.icons8_usuario_16;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 30);
            this.toolStripButton2.Text = "Nuevo";
            this.toolStripButton2.ToolTipText = "Nuevo Usuario";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Presentacion.Properties.Resources.icons8_cambiar_usuario_masculino_16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 30);
            this.toolStripButton1.Text = "Nuevo";
            this.toolStripButton1.ToolTipText = "Modificar Usuario";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 30);
            this.helpToolStripButton.Text = "Ayuda";
            this.helpToolStripButton.ToolTipText = "Acerca de..";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::Presentacion.Properties.Resources.icons8_cambiar_usuario_masculino_94;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 30);
            this.toolStripButton8.Text = "Nuevo";
            this.toolStripButton8.ToolTipText = "Cambiar Usuario";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = global::Presentacion.Properties.Resources.icons8_fire_exit_96;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 30);
            this.toolStripButton9.Text = "Nuevo";
            this.toolStripButton9.ToolTipText = "Salir";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUsuario,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 401);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(798, 22);
            this.StatusStrip1.TabIndex = 2;
            this.StatusStrip1.Text = "StatusStrip";
            this.StatusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // tsUsuario
            // 
            this.tsUsuario.Name = "tsUsuario";
            this.tsUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Location = new System.Drawing.Point(583, 516);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(0, 13);
            this.lblReloj.TabIndex = 4;
            // 
            // FrmInventarioPrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 423);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmInventarioPrincipalMDI";
            this.Text = "SISTEMA DE INVENTARIO";
            this.Load += new System.EventHandler(this.FrmInventarioPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripStatusLabel tsUsuario;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem ReporteArticulos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblReloj;
        private ToolStripMenuItem agregarNuevoArticuloToolStripMenuItem;
        private ToolStripMenuItem modificarArticuloToolStripMenuItem;
        private ToolStripMenuItem gestionProveeorToolStripMenuItem;
        private ToolStripMenuItem proveedorToolStripMenuItem;
        private ToolStripMenuItem gestionUsuarioToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Timer timer2;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripMenuItem modificarProveedorToolStripMenuItem;
        private ToolStripMenuItem mToolStripMenuItem;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem cambiarUsuarioToolStripMenuItem;
        private ToolStripButton toolStripButton9;
        private ToolStripButton toolStripButton8;
    }
}



