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

namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD.opciones
{
    public partial class usuarios : UserControl
    {

        Procedimientos proc = new Procedimientos();
        public usuarios()
        {
            InitializeComponent();
        }


        private void VistaUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void usuarios_Load(object sender, EventArgs e)
        {
            // Llamar al método ObtenerUsuarios de la clase Procedimientos
            DataTable usuariosTable = proc.ObtenerUsuarios();

            // Crear un BindingSource y asignar el DataTable como origen de datos
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = usuariosTable;

            // Asignar los datos al DataGridView
            VistaUser.DataSource = usuariosTable;

            // Configurar las columnas del DataGridView
            VistaUser.Columns["nombre"].HeaderText = "Nombre";
            VistaUser.Columns["contrasena"].HeaderText = "Contraseña";
            VistaUser.Columns["rol"].HeaderText = "Rol";

            CargarRoles();
        }




        private void InUsusario_Click(object sender, EventArgs e)
        {
            // Obtener los valores del formulario
            string nombre = txtnombre.Text;
            string contrasena = txtContrasena.Text;

            // Verificar si se ha seleccionado un elemento en el ComboBox
            if (comboBox1.SelectedItem != null)
            {
                string rol = comboBox1.SelectedValue.ToString();

                // Restablecer los campos del formulario después de la inserción
                txtnombre.Text = string.Empty;
                txtContrasena.Text = string.Empty;
                comboBox1.SelectedIndex = -1;

                // Llamar al método de inserción de usuario de la clase Procedimientos
                proc.InsertarUsuario(nombre, contrasena, rol);

                // Actualizar los usuarios en el DataGridView
                ActualizarUsuarios();
            }
            else
            {
                // Mostrar un mensaje de error o realizar alguna acción apropiada
                MessageBox.Show("Por favor, seleccione un rol válido.");
            }
        }

        private int idUsuario;


        private void EdUsuario_Click(object sender, EventArgs e)
        {
            // Obtener los valores del formulario
            string nombre = txtnombre.Text;
            string contrasena = txtContrasena.Text;

            // Verificar si se ha seleccionado un elemento en el ComboBox
            if (comboBox1.SelectedItem != null)
            {
                string rol = comboBox1.SelectedValue.ToString();

                // Restablecer los campos del formulario después de la modificación
                txtnombre.Text = string.Empty;
                txtContrasena.Text = string.Empty;
                comboBox1.SelectedIndex = -1;

                // Llamar al método de modificación de usuario de la clase Procedimientos
                proc.ModificarUsuario(idUsuario, nombre, contrasena, rol);

                // Actualizar los usuarios en el DataGridView
                ActualizarUsuarios();
            }
            else
            {
                // Mostrar un mensaje de error o realizar alguna acción apropiada
                MessageBox.Show("Por favor, seleccione un rol válido.");
            }
        }

        private void ElUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;

            // Mostrar un mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres borrar este usuario?", "Confirmar borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    proc.BorrarUsuario(idUsuario, nombre);

                    // Actualizar la vista de usuarios
                    ActualizarUsuarios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al borrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Selecciona un usuario para borrar.", "Usuario no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarRoles()
        {
            // Crear la consulta SQL
            string query = "SELECT rol FROM roles";

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
                comboBox1.DataSource = dataTable;
                comboBox1.DisplayMember = "rol";
                comboBox1.ValueMember = "rol";
            }
        }

        private void ActualizarUsuarios()
        {
            // Obtener los usuarios actualizados de la base de datos
            DataTable usuariosTable = proc.ObtenerUsuarios();

            // Asignar los datos al DataGridView
            VistaUser.DataSource = usuariosTable;

            // Configurar las columnas del DataGridView
            VistaUser.Columns["nombre"].HeaderText = "Nombre";
            VistaUser.Columns["contrasena"].HeaderText = "Contraseña";
            VistaUser.Columns["rol"].HeaderText = "Rol";
        }

        private void VistaUser_SelectionChanged(object sender, EventArgs e)
        {
            if (VistaUser.SelectedRows.Count > 0)
            {
                // Obtener los valores de las celdas de la fila seleccionada
                DataGridViewRow selectedRow = VistaUser.SelectedRows[0];
                idUsuario = Convert.ToInt32(selectedRow.Cells["iduser"].Value);
                string nombre = selectedRow.Cells["nombre"].Value.ToString();
                string contrasena = selectedRow.Cells["contrasena"].Value.ToString();
                string rol = selectedRow.Cells["rol"].Value.ToString();

                // Asignar los valores a los campos del formulario
                txtnombre.Text = nombre;
                txtContrasena.Text = contrasena;
                comboBox1.SelectedValue = rol;
            }
        }
        
    }
}
