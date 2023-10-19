using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Sistema_de_Registro___SG_COMUNICACIONES_Y_SEGURIDAD
{
    internal class Procedimientos
    {
        private SqlConnection Conexion = new SqlConnection(@"Server=.\SQL2017;Database=NSG; Integrated Security=True;");

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
    }
}
