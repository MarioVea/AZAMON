using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZAMON.Clases
{
    internal class Paqueteria
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public Paqueteria()
        {
            con.ConnectionString = Conexion.conexion;
        }
        public int id { get; set; }
        public string Nombre { get; set; }

        public string guardar()
        {
            tools t = new tools();
            if (t.encontrar("PAQUETERIA", id))
            {
                return (actualizar());
            }
            else
            {
                string msj = "";
                string query = $"insert into PAQUETERIA values({id},'{Nombre}')";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                msj = "La paquetería se guardó correctamente";
                return msj;

            }
        }
        public string actualizar()
        {
            string msj = "";
            string query = $"update PAQUETERIA set Nombre = '{Nombre}' where id ={id}";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "La paquetería se actualizó correctamente";
            return msj;
        }
        public string eliminar()
        {
            tools t = new tools();
            string msj = "";
            if (t.encontrar("PAQUETERIA", id))
            {
                string query = $"delete from PAQUETERIA where id = {id}";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                msj = "La paquetería se eliminó correctamente";
                return msj;
            }
            else msj = "La paquetería no se eliminó ya que no existe"; return msj;
        }
    }
}
