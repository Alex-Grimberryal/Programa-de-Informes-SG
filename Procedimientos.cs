using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    internal class Procedimientos
    {
        public string server = "Data Source=LAPTOP-3R8N4QM6\\SQLEXPRESS; Initial Catalog=NSG; Integrated Security=True; TrustServerCertificate=True";
        public SqlConnection Conexion = new SqlConnection(@"Server=LAPTOP-3R8N4QM6\SQLEXPRESS;Database=NSG; Integrated Security=True; TrustServerCertificate=True");
        

        public int Login(string txtUser, string txtPassword)
        {
            try
            {
                Conexion.Open();

                SqlCommand cmd = new SqlCommand("spLogin", Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@txtUser", txtUser);
                cmd.Parameters.AddWithValue("@txtPassword", txtPassword);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return dr.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Conexion.Close();
            }

            return -1;
        }

        public void InsertarUsuario(string nombre, string contrasena, string rol)
        {
            try
            {
                Conexion.ConnectionString = server;
                Conexion.Open();

                SqlCommand command = new SqlCommand("InsertarUsuario", Conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Contrasena", contrasena);
                command.Parameters.AddWithValue("@Rol", rol);

                SqlParameter returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                command.ExecuteNonQuery();

                int returnValue = Convert.ToInt32(returnParameter.Value);

                if (returnValue == 0)
                {
                    MessageBox.Show("Usuario insertado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el usuario.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Conexion.Close();
            }
        }

        public void ModificarUsuario(int idUsuario, string nombre, string contrasena, string rol)
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                using (SqlCommand command = new SqlCommand("ModificarUsuario", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros al comando
                    command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Contrasena", contrasena);
                    command.Parameters.AddWithValue("@Rol", rol);

                    // Agregar parámetro de retorno para recibir el valor de @@ROWCOUNT
                    SqlParameter rowCountParameter = new SqlParameter("@RowCount", SqlDbType.Int);
                    rowCountParameter.Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add(rowCountParameter);

                    connection.Open();
                    command.ExecuteNonQuery();

                    // Obtener el valor de @@ROWCOUNT
                    int rowCount = (int)rowCountParameter.Value;

                    if (rowCount > 0)
                    {
                        Console.WriteLine("El usuario se modificó correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("No se pudo modificar el usuario. Verifique los datos proporcionados.");
                    }
                }
            }
        }

        public void BorrarUsuario(int idUsuario, string nombre)
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                SqlCommand command = new SqlCommand("BorrarUsuario", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idUsuario", idUsuario);
                command.Parameters.AddWithValue("@Nombre", nombre);

                connection.Open();
                string result = (string)command.ExecuteScalar();
                MessageBox.Show(result, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
        }

        public DataTable ObtenerUsuarios()
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                SqlCommand command = new SqlCommand("SELECT u.iduser, u.nombre, u.contrasena, roles.rol FROM usuarios u JOIN roles ON u.roles_idrol = roles.idrol", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                

                return dataTable;
            }
        }
    }
}
