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

namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    public partial class UserControl1 : UserControl
    {
        Procedimientos proc = new Procedimientos();


        public int idUsuario;

        public UserControl1(int idUser)
        {
            idUsuario = idUser;
            InitializeComponent();
        }


        private void UserControl1_Load(object sender, EventArgs e)
        {
            // Obtener el siguiente número de informe desde la base de datos
            int siguienteNumeroInforme = proc.ObtenerSiguienteNumeroInforme();

            // Asignar el número de informe al TextBox
            nroRegistro.Text = siguienteNumeroInforme.ToString();

            // Deshabilitar la edición del TextBox
            nroRegistro.Enabled = false;

            CargarTecnicos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        

        private void AbrirModalArticulos_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtCliente.Text) || string.IsNullOrEmpty(txtDNI.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreCompleto = txtCliente.Text;
            string apellidoPaterno = string.Empty;
            string apellidoMaterno = string.Empty;
            string nombres = string.Empty;

            // Separar el nombre completo en apellidos y nombres
            string[] partesNombre = nombreCompleto.Split(' ');

            // Verificar si se obtuvieron al menos tres partes (apellido paterno, apellido materno, nombres)
            if (partesNombre.Length >= 3)
            {
                apellidoPaterno = partesNombre[0];
                apellidoMaterno = partesNombre[1];

                // Combinar las partes restantes como nombres
                string[] nombresArray = new string[partesNombre.Length - 2];
                Array.Copy(partesNombre, 2, nombresArray, 0, partesNombre.Length - 2);
                nombres = string.Join(" ", nombresArray);
            }
            else
            {
                // El nombre completo no tiene suficientes partes
                // Maneja el error o muestra un mensaje al usuario
                // ...
                return;
            }

            

            txtMonto.Text = "0,00";

            // Obtener los demás valores necesarios para la inserción
            string dni = txtDNI.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            decimal montoTotal = decimal.Parse(txtMonto.Text);
            string direccionInstalacion = txtDireccion.Text;
            string notasAdicionales = NtAdd.Text;
            int redactor = idUsuario;
            int articulosVend = 0;
            int tecnico = CBtecnico.SelectedIndex;

            proc.InsertarInformeAMedias(apellidoPaterno, apellidoMaterno, nombres, dni, telefono, email, montoTotal, direccionInstalacion, notasAdicionales, redactor, articulosVend, tecnico);
            // Crear una instancia de la ventana emergente
            Seleccionador_deArticulos ventanaEmergente = new Seleccionador_deArticulos();

            // Configurar propiedades de la ventana emergente (tamaño, título, etc.)
            ventanaEmergente.Size = new Size(900, 1200);
            ventanaEmergente.Text = "Seleccionador de Artículos";

            // Mostrar la ventana emergente
            ventanaEmergente.ShowDialog();

        }

        private void CargarTecnicos()
        {
            // Crear la consulta SQL
            string query = "SELECT idTecnico, CONCAT(nombres, ' ', apellido_paterno, ' ', apellido_materno) AS nombreCompleto FROM tecnico";

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
                CBtecnico.DataSource = dataTable;
                CBtecnico.DisplayMember = "nombreCompleto";
                CBtecnico.ValueMember = "idTecnico";
            }
        }
    }
}
