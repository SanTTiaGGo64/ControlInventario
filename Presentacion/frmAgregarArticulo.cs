using AccesoDatos.Entidades;
using LogicaNegocios;
using Presentacion.Herramientas;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class frmAgregarArticulo : Form
    {
        private ArticulosLogica InventarioLogicaAcceso;
        private ProveedorLogica ProveedorLogicaAcceso;
        int IdUsuarioLog;
        string UsuarioLog;
        public frmAgregarArticulo(int IdUsuarioActual = 0, string usuarioLog = null)
        {
            InitializeComponent();
            InventarioLogicaAcceso = new ArticulosLogica();
            ProveedorLogicaAcceso = new ProveedorLogica();
            StartPosition = FormStartPosition.CenterScreen;
            UsuarioLog = usuarioLog;
            IdUsuarioLog = IdUsuarioActual;
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticulos.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dtpFecha.Value = DateTime.Now;
            dtpFecha.CustomFormat = "yyyy/MM/dd";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            ListarArticulo();
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(btnNuevoProveedor, "Agregar Proveedor");
            dtpFecha.Enabled = false;
        }
        public void ListarArticulo()
        {
            try
            {
                dgvArticulos.DataSource = InventarioLogicaAcceso.ListarArticulo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btguardar_Click(object sender, EventArgs e)
        {
            if (IdUsuarioLog == 0)
            {
                MessageBox.Show("No puede agregar registros como invitado!");
            }
            else
            {
                if (txtCodigo.Text == string.Empty ||
                    txtDescripcion.Text == string.Empty ||
                    txtPrecio.Text == string.Empty ||
                    txtStock.Text == string.Empty)
                {
                    MessageBox.Show("Los campos no pueden estar vacios");

                }
                else if (cmbProveedor.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe registrar proveedores");

                }
                else
                {
                    Articulos nuevoArticulo = new Articulos();
                    nuevoArticulo.CodArticulo = txtCodigo.Text;
                    nuevoArticulo.Descripcion = txtDescripcion.Text;
                    nuevoArticulo.Precio = Convert.ToDouble(txtPrecio.Text);
                    nuevoArticulo.Stock = Convert.ToInt32(txtStock.Text);
                    nuevoArticulo.Estado = chkestado.Checked ? 1 : 0;
                    nuevoArticulo.IdProveedor = Convert.ToInt32(cmbProveedor.SelectedValue);
                    nuevoArticulo.FechaRegistro = dtpFecha.Text;
                    nuevoArticulo.UsuarioLoginArt = IdUsuarioLog;
                    InventarioLogicaAcceso.InsertarArticulo(nuevoArticulo);
                    MessageBox.Show(Utilitario.Mensajes.strRegistroInsertado);
                    Limpiar();
                    ListarArticulo();
                }
            }
        }
        public void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
            chkestado.Checked = false;
            dtpFecha.Value = DateTime.Today;
        }
        private void salir()
        {
            Close();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            salir();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void frmAgregarArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancelar el cierre de Form1 para abrir el Form2

            frmReporteInventario inventario = new frmReporteInventario();
            inventario.Show();
            Hide();
        }
        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            listarProveedor();

        }
        public void listarProveedor()
        {
            try
            {
                cmbProveedor.DataSource = ProveedorLogicaAcceso.ListarProveedor();
                cmbProveedor.DisplayMember = "Nombre";
                cmbProveedor.ValueMember = "IdProveedor";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número, una coma o una tecla de control
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                // Si no es ninguno de los caracteres permitidos, cancelar la tecla
                e.Handled = true;
            }

            // Permitir solo una coma en el texto
            if (e.KeyChar == ',' && ((System.Windows.Forms.TextBox)sender).Text.Contains(","))
            {
                // Si ya hay una coma, cancelar la tecla
                e.Handled = true;
            }
        }
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si la tecla presionada no es un número y no es una tecla de control (como Backspace o Delete),
                // se suprime la entrada
                e.Handled = true;
            }
        }
        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            // Verificar si el formulario hijo ya está abierto
            foreach (Form form in Application.OpenForms)
            {
                if (form is FrmAgregarProveedor)
                {
                    form.Activate(); // Si está abierto, lo activamos
                    return;
                }
            }
            // Si el formulario hijo no está abierto, lo creamos y lo configuramos
            FrmAgregarProveedor nuevoProveedorForm = new FrmAgregarProveedor(IdUsuarioLog, UsuarioLog);
            nuevoProveedorForm.MdiParent = this.MdiParent; // Asignar el MDI Parent al formulario hijo
            nuevoProveedorForm.Show();
            this.Close();
        }

        private void dgvArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica si la celda es de la columna "FechaColumna"
            if (dgvArticulos.Columns[e.ColumnIndex].Name == "FechaUltimaActualizacion")
            {
                // Verifica si el valor de la celda es una fecha
                if (e.Value != null && e.Value.GetType() == typeof(DateTime))
                {
                    // Da formato a la fecha como "dd/MM/yyyy"
                    e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
            // Verifica si la celda es de la columna "FechaColumna"
            if (dgvArticulos.Columns[e.ColumnIndex].Name == "FechaRegistro")
            {
                // Verifica si el valor de la celda es una fecha
                if (e.Value != null && e.Value.GetType() == typeof(DateTime))
                {
                    // Da formato a la fecha como "dd/MM/yyyy"
                    e.Value = ((DateTime)e.Value).ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
