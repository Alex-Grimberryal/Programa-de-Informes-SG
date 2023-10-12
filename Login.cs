using Microsoft.Data.SqlClient;

namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    public partial class Login : Form
    {
        Principal Principal;
        SqlConnection connection;

        public Login()
        {
            InitializeComponent();
            Principal = new Principal();
            connection = ConexionDB.GetSqlConnection(); // Invocar el método GetSqlConnection()
        }
        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            // Realizar la consulta para validar los datos de inicio de sesión
            string query = "SELECT nombre, contrasena FROM Usuarios WHERE nombre = @username AND contrasena = @password";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                int count = (int)command.ExecuteScalar(); // Obtener el resultado de la consulta

                if (count > 0)
                {
                    // Los datos de inicio de sesión son válidos, mostrar la vista Principal
                    Principal.ShowDialog();
                }
                else
                {
                    // Los datos de inicio de sesión son inválidos, mostrar un mensaje de error
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }

                connection.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}