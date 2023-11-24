using Microsoft.Data.SqlClient;
using System.Data;

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

        public string ObtenerRol(string userName)
        {
            try
            {
                Conexion.Open();

                SqlCommand cmd = new SqlCommand("SELECT roles.rol FROM usuarios INNER JOIN roles ON usuarios.roles_idrol = roles.idrol WHERE usuarios.nombre = @userName", Conexion);
                cmd.Parameters.AddWithValue("@userName", userName);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return dr.GetString(0);
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

            return string.Empty;
        }

        public int ObtenerIdUsuario(string txtUser, string txtPassword)
        {
            try
            {
                Conexion.Open();

                SqlCommand cmd = new SqlCommand("SELECT iduser FROM usuarios WHERE nombre = @txtUser AND contrasena = @txtPassword", Conexion);
                cmd.Parameters.AddWithValue("@txtUser", txtUser);
                cmd.Parameters.AddWithValue("@txtPassword", txtPassword);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result);
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

            return 0; // Si no se encuentra el usuario o la contraseña no coincide, puedes devolver un valor predeterminado o lanzar una excepción según tu lógica de aplicación.
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

        public void InsertarArticulo(string nombre, decimal precio, string marca, string categoria, int stock)
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
                    command.Parameters.AddWithValue("@stock", stock);

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

        public void ModificarArticulo(int idArticulo, string nombre, decimal precio, string marca, string categoria, int stock)
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
                    command.Parameters.AddWithValue("@stock", stock);

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

        //Procedimientos para los tecnicos

        public void InsertarTecnico(string dni, string nombres, string apellidoPaterno, string apellidoMaterno, string telefono)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(server))
                {
                    connection.Open();

                    // Verificar si el DNI ya existe en la base de datos
                    SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM tecnico WHERE dni_tecnico = @DNI", connection);
                    checkCommand.Parameters.AddWithValue("@DNI", dni);
                    int dniCount = (int)checkCommand.ExecuteScalar();

                    if (dniCount > 0)
                    {
                        MessageBox.Show("El DNI ya está registrado. Por favor, ingrese un DNI válido.");
                        return;
                    }

                    // Insertar el técnico si el DNI no se repite
                    SqlCommand insertCommand = new SqlCommand("InsertarTecnico", connection);
                    insertCommand.CommandType = CommandType.StoredProcedure;
                    insertCommand.Parameters.AddWithValue("@DNI", dni);
                    insertCommand.Parameters.AddWithValue("@Nombres", nombres);
                    insertCommand.Parameters.AddWithValue("@ApellidoPaterno", apellidoPaterno);
                    insertCommand.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaterno);
                    insertCommand.Parameters.AddWithValue("@Telefono", telefono);

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Técnico insertado correctamente.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ModificarTecnico(int idTecnico, string dni, string nombres, string apellidoPaterno, string apellidoMaterno, string telefono)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(server))
                {
                    connection.Open();

                    // Verificar si el DNI ya existe en otro técnico
                    SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM tecnico WHERE dni_tecnico = @DNI AND idTecnico != @IdTecnico", connection);
                    checkCommand.Parameters.AddWithValue("@DNI", dni);
                    checkCommand.Parameters.AddWithValue("@IdTecnico", idTecnico);
                    int dniCount = (int)checkCommand.ExecuteScalar();

                    if (dniCount > 0)
                    {
                        MessageBox.Show("El DNI ya está registrado en otro técnico. Por favor, ingrese un DNI válido.");
                        return;
                    }

                    // Modificar el técnico si el DNI no se repite
                    SqlCommand modifyCommand = new SqlCommand("ModificarTecnico", connection);
                    modifyCommand.CommandType = CommandType.StoredProcedure;
                    modifyCommand.Parameters.AddWithValue("@IdTecnico", idTecnico);
                    modifyCommand.Parameters.AddWithValue("@DNI", dni);
                    modifyCommand.Parameters.AddWithValue("@Nombres", nombres);
                    modifyCommand.Parameters.AddWithValue("@ApellidoPaterno", apellidoPaterno);
                    modifyCommand.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaterno);
                    modifyCommand.Parameters.AddWithValue("@Telefono", telefono);

                    modifyCommand.ExecuteNonQuery();

                    MessageBox.Show("Técnico modificado correctamente.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void BorrarTecnico(int idTecnico)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(server))
                {
                    connection.Open();

                    // Verificar si el técnico tiene informes relacionados
                    SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM informe WHERE tecnico = @IdTecnico", connection);
                    checkCommand.Parameters.AddWithValue("@IdTecnico", idTecnico);
                    int informeCount = (int)checkCommand.ExecuteScalar();

                    if (informeCount > 0)
                    {
                        // Mostrar mensaje de advertencia
                        MessageBox.Show("El técnico tiene informes relacionados. La eliminación del técnico también eliminará todos los informes asociados.");

                        // Eliminar los registros relacionados en la tabla art_vend
                        SqlCommand deleteArtVendCommand = new SqlCommand("DELETE FROM art_vend WHERE info_idInforme IN (SELECT nro_de_informe FROM informe WHERE tecnico = @IdTecnico)", connection);
                        deleteArtVendCommand.Parameters.AddWithValue("@IdTecnico", idTecnico);
                        deleteArtVendCommand.ExecuteNonQuery();

                        // Eliminar los informes relacionados
                        SqlCommand deleteInformeCommand = new SqlCommand("DELETE FROM informe WHERE tecnico = @IdTecnico", connection);
                        deleteInformeCommand.Parameters.AddWithValue("@IdTecnico", idTecnico);
                        deleteInformeCommand.ExecuteNonQuery();
                    }

                    // Eliminar el técnico
                    SqlCommand deleteTecnicoCommand = new SqlCommand("DELETE FROM tecnico WHERE idTecnico = @IdTecnico", connection);
                    deleteTecnicoCommand.Parameters.AddWithValue("@IdTecnico", idTecnico);
                    int rowCount = deleteTecnicoCommand.ExecuteNonQuery();

                    if (rowCount == 0)
                    {
                        MessageBox.Show("No se encontró ningún técnico con el ID especificado.");
                    }
                    else
                    {
                        MessageBox.Show("Técnico borrado correctamente.");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
                SqlCommand command = new SqlCommand("SELECT a.idarticulo, a.nombre AS nombre_articulo, a.precio, a.stock, c.categoria, m.marca FROM articulos a INNER JOIN categoria c ON a.categoria_idcategoria = c.idcategoria INNER JOIN marca m ON a.marca_idmarca = m.idmarca;", connection);
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

        public DataTable ObtenerArticulosVendidosPorInforme(int idInforme)
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Art_Vend WHERE info_idInforme = @idInforme", connection);
                command.Parameters.AddWithValue("@idInforme", idInforme);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                return dataTable;
            }
        }

        //Procedimientos para los informes

        public DataTable ObtenerInformes()
        {
            using (SqlConnection connection = new SqlConnection(server))
            {
                SqlCommand command = new SqlCommand("SELECT i.nro_de_informe, i.nombre_de_cliente, i.apellido_paterno, i.apellido_materno, " +
                "i.dni, i.telefono, i.email, i.fecha, i.monto_total, i.direccion_instalacion, " +
                "i.notas_adicionales, u.nombre AS NombreUsuario, t.apellido_paterno AS ApellidoTecnico " +
                "FROM informe AS i " +
                "INNER JOIN usuarios AS u ON i.redactor = u.iduser " +
                "INNER JOIN tecnico AS t ON i.tecnico = t.idTecnico", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                return dataTable;
            }
        }

        public void InsertarInformeAMedias(string nombreCliente, string apellidoPaterno, string apellidoMaterno, string dni, string telefono, string email, decimal montoTotal, string direccionInstalacion, string notasAdicionales, int redactor, int articulosVend, int tecnico)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(server))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("InsertarInforme", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NombreCliente", nombreCliente);
                    command.Parameters.AddWithValue("@ApellidoPaterno", apellidoPaterno);
                    command.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaterno);
                    command.Parameters.AddWithValue("@DNI", dni);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@MontoTotal", 0.00m); // Valor inicial de monto_total
                    command.Parameters.AddWithValue("@DireccionInstalacion", direccionInstalacion);
                    command.Parameters.AddWithValue("@NotasAdicionales", notasAdicionales);
                    command.Parameters.AddWithValue("@Redactor", redactor);
                    command.Parameters.AddWithValue("@ArticulosVend", 0); // Valor inicial de articulos_vend
                    command.Parameters.AddWithValue("@Tecnico", tecnico);

                    SqlParameter returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();

                    int returnValue = Convert.ToInt32(returnParameter.Value);

                    if (returnValue == 0)
                    {
                        MessageBox.Show("Informe insertado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al insertar el informe.");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private int ObtenerSiguienteNroInforme(SqlConnection connection)
        {
            int siguienteNumeroInforme = 0;
            string query = "SELECT ISNULL(MAX(NroInforme), 0) + 1 FROM informe";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                object result = command.ExecuteScalar();

                siguienteNumeroInforme = Convert.ToInt32(result);
            }

            return siguienteNumeroInforme;
        }

        public DataTable ObtenerInformesPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(server))
                {
                    connection.Open();

                    string query = "SELECT i.nro_de_informe, i.nombre_de_cliente, i.apellido_paterno, i.apellido_materno, " +
                                   "i.dni, i.telefono, i.email, i.fecha, i.monto_total, i.direccion_instalacion, " +
                                   "i.notas_adicionales, u.nombre, t.apellido_paterno AS apellido_tecnico " +
                                   "FROM informe AS i " +
                                   "INNER JOIN usuarios AS u ON i.redactor = u.iduser " +
                                   "INNER JOIN tecnico AS t ON i.tecnico = t.idTecnico " +
                                   "WHERE i.fecha >= @FechaInicio AND i.fecha <= @FechaFin " +
                                   "ORDER BY i.fecha DESC";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción
            }

            return dataTable;
        }

        public int ObtenerSiguienteNumeroInforme()
        {
            int siguienteNumeroInforme = 0;
            string query = "SELECT MAX(nro_de_informe) FROM informe";

            using (SqlConnection connection = new SqlConnection(server))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        siguienteNumeroInforme = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        siguienteNumeroInforme = 1;
                    }
                }
            }

            return siguienteNumeroInforme;
        }

        public DataTable ObtenerTablaArticulos()
        {
            DataTable articulosTable = new DataTable();

            string query = "SELECT idarticulo, nombre FROM articulos";

            using (SqlConnection connection = new SqlConnection(server))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(articulosTable);
                    }
                }
            }

            return articulosTable;
        }

        public void InsertarArticulosVendidos(int IdInforme,int articulo, string cantidad, decimal monto)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(server))
                {
                    connection.Open();

                    // Crear el comando para llamar al procedimiento almacenado
                    using (SqlCommand command = new SqlCommand("InsertarArticulosVendidos", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros al comando
                        command.Parameters.AddWithValue("@IdInforme", IdInforme);
                        command.Parameters.AddWithValue("@articulo", articulo);
                        command.Parameters.AddWithValue("@cantidad", cantidad);
                        command.Parameters.AddWithValue("@monto", monto);

                        // Ejecutar el comando
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
