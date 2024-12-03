using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZAMON.Clases
{
    internal class Categoria
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        tools t = new tools();
        public Categoria()
        {
            con.ConnectionString = Conexion.conexion;
        }
        public int id { get; set; }
        public string Nombre { get; set; }


        public string guardar()
        {
            if (t.encontrar("CATEGORIA",id))
            {
                return actualizar();
            }
            else
            {
                string msj = "";
                string query = $"insert into CATEGORIA values ({id},'{Nombre}')";
                SqlCommand cmd = new SqlCommand(query,con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                msj = "La categoría fué agregada correctamente";
                return msj;
            }
        }
        public string actualizar()
        {
            string msj = "";
            string query = $"update CATEGORIA set Nombre = '{Nombre}' where id = {id}";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "La categoría fué actualizada correctamente";
            return msj;
        }
        public string eliminar()
        {
            string msj = "";
            string query = $"delete from CATEGORIA where id = {id}";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "La categoría fué eliminada correctamente";
            return msj;
        }
    }
}
