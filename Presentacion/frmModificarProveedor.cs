using AccesoDatos.Entidades;
using LogicaNegocios;
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

namespace Presentacion
{
    public partial class frmModificarProveedor : Form
    {
        ProveedorLogica ProveedorLogicaAcceso;
        public frmModificarProveedor()
        {
            InitializeComponent();
            ProveedorLogicaAcceso = new ProveedorLogica();
            ListarProveedor();
            txtId.Enabled = false;
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedor.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
        }
        public void ListarProveedor()
        {
            dgvProveedor.DataSource = ProveedorLogicaAcceso.ListarProveedor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void dgvProveedor_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                txtId.Text = dgvProveedor.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvProveedor.CurrentRow.Cells[1].Value.ToString();
                txtIdentificacion.Text = dgvProveedor.CurrentRow.Cells[2].Value.ToString();
                txtTelefono.Text = dgvProveedor.CurrentRow.Cells[3].Value.ToString();
                if (dgvProveedor.CurrentRow.Cells[4].Value.ToString() == "1")
                {
                    chkestado.Checked = true;
                }
                else
                {
                    chkestado.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("No existen registros");
            }
        }
        private void btguardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un registro para modificar");
            }
            else if (txtNombre.Text == string.Empty ||
                    txtIdentificacion.Text == string.Empty ||
                    txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Existen campos vacios");
            }
            else
            {
                if (ValidarCedula())
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas modificar el registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        Proveedor nuevoProveedor = new Proveedor();
                        nuevoProveedor.IdProveedor = Convert.ToInt32(txtId.Text);
                        nuevoProveedor.Nombre = txtNombre.Text;
                        nuevoProveedor.Identificacion = txtIdentificacion.Text;
                        nuevoProveedor.Telefono = txtTelefono.Text;
                        nuevoProveedor.Estado = chkestado.Checked ? 1 : 0;

                        ProveedorLogicaAcceso.ModificarProveedor(nuevoProveedor);
                        MessageBox.Show("Proveedor modificado correctamente");
                        ListarProveedor();
                        Limpiar();
                    }
                }
            }
        }
        private void Limpiar()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            chkestado.Checked = false;
        }
        private void frmModificarProveedor_Load(object sender, EventArgs e)
        {

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
