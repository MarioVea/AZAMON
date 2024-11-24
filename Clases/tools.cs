using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZAMON.Clases
{
    internal class tools
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public tools()
        {
            con.ConnectionString = Conexion.conexion;
        }
        public int consecutivo(string tabla)
        {
            int a = 0;
            string query = $"select ISNULL(MAX(id) + 1,1) as maxid from {tabla}";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                a = int.Parse(rd["maxid"].ToString());
            }
            con.Close();
            return a;
        }
        public bool encontrar(string tabla, int id)
        {
            bool a = false;
            string query = $"select * from {tabla} where id = {id}";
            SqlCommand cmd =new SqlCommand(query,con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                a = true;
            }
            con.Close();
            return a;
        }
    }
}
