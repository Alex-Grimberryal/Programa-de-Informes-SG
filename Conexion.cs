using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    public static class ConexionDB
    {
        public static SqlConnection GetSqlConnection()
        {
            string connectionString = "Data Source=LAPTOP-3R8N4QM6;Initial Catalog=NSG;User ID=sa;Password=";
            return new SqlConnection(connectionString);
        }
    }
}