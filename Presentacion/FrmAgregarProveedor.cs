using AccesoDatos.Entidades;
using LogicaNegocios;
using Presentacion.Herramientas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class FrmAgregarProveedor : Form
    {
        private ProveedorLogica ProveedorLogicaAcceso;
        int Idusuario = 0;
        string IdLog = string.Empty;
        public FrmAgregarProveedor(int IdUsuarioLogin, string usuarioLog = null)
        {
            InitializeComponent();
            ProveedorLogicaAcceso = new ProveedorLogica();
            ListarProveedor();
            dgvProveedor.RowHeadersVisible = false;
            dgvProveedor.AllowUserToAddRows = false;
            Idusuario = IdUsuarioLogin;
            IdLog = usuarioLog;
            dgvProveedor.RowHeadersVisible = false;
            dgvProveedor.AllowUserToAddRows = false;
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedor.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
        }
        private void dgvArticulos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }
        private void btguardar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == string.Empty ||
                txtIdentificacion.Text == string.Empty ||
                txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
            else
            {
                if (ValidarCedula())
                {
                    Proveedor nuevoproveedor = new Proveedor();
                    nuevoproveedor.Nombre = txtNombre.Text;
                    nuevoproveedor.Identificacion = txtIdentificacion.Text;
                    nuevoproveedor.Telefono = txtTelefono.Text;
                    nuevoproveedor.Estado = chkestado.Checked ? 1 : 0;
                    ProveedorLogicaAcceso.InsertarProveedor(nuevoproveedor);
                    MessageBox.Show(Utilitario.Mensajes.strRegistroInsertado);
                    Limpiar();
                    ListarProveedor();
                }
            }
        }
        public void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            chkestado.Checked = false;
            dgvProveedor.ClearSelection();
            IdProveedorEliminar = 0;
        }
        public void ListarProveedor()
        {
            dgvProveedor.DataSource = ProveedorLogicaAcceso.ListarProveedor();
        }
        private void dgvProveedor_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }
        int IdProveedorEliminar = 0;
        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    dgvProveedor.Rows[e.RowIndex].Selected = true;
                }
                DataGridViewRow filaSeleccionada = dgvProveedor.SelectedRows[0];
                IdProveedorEliminar = Convert.ToInt32(filaSeleccionada.Cells[0].Value.ToString());
            }
            catch
            {
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IdProveedorEliminar != 0)
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas eliminar el registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Proveedor IdProveedor = new Proveedor();
                    IdProveedor.IdProveedor = Convert.ToInt32(IdProveedorEliminar);
                    ProveedorLogicaAcceso.EliminarProveedor(IdProveedor);
                    ListarProveedor();
                    Limpiar();
                    //MessageBox.Show("El registro ha sido eliminado correctamente.", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro para eliminar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAgregarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            chkestado.Checked = false;
        }
        public bool ValidarCedula()
        {
            string cedula = txtIdentificacion.Text.Trim();

            // Validar que la cédula tenga 10 dígitos numéricos
            if (!Regex.IsMatch(cedula, @"^\d{10}$"))
            {
                MessageBox.Show("La cédula debe contener 10 dígitos numéricos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar la estructura de la cédula (3 primeros dígitos deben ser 0-24)
            int provincia = int.Parse(cedula.Substring(0, 2));
            if (provincia < 0 || provincia > 24)
            {
                MessageBox.Show("Los dos primeros dígitos de la cédula deben estar entre 01 y 24.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Otros chequeos de verificación específicos de la cédula (por ejemplo, verificar el dígito verificador)

            // Si pasa todas las validaciones
            return true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si la tecla presionada no es un número y no es una tecla de control (como Backspace o Delete),
                // se suprime la entrada
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado es un número o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter si no es un número o la tecla de retroceso
            }

            // Verifica si el tamaño del texto en el TextBox ya es igual a 10
            if (txtTelefono.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignora el carácter si el tamaño del texto ya es igual a 10 y no es la tecla de retroceso
            }
        }
    }
}
