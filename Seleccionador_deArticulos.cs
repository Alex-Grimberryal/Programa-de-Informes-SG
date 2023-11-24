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

        public int IdInforme;

        public Seleccionador_deArticulos()
        {
            InitializeComponent();
            IdInforme = proc.ObtenerUltimoInformeId();
        }

        private void Seleccionador_deArticulos_Load(object sender, EventArgs e)
        {
            // Llamar al método ObtenerUsuarios de la clase Procedimientos
            DataTable articulosTable = proc.ObtenerArticulosVendidosUI();

            // Crear un BindingSource y asignar el DataTable como origen de datos
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = articulosTable;

            // Asignar los datos al DataGridView
            ArtVend.DataSource = articulosTable;

            // Configurar las columnas del DataGridView
            ArtVend.Columns["info_idInforme"].HeaderText = "ID Informe";
            ArtVend.Columns["art_idArt"].HeaderText = "ID Articulo";
            ArtVend.Columns["nombre_articulo"].HeaderText = "Nombre";
            ArtVend.Columns["cantidad"].HeaderText = "Cantidad";
            ArtVend.Columns["monto_total"].HeaderText = "Monto Total";


            // Ajustar el ancho de las columnas automáticamente
            ArtVend.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


            CargarArticulos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad)) // Convertir txtCantidad a int
            {
                if (CBArticulo.SelectedItem != null)
                {
                    int articulo = Convert.ToInt32(CBArticulo.SelectedValue);
                    txtCantidad.Text = string.Empty;
                    CBArticulo.SelectedIndex = -1;

                    // Obtener el precio del artículo seleccionado
                    decimal precio = ObtenerPrecioArticulo(articulo);

                    // Calcular el monto multiplicando el precio por la cantidad seleccionada
                    decimal monto = precio * Convert.ToDecimal(cantidad);

                    // Llamar al método de inserción de artículo de la clase Procedimientos
                    proc.InsertarArticulosVendidos(IdInforme, articulo, cantidad, monto);

                    ActualizarArticulosVendidos();
                }
                else
                {
                    // Mostrar un mensaje de error o realizar alguna acción apropiada
                    MessageBox.Show("Por favor, seleccione un articulo válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
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
            string query = "SELECT idarticulo, nombre, precio, stock FROM articulos";

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
                CBArticulo.DisplayMember = "nombre";
                CBArticulo.ValueMember = "idarticulo";
            }
        }

        private decimal ObtenerPrecioArticulo(int articulo)
        {
            // Crear la consulta SQL para obtener el precio del artículo
            string query = "SELECT precio FROM articulos WHERE idarticulo = @articulo";

            // Obtener la cadena de conexión de la clase Procedimientos
            string connectionString = proc.server;

            // Crear la conexión y el comando
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Agregar el parámetro para el ID del artículo
                command.Parameters.AddWithValue("@articulo", articulo);

                // Abrir la conexión
                connection.Open();

                // Ejecutar la consulta y obtener el resultado (precio)
                object result = command.ExecuteScalar();

                // Verificar si se obtuvo un resultado válido
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }
            }

            // Si no se encuentra el artículo o no se obtiene el precio, retornar 0
            return 0;
        }
        private void ActualizarArticulosVendidos()
        {
            // Obtener los usuarios actualizados de la base de datos
            DataTable articulosTable = proc.ObtenerArticulosVendidosUI();

            // Asignar los datos al DataGridView
            ArtVend.DataSource = articulosTable;

            // Configurar las columnas del DataGridView
            ArtVend.Columns["info_idInforme"].HeaderText = "ID Informe";
            ArtVend.Columns["art_idArt"].HeaderText = "ID Articulo";
            ArtVend.Columns["nombre_articulo"].HeaderText = "Nombre";
            ArtVend.Columns["cantidad"].HeaderText = "Cantidad";
            ArtVend.Columns["monto_total"].HeaderText = "Monto Total";
        }

    }
}
