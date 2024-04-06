using AccesoDatos.Entidades;
using LogicaNegocios;
using MetroFramework.Forms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static iText.Commons.Utils.PlaceHolderTextUtil;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class frmLogin : Form
    {
        private UsuarioLogica usuarioLogicaAcceso;
        private string placeholderText = "USUARIO";
        private string placeholderText1 = "CONTRASEÑA";
        private bool mouseDown;
        private Point lastLocation;
        public frmLogin()
        {
            InitializeComponent();
            usuarioLogicaAcceso = new UsuarioLogica();
            StartPosition = FormStartPosition.CenterScreen;
            txtContraseña.PasswordChar = '*';
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(pbSalir, "Salir");
            this.FormBorderStyle = FormBorderStyle.None;
            txtUsuario.Text = placeholderText;
            // Asocia los eventos Enter y Leave para manejar el comportamiento del texto de la frase
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            txtContraseña.Text = placeholderText1;
            // Asocia los eventos Enter y Leave para manejar el comportamiento del texto de la frase
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            this.MouseDown += frmLogin_MouseDown;
            this.MouseMove += frmLogin_MouseMove;
            this.MouseUp += frmLogin_MouseUp;

        }
        private void btnIngreso_Click(object sender, EventArgs e)
        {
            DataTable dtUsuarios = usuarioLogicaAcceso.ListarUsuario();
            if (dtUsuarios.Rows.Count == 0)
            {
                DialogResult resultado = MessageBox.Show("No existen usuarios, ¿Desea registrar uno?", "Registrar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    frmAgregarUsuario user = new frmAgregarUsuario(0, null);
                    user.Show();
                }
            }
            else
            {
                Usuario comprobarUsuario = new Usuario();
                if (txtUsuario.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese usuario !!");
                }
                else if (txtContraseña.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese contraseña !!");
                }
                else
                {
                    comprobarUsuario.UsuarioLogin = txtUsuario.Text;
                    comprobarUsuario.Contraseña = txtContraseña.Text;
                    DataTable dtrespuestaUsuario = usuarioLogicaAcceso.ComprobarUsuario(comprobarUsuario);

                    //Obtener login
                    string strusuarioLog = txtUsuario.Text;
                    //Obtener true o false si es que existe usuario en base de datos
                    string strrespuestaUsuario = dtrespuestaUsuario.Rows[0][0].ToString();
                    //Obtener Id de usuario
                    int IdUser = Convert.ToInt32(dtrespuestaUsuario.Rows[0][1]);

                    if (strrespuestaUsuario == "true")
                    {
                        FrmInventarioPrincipalMDI principal = new FrmInventarioPrincipalMDI(strusuarioLog, IdUser);
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos");
                    }
                }
            }
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "sloachamin";
            txtContraseña.Text = "12345";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            // Borra el texto de la frase cuando el usuario hace clic en el TextBox
            if (txtUsuario.Text == placeholderText)
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            // Restaura el texto de la frase si el TextBox está vacío al salir de él
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = placeholderText;
            }
        }
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            // Borra el texto de la frase cuando el usuario hace clic en el TextBox
            if (txtContraseña.Text == placeholderText1)
            {
                txtContraseña.Text = "";
            }
        }
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            // Restaura el texto de la frase si el TextBox está vacío al salir de él
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                txtContraseña.Text = placeholderText1;
            }
        }
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngreso.PerformClick();
            }
        }
    }
}
