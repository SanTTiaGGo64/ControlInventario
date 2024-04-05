using AccesoDatos.Entidades;
using LogicaNegocios;
using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using MetroFramework.Forms;
using System.Drawing;
using System.Collections.Generic;
using AccesoDatos;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace Presentacion
{
    public partial class frmReporteInventario : Form
    {
        private ArticulosLogica articulosLogicaAcceso;
        private ProveedorLogica proveedorLogicaAcceso;
        private UsuarioLogica usuarioLogicaAcceso;
        string UsuarioActual;
        int IdUsuario;

        public frmReporteInventario(int idusuarioLog = 0, string usuarioLog = null)
        {
            InitializeComponent();
            articulosLogicaAcceso = new ArticulosLogica();
            usuarioLogicaAcceso = new UsuarioLogica();
            StartPosition = FormStartPosition.CenterScreen;
            dgvArticulos.RowHeadersVisible = false;
            dgvArticulos.AllowUserToAddRows = false;
            UsuarioActual = usuarioLog;
            IdUsuario = idusuarioLog;
            dgvArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArticulos.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            CargarAnios();
            LlenarComboBoxMeses();
        }
        public void ListarArticulos()
        {
            try
            {
                dgvArticulos.DataSource = articulosLogicaAcceso.ListarArticulo();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LlenarComboBoxMeses()
        {
            List<string> meses = new List<string>
            {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
            };
            cmbMes.DataSource = meses;
        }
        public void Limpiar()
        {
            dgvArticulos.ClearSelection();
            IdArticuloEliminar = 0;
            txtFiltroTabla.Text = string.Empty;
            cmbAnio.SelectedIndex = -1;
            cmbMes.SelectedIndex = -1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListarArticulos();
            CargarAnios();

            if (UsuarioActual == null)
            {
                lblUsuario.Text = "Invitado";
            }
            else
            {
                lblUsuario.Text = UsuarioActual;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IdArticuloEliminar != 0)
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas eliminar el registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Articulos IdArticulo = new Articulos();
                    IdArticulo.IdArticulo = Convert.ToInt32(IdArticuloEliminar);
                    articulosLogicaAcceso.EliminarCliente(IdArticulo);
                    ListarArticulos();
                    CargarAnios();
                    Limpiar();
                    MessageBox.Show("El registro ha sido eliminado correctamente.", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro para eliminar");
            }
        }
        private void dgvArticulos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ListarArticulos();
            CargarAnios();
            Limpiar();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private DataView dvFiltrado;
        public void txtFiltroTabla_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiltroTabla.Text))
            {
                dvFiltrado = articulosLogicaAcceso.ListarArticulo().DefaultView;
                dvFiltrado.RowFilter = string.Format("Descripcion like '%{0}%'", txtFiltroTabla.Text);
                dgvArticulos.DataSource = dvFiltrado;
            }
            else
            {
                dgvArticulos.DataSource = articulosLogicaAcceso.ListarArticulo();
            }
        }
        int IdArticuloEliminar = 0;
        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    dgvArticulos.Rows[e.RowIndex].Selected = true;
                }
                DataGridViewRow filaSeleccionada = dgvArticulos.SelectedRows[0];
                IdArticuloEliminar = Convert.ToInt32(filaSeleccionada.Cells[0].Value.ToString());
            }
            catch
            {
            }
        }
        private void btExportalExcel_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.RowCount == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
            }
            else
            {
                DataTable dataTable = new DataTable();
                foreach (DataGridViewColumn columna in dgvArticulos.Columns)
                {
                    dataTable.Columns.Add(columna.Name);
                }

                foreach (DataGridViewRow fila in dgvArticulos.Rows)
                {
                    DataRow dataRow = dataTable.NewRow();
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        dataRow[celda.ColumnIndex] = celda.Value;
                    }
                    dataTable.Rows.Add(dataRow);
                }
                DataView dataView = new DataView(dataTable);
                dgvArticulos.DataSource = dataView;
                ExportadorExcel.ExportarExcel(dataView);
            }
        }
        private void FiltrarPorMesYAnio(int mes, int anio)
        {
            // Obtener los datos del DataGridView
            DataTable tabla = (DataTable)dgvArticulos.DataSource;

            // Filtrar los datos por el mes especificado
            var resultados = from DataRow row in tabla.Rows
                             let fechaRegistro = DateTime.Parse(row["FechaRegistro"].ToString())
                             where fechaRegistro.Month == mes && fechaRegistro.Year == anio
                             select row;

            // Crear una nueva tabla con los datos filtrados
            DataTable tablaFiltrada = tabla.Clone();
            foreach (DataRow row in resultados)
            {
                tablaFiltrada.ImportRow(row);
            }

            // Mostrar los datos filtrados en el DataGridView
            dgvArticulos.DataSource = tablaFiltrada;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ListarArticulos();
            CargarAnios();
            Limpiar();
        }
        private void CargarAnios()
        {
            try
            {
                // Obtener los años existentes
                List<int> anios = articulosLogicaAcceso.ObtenerAniosExistenes();
                // Limpiar el ComboBox
                cmbAnio.Items.Clear();

                // Agregar los años al ComboBox
                foreach (int anio in anios)
                {
                    cmbAnio.Items.Add(anio);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar ComboBox de años: " + ex.Message);
            }
        }
        private void btnReporteMes_Click(object sender, EventArgs e)
        {
            dgvArticulos.DataSource = articulosLogicaAcceso.ListarArticulo();
            txtFiltroTabla.Text = string.Empty;
            if (cmbMes.SelectedIndex == -1 || cmbAnio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione mes y año.");
            }
            else
            {
                dgvArticulos.DataSource = articulosLogicaAcceso.ListarArticulo();
                string strAnio = cmbAnio.SelectedItem.ToString();
                int SelectedMes = cmbMes.SelectedIndex + 1;
                string MesSeleccionado = SelectedMes.ToString();

                if (!string.IsNullOrEmpty(MesSeleccionado) && !string.IsNullOrEmpty(strAnio))
                {
                    if (int.TryParse(MesSeleccionado, out int mes) && int.TryParse(strAnio, out int anio))
                    {
                        // Filtrar el DataGridView por el mes y el año especificados
                        FiltrarPorMesYAnio(mes, anio);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un mes y un año válidos (números enteros).");
                    }
                }
                else
                {
                    // Si uno de los TextBox está vacío, se muestra la lista completa de artículos
                    dgvArticulos.DataSource = articulosLogicaAcceso.ListarArticulo();
                }
            }

        }
    }
}

