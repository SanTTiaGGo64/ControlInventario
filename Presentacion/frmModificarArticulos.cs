using AccesoDatos.Entidades;
using LogicaNegocios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmModificarArticulos : Form
    {
        private ArticulosLogica InventarioLogicaAcceso;
        private ProveedorLogica ProveedorLogicaAcceso;
        private int IdProveedor;
        private int valorStock;
        int IdUsuarioLog;
        string usuarioLog;

        public frmModificarArticulos(int IdUsuario, string UsuarioActual)
        {
            InitializeComponent();
            InventarioLogicaAcceso = new ArticulosLogica();
            ProveedorLogicaAcceso = new ProveedorLogica();
            listarProveedor();
            this.StartPosition = FormStartPosition.CenterScreen;
            IdUsuarioLog = IdUsuario;
            usuarioLog = UsuarioActual;
            txtStockModif.Leave += txtStockModif_Leave;
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticulos.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
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
        private void frmModificarArticulos_Load(object sender, EventArgs e)
        {
            valorStock = 0;
            listarProveedor();
            ListarArticulo();
            cmbProveedor.SelectedValue = 0;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtIdArticuloModif.Text = string.Empty;
            txtCodArticuloModif.Text = string.Empty;
            txtDescripcionModif.Text = string.Empty;
            txtPrecioModif.Text = string.Empty;
            txtStockModif.Text = string.Empty;
            chkEstadoModif.Checked = false;
            cmbProveedor.SelectedValue = 0;
        }
        private void frmModificarArticulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            frmReporteInventario inventario = new frmReporteInventario();
            inventario.Show();
            this.Hide();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIdArticuloModif.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un registro para modificar");
            }
            else if (txtCodArticuloModif.Text == string.Empty ||
                txtDescripcionModif.Text == string.Empty ||
                txtPrecioModif.Text == string.Empty ||
                txtStockModif.Text == string.Empty)
            {
                MessageBox.Show("Existen campos vacios");
            }
            else
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas modificar el registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Articulos nuevoArticulo = new Articulos();
                    nuevoArticulo.CodArticulo = txtCodArticuloModif.Text.ToString();
                    nuevoArticulo.Descripcion = txtDescripcionModif.Text.ToString();
                    nuevoArticulo.Precio = Convert.ToDouble(txtPrecioModif.Text);
                    nuevoArticulo.Stock = Convert.ToInt32(txtStockModif.Text);
                    nuevoArticulo.IdArticulo = Convert.ToInt32(txtIdArticuloModif.Text);
                    nuevoArticulo.Estado = chkEstadoModif.Checked ? 1 : 0;
                    nuevoArticulo.IdProveedor = Convert.ToInt32(cmbProveedor.SelectedValue);
                    nuevoArticulo.FechaActualizacion = DateTime.Today.ToString();
                    InventarioLogicaAcceso.ModificarArticulo(nuevoArticulo);
                    MessageBox.Show("Articulo modificado correctamente");
                    ListarArticulo();
                    Limpiar();
                }
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string valorStock1 = txtStockModif.Text.ToString();
            if (valorStock1 != string.Empty)
            {
                valorStock = Convert.ToInt32(txtStockModif.Text);
                valorStock++;
                txtStockModif.Text = valorStock.ToString();
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            string valorStock1 = txtStockModif.Text.ToString();
            if (valorStock1 != string.Empty)
            {
                valorStock = Convert.ToInt32(txtStockModif.Text);
                valorStock--;
                txtStockModif.Text = valorStock.ToString();
            }
        }
        private void txtStockModif_Leave(object sender, EventArgs e)
        {
            valorStock = 0;
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

        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count > 0)
            {
                txtIdArticuloModif.Text = dgvArticulos.CurrentRow.Cells[0].Value.ToString();
                txtCodArticuloModif.Text = dgvArticulos.CurrentRow.Cells[1].Value.ToString();
                txtDescripcionModif.Text = dgvArticulos.CurrentRow.Cells[2].Value.ToString();
                txtPrecioModif.Text = dgvArticulos.CurrentRow.Cells[3].Value.ToString();
                txtStockModif.Text = dgvArticulos.CurrentRow.Cells[4].Value.ToString();
                if (dgvArticulos.CurrentRow.Cells[5].Value.ToString() == "1")
                {
                    chkEstadoModif.Checked = true;
                }
                else
                {
                    chkEstadoModif.Checked = false;
                }
                cmbProveedor.SelectedValue = dgvArticulos.CurrentRow.Cells[6].Value.ToString();
            }
            else
            {
                MessageBox.Show("No existen registros");
            }
        }

        private void txtStockModif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtPrecioModif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && ((System.Windows.Forms.TextBox)sender).Text.Contains(","))
            {
                e.Handled = true;
            }
        }
    }
}
