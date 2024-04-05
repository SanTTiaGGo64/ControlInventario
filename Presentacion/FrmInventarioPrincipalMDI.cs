using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmInventarioPrincipalMDI : Form
    {
        private int childFormNumber = 0;
        string LoginUsuario;
        int IdUsuario;
        private Timer timer;
        public FrmInventarioPrincipalMDI(string usuarioLog, int IdUser)
        {
            
        InitializeComponent();
            WindowState = FormWindowState.Maximized;
            tsUsuario.Text = usuarioLog;
            LoginUsuario = usuarioLog;
            IdUsuario = IdUser;
            timer = new Timer();
            timer.Interval = 1000; // Actualizar cada segundo
            timer.Tick += Timer_Tick;
            timer.Start();
            this.FormClosing += ChildForm_FormClosing;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualizar el texto del ToolStripStatusLabel con la hora actual
            toolStripStatusLabel2.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusStrip1.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form inventario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmReporteInventario);
            if (inventario != null)
            {
                inventario.BringToFront();
                return;
            }
            inventario = new frmReporteInventario(IdUsuario, LoginUsuario);
            inventario.MdiParent = this;
            inventario.Show();
        }
        private void FrmInventarioPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void agregarNuevoArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form agregararticulo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmAgregarArticulo);
            if (agregararticulo != null)
            {
                agregararticulo.BringToFront();
                return;
            }
            agregararticulo = new frmAgregarArticulo(IdUsuario, LoginUsuario);
            agregararticulo.MdiParent = this;
            agregararticulo.Show();
        }

        private void modificarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form agregararticulo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmModificarArticulos);
            if (agregararticulo != null)
            {
                agregararticulo.BringToFront();
                return;
            }
            agregararticulo = new frmModificarArticulos(IdUsuario, LoginUsuario);
            agregararticulo.MdiParent = this;
            agregararticulo.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form proveedor = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmAgregarProveedor);
            if (proveedor != null)
            {
                proveedor.BringToFront();
                return;
            }
            proveedor = new FrmAgregarProveedor(IdUsuario, LoginUsuario);
            proveedor.MdiParent = this;
            proveedor.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form usuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmAgregarUsuario);
            if (usuario != null)
            {
                usuario.BringToFront();
                return;
            }
            usuario = new frmAgregarUsuario(IdUsuario, LoginUsuario);
            usuario.MdiParent = this;
            usuario.Show();
        }
        private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form proveedor = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmModificarProveedor);
            if (proveedor != null)
            {
                proveedor.BringToFront();
                return;
            }
            proveedor = new frmModificarProveedor();
            proveedor.MdiParent = this;
            proveedor.Show();
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form usuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmModificarUsuarios);
            if (usuario != null)
            {
                usuario.BringToFront();
                return;
            }
            usuario = new frmModificarUsuarios(IdUsuario, LoginUsuario);
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Process.GetCurrentProcess().Kill();
        }
        private void ChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiParent != null)
            {
                e.Cancel = true;
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "El desarrollo de un sistema de inventario es fundamental " +
                "para optimizar la gestión de existencias en cualquier empresa o negocio. " +
                "Este sistema proporciona herramientas para registrar, monitorear y " +
                "controlar el flujo de productos, desde la adquisición hasta la venta. " +
                "A través de interfaces intuitivas y funcionalidades personalizadas, " +
                "los usuarios pueden realizar seguimiento de inventarios en tiempo real, " +
                "generar informes de stock, gestionar proveedores y clientes, así como " +
                "realizar análisis de datos para una toma de decisiones más informada. " +
                "La implementación de un sistema de inventario automatizado no solo mejora " +
                "la eficiencia operativa, sino que también ayuda a minimizar errores, " +
                "reducir costos y optimizar la satisfacción del cliente");
        }
 

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Form agregararticulo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmAgregarArticulo);
            if (agregararticulo != null)
            {
                agregararticulo.BringToFront();
                return;
            }
            agregararticulo = new frmAgregarArticulo(IdUsuario, LoginUsuario);
            agregararticulo.MdiParent = this;
            agregararticulo.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Form agregararticulo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmModificarArticulos);
            if (agregararticulo != null)
            {
                agregararticulo.BringToFront();
                return;
            }
            agregararticulo = new frmModificarArticulos(IdUsuario, LoginUsuario);
            agregararticulo.MdiParent = this;
            agregararticulo.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Form inventario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmReporteInventario);
            if (inventario != null)
            {
                inventario.BringToFront();
                return;
            }
            inventario = new frmReporteInventario(IdUsuario, LoginUsuario);
            inventario.MdiParent = this;
            inventario.Show();
        }
        public void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form proveedor = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmAgregarProveedor);
            if (proveedor != null)
            {
                proveedor.BringToFront();
                return;
            }
            proveedor = new FrmAgregarProveedor(IdUsuario, LoginUsuario);
            proveedor.MdiParent = this;
            proveedor.Show();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form proveedor = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmModificarProveedor);
            if (proveedor != null)
            {
                proveedor.BringToFront();
                return;
            }
            proveedor = new frmModificarProveedor();
            proveedor.MdiParent = this;
            proveedor.Show();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form usuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmAgregarUsuario);
            if (usuario != null)
            {
                usuario.BringToFront();
                return;
            }
            usuario = new frmAgregarUsuario(IdUsuario, LoginUsuario);
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form usuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmModificarUsuarios);
            if (usuario != null)
            {
                usuario.BringToFront();
                return;
            }
            usuario = new frmModificarUsuarios(IdUsuario, LoginUsuario);
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "El desarrollo de un sistema de inventario es fundamental " +
               "para optimizar la gestión de existencias en cualquier empresa o negocio. " +
               "Este sistema proporciona herramientas para registrar, monitorear y " +
               "controlar el flujo de productos, desde la adquisición hasta la venta. " +
               "A través de interfaces intuitivas y funcionalidades personalizadas, " +
               "los usuarios pueden realizar seguimiento de inventarios en tiempo real, " +
               "generar informes de stock, gestionar proveedores y clientes, así como " +
               "realizar análisis de datos para una toma de decisiones más informada. " +
               "La implementación de un sistema de inventario automatizado no solo mejora " +
               "la eficiencia operativa, sino que también ayuda a minimizar errores, " +
               "reducir costos y optimizar la satisfacción del cliente");
        }

        private void cambiarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Form login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
