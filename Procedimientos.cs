using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    internal class Procedimientos
    {
        private SqlConnection Conexion = new SqlConnection(@"Server=LAPTOP-3R8N4QM6\SQLEXPRESS;Database=NSG; Integrated Security=True; TrustServerCertificate=True");
        

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

        public void InsertarUsuario(string nombre, string contrasena, int rol)
        {
            try
            {
                Conexion.ConnectionString = @"Server=LAPTOP-3R8N4QM6\SQLEXPRESS;Database=NSG; Integrated Security=True; TrustServerCertificate=True";
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
            
        

        public void ModificarUsuario(string nombre, string contrasena, int roles_idrol)
        {
            using (SqlConnection connection = Conexion)
            {
                SqlCommand command = new SqlCommand("ModificarUsuario", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Contrasena", contrasena);             
                command.Parameters.AddWithValue("@RolesIdRol", roles_idrol);

                connection.Open();
                string result = (string)command.ExecuteScalar();
                Console.WriteLine(result);

            }
        }

        public void BorrarUsuario(string nombre)
        {
            using (SqlConnection connection = Conexion)
            {
                SqlCommand command = new SqlCommand("BorrarUsuario", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Nombre", nombre);

                connection.Open();
                string result = (string)command.ExecuteScalar();
                Console.WriteLine(result);
            }
        }

        public DataTable ObtenerUsuarios()
        {
            using (SqlConnection connection = Conexion)
            {
                SqlCommand command = new SqlCommand("SELECT u.nombre, u.contrasena, r.rol FROM usuarios u JOIN roles r ON u.roles_idrol = r.idrol", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                return dataTable;
            }
        }

    }
}
