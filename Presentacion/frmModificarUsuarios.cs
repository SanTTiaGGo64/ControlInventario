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

namespace Presentacion
{
    public partial class frmModificarUsuarios : Form
    {
        UsuarioLogica usuarioLogica;
        int Idusuario = 0;
        string IdLog = string.Empty;
        public frmModificarUsuarios(int IdUsuarioLogin, string usuarioLog = null)
        {
            InitializeComponent();
            usuarioLogica = new UsuarioLogica();
            listarUsuario();
            Idusuario = IdUsuarioLogin;
            IdLog = usuarioLog;
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuario.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void listarUsuario()
        {
            try
            {
                dgvUsuario.DataSource = usuarioLogica.ListarUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtUsuarioLogin.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            chkestado.Checked = false;
        }

        private void dgvUsuario_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                txtId.Text = dgvUsuario.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvUsuario.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dgvUsuario.CurrentRow.Cells[2].Value.ToString();
                txtIdentificacion.Text = dgvUsuario.CurrentRow.Cells[3].Value.ToString();
                txtTelefono.Text = dgvUsuario.CurrentRow.Cells[4].Value.ToString();
                txtUsuarioLogin.Text = dgvUsuario.CurrentRow.Cells[5].Value.ToString();
                txtContraseña.Text = dgvUsuario.CurrentRow.Cells[6].Value.ToString();
                if (dgvUsuario.CurrentRow.Cells[7].Value.ToString() == "1")
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
        private void ModificarUsuario()
        {
            if (Idusuario == 0)
            {
                MessageBox.Show("No puede agregar registros como invitado!");
            }
            else
            {
                if (txtId.Text == string.Empty)
                {
                    MessageBox.Show("Seleccione un registro para modificar.");
                }
                else if (txtId.Text == Idusuario.ToString())
                {
                    MessageBox.Show("No se puede modificar usuario en uso.");
                }
                else if (txtNombre.Text == string.Empty ||
                        txtApellido.Text == string.Empty ||
                        txtIdentificacion.Text == string.Empty ||
                        txtTelefono.Text == string.Empty ||
                        txtUsuarioLogin.Text == string.Empty ||
                        txtContraseña.Text == string.Empty)
                {
                    MessageBox.Show("Existen campos vacios");
                }
                else
                {
                    if (ValidarCedula())
                    {
                        Usuario modifusuario = new Usuario();
                        modifusuario.IdUsuario = Convert.ToInt32(txtId.Text);
                        modifusuario.Nombre = txtNombre.Text;
                        modifusuario.Apellido = txtApellido.Text;
                        modifusuario.Identificacion = txtIdentificacion.Text;
                        modifusuario.Telefono = txtTelefono.Text;
                        modifusuario.UsuarioLogin = txtUsuarioLogin.Text;
                        modifusuario.Contraseña = txtContraseña.Text;
                        modifusuario.Estado = chkestado.Checked ? 1 : 0;

                        usuarioLogica.ModificarUsuario(modifusuario);
                        MessageBox.Show(Utilitario.Mensajes.strRegistroInsertado);
                        Limpiar();
                        listarUsuario();
                    }
                }
            }
        }
        private void btguardar_Click(object sender, EventArgs e)
        {
            ModificarUsuario();
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

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUsuarioLogin_KeyPress(object sender, KeyPressEventArgs e)
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
            // Verifica si el tamaño del texto en el TextBox ya es igual a 10
            if (txtIdentificacion.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignora el carácter si el tamaño del texto ya es igual a 10 y no es la tecla de retroceso
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
