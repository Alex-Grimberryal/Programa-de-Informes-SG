using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD.opciones
{
    public partial class articulos : UserControl
    {
        Procedimientos proc = new Procedimientos();

        public articulos()
        {
            InitializeComponent();
        }

        private void articulos_Load(object sender, EventArgs e)
        {
            // Llamar al método ObtenerUsuarios de la clase Procedimientos
            DataTable articulosTable = proc.ObtenerArticulos();

            // Crear un BindingSource y asignar el DataTable como origen de datos
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = articulosTable;

            // Asignar los datos al DataGridView
            VistaArticulos.DataSource = articulosTable;

            // Configurar las columnas del DataGridView
            VistaArticulos.Columns["idarticulo"].HeaderText = "ID";
            VistaArticulos.Columns["nombre_articulo"].HeaderText = "Nombre";
            VistaArticulos.Columns["precio"].HeaderText = "Precio";
            VistaArticulos.Columns["categoria"].HeaderText = "Categoria";
            VistaArticulos.Columns["marca"].HeaderText = "Marca";

            CargarCategorias();
            CargarMarcas();
        }

        private void InArticulo_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            decimal precio;

            if (decimal.TryParse(txtPrecio.Text, out precio))
            {
                if (CBCategoria.SelectedItem != null)
                {
                    string categoria = CBCategoria.SelectedValue.ToString();

                    if (CBMarca.SelectedItem != null)
                    {
                        string marca = CBMarca.SelectedValue.ToString();

                        // Restablecer los campos del formulario después de la inserción
                        txtnombre.Text = string.Empty;
                        txtPrecio.Text = string.Empty;
                        CBCategoria.SelectedIndex = -1;
                        CBMarca.SelectedIndex = -1;

                        // Llamar al método de inserción de artículo de la clase Procedimientos
                        proc.InsertarArticulo(nombre, precio, marca, categoria);

                        // Actualizar los artículos en el DataGridView
                        ActualizarArticulos();
                    }
                    else
                    {
                        // Mostrar un mensaje de error o realizar alguna acción apropiada
                        MessageBox.Show("Por favor, seleccione una marca válida.");
                    }
                }
                else
                {
                    // Mostrar un mensaje de error o realizar alguna acción apropiada
                    MessageBox.Show("Por favor, seleccione una categoría válida.");
                }
            }
            else
            {
                // Mostrar un mensaje de error o realizar alguna acción apropiada
                MessageBox.Show("Por favor, ingrese un precio válido.");
            }
        }

        private int idArticulo;

        private void ModArticulo_Click(object sender, EventArgs e)
        {

            string nombre = txtnombre.Text;
            decimal precio;

            if (decimal.TryParse(txtPrecio.Text, out precio))
            {
                if (CBCategoria.SelectedItem != null)
                {
                    string categoria = CBCategoria.SelectedValue.ToString();

                    if (CBMarca.SelectedItem != null)
                    {
                        string marca = CBMarca.SelectedValue.ToString();

                        // Restablecer los campos del formulario después de la inserción
                        txtnombre.Text = string.Empty;
                        txtPrecio.Text = string.Empty;
                        CBCategoria.SelectedIndex = -1;
                        CBMarca.SelectedIndex = -1;

                        // Llamar al método de inserción de artículo de la clase Procedimientos
                        proc.ModificarArticulo(idArticulo, nombre, precio, marca, categoria);

                        // Actualizar los artículos en el DataGridView
                        ActualizarArticulos();
                    }
                    else
                    {
                        // Mostrar un mensaje de error o realizar alguna acción apropiada
                        MessageBox.Show("Por favor, seleccione una marca válida.");
                    }
                }
                else
                {
                    // Mostrar un mensaje de error o realizar alguna acción apropiada
                    MessageBox.Show("Por favor, seleccione una categoría válida.");
                }
            }
            else
            {
                // Mostrar un mensaje de error o realizar alguna acción apropiada
                MessageBox.Show("Por favor, ingrese un precio válido.");
            }

        }

        private void ElArticulo_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;

            // Mostrar un mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres borrar este Articulo?", "Confirmar borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    proc.BorrarArticulo(idArticulo);

                    // Actualizar la vista de usuarios
                    ActualizarArticulos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al borrar el Articulo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Selecciona un Articulo para borrar.", "Articulo no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActualizarArticulos()
        {
            // Obtener los usuarios actualizados de la base de datos
            DataTable articulosTable = proc.ObtenerArticulos();

            // Asignar los datos al DataGridView
            VistaArticulos.DataSource = articulosTable;

            // Configurar las columnas del DataGridView
            VistaArticulos.Columns["idarticulo"].HeaderText = "ID";
            VistaArticulos.Columns["nombre_articulo"].HeaderText = "Nombre";
            VistaArticulos.Columns["precio"].HeaderText = "Precio";
            VistaArticulos.Columns["categoria"].HeaderText = "Categoria";
            VistaArticulos.Columns["marca"].HeaderText = "Marca";
        }

        private void CargarCategorias()
        {
            // Crear la consulta SQL
            string query = "SELECT categoria FROM categoria";

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
                CBCategoria.DataSource = dataTable;
                CBCategoria.DisplayMember = "categoria";
                CBCategoria.ValueMember = "categoria";
            }
        }
        private void CargarMarcas()
        {
            // Crear la consulta SQL
            string query = "SELECT marca FROM marca";

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
                CBMarca.DataSource = dataTable;
                CBMarca.DisplayMember = "marca";
                CBMarca.ValueMember = "marca";
            }
        }

        private void VistaArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (VistaArticulos.SelectedRows.Count > 0)
            {
                // Obtener los valores de las celdas de la fila seleccionada
                DataGridViewRow selectedRow = VistaArticulos.SelectedRows[0];
                idArticulo = Convert.ToInt32(selectedRow.Cells["idarticulo"].Value);
                string nombre = selectedRow.Cells["nombre_articulo"].Value.ToString();
                string precioString = selectedRow.Cells["precio"].Value.ToString();
                string categoria = selectedRow.Cells["categoria"].Value.ToString();
                string marca = selectedRow.Cells["Marca"].Value.ToString();

                // Convertir el valor del precio a decimal
                decimal precio;
                if (decimal.TryParse(precioString, out precio))
                {
                    // Asignar los valores a los campos del formulario
                    txtnombre.Text = nombre;
                    txtPrecio.Text = precio.ToString();
                    CBCategoria.SelectedValue = categoria;
                    CBMarca.SelectedValue = marca;
                }
                else
                {
                    // Mostrar un mensaje de error o realizar alguna acción apropiada si el valor del precio no es válido
                    MessageBox.Show("El valor del precio no es válido.");
                }
            }
        }
    }
}
