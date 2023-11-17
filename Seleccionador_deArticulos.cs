using Microsoft.Data.SqlClient;
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

namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    public partial class Seleccionador_deArticulos : Form
    {
        Procedimientos proc = new Procedimientos();

        public int IdInforme { get; set; }

        public DataTable ArticulosVendidosTable { get; set; }

        public Seleccionador_deArticulos()
        {
            InitializeComponent();
        }

        private void Seleccionador_deArticulos_Load(object sender, EventArgs e)
        {
            // Obtener la tabla de artículos vendidos del formulario principal
            DataTable articulosVendidosTable = ArticulosVendidosTable;

            // Obtener el nombre del artículo para cada ID de artículo
            DataTable articulosTable = proc.ObtenerTablaArticulos();

            // Agregar la columna "Articulo" a la tabla de artículos vendidos
            articulosVendidosTable.Columns.Add("Articulo", typeof(string));

            // Unir las tablas para obtener el nombre del artículo correspondiente
            foreach (DataRow row in articulosVendidosTable.Rows)
            {
                int idArticulo = Convert.ToInt32(row["art_idArt"]);
                DataRow[] articuloRows = articulosTable.Select($"idarticulo = {idArticulo}");

                if (articuloRows.Length > 0)
                {
                    string nombreArticulo = articuloRows[0]["nombre"].ToString();
                    row["Articulo"] = nombreArticulo;
                }
            }

            // Asignar los datos al DataGridView
            ArtVend.DataSource = articulosVendidosTable;

            CargarArticulos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cantidad = txtCantidad.Text;

            if (CBArticulo.SelectedItem != null)
            {
                string articulo = CBArticulo.SelectedValue.ToString();

                txtCantidad.Text = string.Empty;
                CBArticulo.SelectedIndex = -1;

                // Configurar las columnas del DataGridView
                ArtVend.Columns["art_idArt"].HeaderText = "ID Artículo";
                ArtVend.Columns["Articulo"].HeaderText = "Artículo";
                ArtVend.Columns["info_idInforme"].HeaderText = "ID Informe";
                ArtVend.Columns["cantidad"].HeaderText = "Cantidad";
                ArtVend.Columns["monto_total"].HeaderText = "Monto Total";

                // Ajustar el ancho de las columnas automáticamente
                ArtVend.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // Llamar al método de inserción de artículo de la clase Procedimientos
                proc.ModificarArticulo(idArticulo, nombre, precio, marca, categoria);

                // Actualizar los artículos en el DataGridView
                ActualizarArticulos();
            }
            else
            {
                // Mostrar un mensaje de error o realizar alguna acción apropiada
                MessageBox.Show("Por favor, seleccione un articulo válido.");
            }
        }

        private void ModArtvend_Click(object sender, EventArgs e)
        {

        }

        private void ElArtvend_Click(object sender, EventArgs e)
        {

        }

        private void ArtVend_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarArticulos()
        {
            // Crear la consulta SQL
            string query = "SELECT nombre FROM articulos";

            // Obtener la cadena de conexión de la clase Procedimientos
            string connectionString = proc.server;

            // Crear la conexión y el comando
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Abrir la conexión
                connection.Open();

                // Crear un DataTable para almacenar los resultados
                DataTable dataTable = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

                // Asignar el DataTable al ComboBox
                CBArticulo.DataSource = dataTable;
                CBArticulo.DisplayMember = "articulo";
                CBArticulo.ValueMember = "articulo";
            }
        }
    }
}
