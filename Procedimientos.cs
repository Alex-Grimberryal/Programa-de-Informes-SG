using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;

namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    internal class Procedimientos
    {
        public string server = "Data Source=LAPTOP-3R8N4QM6\\SQLEXPRESS; Initial Catalog=NSG; Integrated Security=True; TrustServerCertificate=True";
        public SqlConnection Conexion = new SqlConnection(@"Server=LAPTOP-3R8N4QM6\SQLEXPRESS;Database=NSG; Integrated Security=True; TrustServerCertificate=True");
        
        //Procedimiento de inicio de sesion

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

        //Procedimientos para los usuarios

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

        //Precedimientos para los articulos

        public void InsertarArticulo(string nombre, decimal precio, string marca, string categoria)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(server))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("InsertarArticulo", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Marca", marca);
                    command.Parameters.AddWithValue("@Categoria", categoria);

                    SqlParameter returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();

                    int returnValue = Convert.ToInt32(returnParameter.Value);

                    if (returnValue == 0)
                    {
                        MessageBox.Show("Artículo insertado correctamente.");
                    }
                    else if (returnValue == 1)
                    {
                        MessageBox.Show("La marca especificada no existe en la tabla marca.");
                    }
                    else if (returnValue == 2)
                    {
                        MessageBox.Show("La categoría especificada no existe en la tabla categoria.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar el artículo.");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ModificarArticulo(int idArticulo, string nombre, decimal precio, string marca, string categoria)
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                using (SqlCommand command = new SqlCommand("ModificarArticulo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros al comando
                    command.Parameters.AddWithValue("@IdArticulo", idArticulo);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Marca", marca);
                    command.Parameters.AddWithValue("@Categoria", categoria);

                    connection.Open();
                    string result = (string)command.ExecuteScalar();

                    Console.WriteLine(result);
                }
            }
        }

        public void BorrarArticulo(int idArticulo)
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                using (SqlCommand command = new SqlCommand("BorrarArticulo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar el parámetro al comando
                    command.Parameters.AddWithValue("@IdArticulo", idArticulo);

                    connection.Open();
                    string result = (string)command.ExecuteScalar();

                    Console.WriteLine(result);
                    connection.Close();
                }
            }
        }

        //Procedimientos para las marcas y categorias

        public void InsertarCategoria(string categoria)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(server))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("InsertarCategorias", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@categoria", categoria);

                    SqlParameter returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();

                    int returnValue = Convert.ToInt32(returnParameter.Value);

                    if (returnValue == 0)
                    {
                        MessageBox.Show("Categoria insertada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("La categoria especificada no existe en la base de datos.");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void InsertarMarca(string marca)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(server))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("InsertarMarca", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@marca", marca);

                    SqlParameter returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();

                    int returnValue = Convert.ToInt32(returnParameter.Value);

                    if (returnValue == 0)
                    {
                        MessageBox.Show("Marca insertada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("La marca especificada no existe en la base de datos.");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ModificarCategoria(int idCategoria, string categoria)
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                using (SqlCommand command = new SqlCommand("ModificarCategoria", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros al comando
                    command.Parameters.AddWithValue("@IdCategoria", idCategoria);
                    command.Parameters.AddWithValue("@Categoria", categoria);

                    connection.Open();
                    string result = (string)command.ExecuteScalar();

                    Console.WriteLine(result);
                }
            }
        }

        public void ModificarMarca(int idMarca, string marca)
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                using (SqlCommand command = new SqlCommand("ModificarMarca", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros al comando
                    command.Parameters.AddWithValue("@IdMarca", idMarca);
                    command.Parameters.AddWithValue("@marca", marca);

                    connection.Open();
                    string result = (string)command.ExecuteScalar();

                    Console.WriteLine(result);
                }
            }
        }

        public void BorrarCategoria(int idCategoria)
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                using (SqlCommand command = new SqlCommand("BorrarCategoria", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar el parámetro al comando
                    command.Parameters.AddWithValue("@IdCategoria", idCategoria);

                    connection.Open();
                    string result = (string)command.ExecuteScalar();

                    Console.WriteLine(result);
                    connection.Close();
                }
            }
        }

        public void BorrarMarca(int idMarca)
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                using (SqlCommand command = new SqlCommand("BorrarMarca", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar el parámetro al comando
                    command.Parameters.AddWithValue("@IdMarca", idMarca);

                    connection.Open();
                    string result = (string)command.ExecuteScalar();

                    Console.WriteLine(result);
                    connection.Close();
                }
            }
        }

        //Obtencion de datos para visualizarce en DataGridViews

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

        public DataTable ObtenerCategorias()
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                SqlCommand command = new SqlCommand("SELECT idcategoria, categoria FROM categoria", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                return dataTable;
            }
        }

        public DataTable ObtenerMarcas()
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                SqlCommand command = new SqlCommand("SELECT idmarca, marca FROM marca", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                return dataTable;
            }
        }

        public DataTable ObtenerArticulos()
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                SqlCommand command = new SqlCommand("SELECT a.idarticulo, a.nombre AS nombre_articulo, a.precio, c.categoria, m.marca FROM articulos a INNER JOIN categoria c ON a.categoria_idcategoria = c.idcategoria INNER JOIN marca m ON a.marca_idmarca = m.idmarca;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                return dataTable;
            }
        }

        public DataTable ObtenerTecnicos()
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                SqlCommand command = new SqlCommand("SELECT idTecnico, dni_tecnico, nombres, apellido_paterno, apellido_materno, telefono FROM tecnico", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                return dataTable;
            }
        }
    }
}
