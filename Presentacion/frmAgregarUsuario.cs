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
    public partial class frmAgregarUsuario : Form
    {
        UsuarioLogica usuarioLogica;
        int Idusuario = 0;
        string IdLog = string.Empty;
        public frmAgregarUsuario(int IdUsuarioLogin, string usuarioLog = null)
        {
            InitializeComponent();
            usuarioLogica = new UsuarioLogica();
            Idusuario = IdUsuarioLogin;
            IdLog = usuarioLog;
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuario.DefaultCellStyle.SelectionBackColor = Color.LightBlue;

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
        private void frmAgregarUsuario_Load(object sender, EventArgs e)
        {
            listarUsuario();
        }
        private void InsertarUsuario()
        {
            DataTable dtUsuarios = usuarioLogica.ListarUsuario();
            if (dtUsuarios.Rows.Count == 0)
            {
                if (txtNombre.Text == string.Empty ||
                        txtApellido.Text == string.Empty ||
                        txtIdentificacion.Text == string.Empty ||
                        txtTelefono.Text == string.Empty ||
                        txtUsuarioLogin.Text == string.Empty ||
                        txtContraseña.Text == string.Empty)
                {
                    MessageBox.Show("Los campos no pueden estar vacios");
                }
                else
                {
                    if (ValidarCedula())
                    {
                        Usuario nuevousuario = new Usuario();
                        nuevousuario.Nombre = txtNombre.Text;
                        nuevousuario.Apellido = txtApellido.Text;
                        nuevousuario.Identificacion = txtIdentificacion.Text;
                        nuevousuario.Telefono = txtTelefono.Text;
                        nuevousuario.UsuarioLogin = txtUsuarioLogin.Text;
                        nuevousuario.Contraseña = txtContraseña.Text;
                        nuevousuario.Estado = chkestado.Checked ? 1 : 0;

                        usuarioLogica.InsertarUsuario(nuevousuario);
                        MessageBox.Show(Utilitario.Mensajes.strRegistroInsertado);
                        frmLogin login = new frmLogin();
                        login.Show();
                        this.Close();
                    }
                }
            }
            else
            {
                if (Idusuario == 0)
                {
                    MessageBox.Show("No puede agregar registros como invitado!");
                }
                else
                {
                    if (txtNombre.Text == string.Empty ||
                        txtApellido.Text == string.Empty ||
                        txtIdentificacion.Text == string.Empty ||
                        txtTelefono.Text == string.Empty ||
                        txtUsuarioLogin.Text == string.Empty ||
                        txtContraseña.Text == string.Empty)
                    {
                        MessageBox.Show("Los campos no pueden estar vacios");
                    }
                    else
                    {
                        if (ValidarCedula())
                        {
                            Usuario nuevousuario = new Usuario();
                            nuevousuario.Nombre = txtNombre.Text;
                            nuevousuario.Apellido = txtApellido.Text;
                            nuevousuario.Identificacion = txtIdentificacion.Text;
                            nuevousuario.Telefono = txtTelefono.Text;
                            nuevousuario.UsuarioLogin = txtUsuarioLogin.Text;
                            nuevousuario.Contraseña = txtContraseña.Text;
                            nuevousuario.Estado = chkestado.Checked ? 1 : 0;

                            usuarioLogica.InsertarUsuario(nuevousuario);
                            MessageBox.Show(Utilitario.Mensajes.strRegistroInsertado);
                            Limpiar();
                        }
                    }
                }
            }
        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtUsuarioLogin.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            chkestado.Checked = false;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            InsertarUsuario();
            listarUsuario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        int IdProveedorEliminar = 0;
        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    dgvUsuario.Rows[e.RowIndex].Selected = true;
                }
                DataGridViewRow filaSeleccionada = dgvUsuario.SelectedRows[0];
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
                    Usuario Idusuario = new Usuario();
                    Idusuario.IdUsuario = Convert.ToInt32(IdProveedorEliminar);
                    usuarioLogica.EliminarUsuario(Idusuario);
                    listarUsuario();
                    Limpiar();
                    //MessageBox.Show("El registro ha sido eliminado correctamente.", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro para eliminar");
            }
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
