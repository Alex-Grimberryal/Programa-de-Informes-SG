using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    public partial class UserControl2 : UserControl
    {
        SqlConnection conn;

        public UserControl2()
        {
            InitializeComponent();
            conn = ConexionDB.GetSqlConnection();

        }

        public event EventHandler UserControlLoaded;

        private void UserControl2_Load(object sender, EventArgs e)
        {
            // Lógica del evento UserControlLoaded
            UserControlLoaded?.Invoke(this, EventArgs.Empty);

            // Realizar la consulta a la base de datos y obtener los datos
            using (SqlConnection conn = ConexionDB.GetSqlConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT nro_de_informe, nombre_de_cliente, apellido_paterno, monto_total FROM informe", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Verificar si se obtuvieron datos
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Obtener los valores de las columnas para cada registro
                            string? nroInforme = reader["nro_de_informe"].ToString();
                            string? nombreCliente = reader["nombre_de_cliente"].ToString();
                            string? apellidoPaterno = reader["apellido_paterno"].ToString();
                            string? montoTotal = reader["monto_total"].ToString();

                            // Crear un nuevo panel para cada registro
                            Panel panel = new Panel();
                            panel.BackColor = Color.LightGray;
                            panel.Padding = new Padding(10);
                            panel.Margin = new Padding(10);
                            panel.Width = 300;

                            // Crear las etiquetas dentro del panel y configurar sus propiedades
                            Label labelNroInforme = new Label();
                            labelNroInforme.Text = $"Nro. Informe: {nroInforme}";
                            labelNroInforme.AutoSize = true;

                            Label labelNombreCliente = new Label();
                            labelNombreCliente.Text = $"Cliente: {nombreCliente} {apellidoPaterno}";
                            labelNombreCliente.AutoSize = true;

                            Label labelMontoTotal = new Label();
                            labelMontoTotal.Text = $"Monto Total: {montoTotal}";
                            labelMontoTotal.AutoSize = true;

                            // Agregar las etiquetas al panel
                            panel.Controls.Add(labelNroInforme);
                            panel.Controls.Add(labelNombreCliente);
                            panel.Controls.Add(labelMontoTotal);

                            // Agregar el panel al contenedor (puede ser un FlowLayoutPanel u otro contenedor adecuado)
                            this.Controls.Add(panel);
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Manejar la excepción, mostrar un mensaje de error o realizar alguna acción adecuada
                    Console.WriteLine("Error en la conexión o consulta a la base de datos: " + ex.Message);
                }
                finally
                {
                    // Cerrar la conexión en el bloque finally para asegurarse de que se cierre incluso en caso de excepción
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
