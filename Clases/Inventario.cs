using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZAMON.Clases
{
    internal class Inventario
    {
        tools t = new tools();
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public Inventario()
        {
            con.ConnectionString = Conexion.conexion;
        }
        public int id { get; set; }
        public int id_Producto { get; set; }
        public int Existencia { get; set; }

        public string guardar()
        {
            string msj = "";
            if (t.encontrar("INVENTARIO",id))
            {
                return actualizar();
            }
            else
            {
            string query = $"insert into INVENTARIO values ({id},{id_Producto},{Existencia})";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "El inventario fue guardado correctamente";
            return msj;
            }
        }


        public string actualizar()
        {
            string msj = "";
            string query = $"update INVENTARIO set id_Producto = {id_Producto}, Existencia = {Existencia} where id = {id}";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "El inventario fue actualizado correctamente";
            return msj;
        }

        public string eliminar()
        {
            if (t.encontrar("INVENTARIO", id))
            {
                string msj = "";
                string query = $"delete from INVENTARIO where id = {id}";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                msj = "El inventario fue eliminado correctamente";
                return msj;

            }
            else return "No se eliminó el inventario ya que no existe la id especificada";
        }

    }

}
