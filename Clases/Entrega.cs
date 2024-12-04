using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZAMON.Clases
{
    internal class Entrega
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        tools t = new tools();
        public Entrega()
        {
            con.ConnectionString = Conexion.conexion;
        }
        public int id { get; set; }
        public int id_Paqueteria { get; set; }
        public int id_Venta { get; set; }

        public string guardar()
        {
            string msj = "";
            if (t.encontrar("ENTREGA",id))
            {
                return actualizar();
            }
            else
            {
                string query = $"insert into ENTREGA values ({id},{id_Paqueteria},{id_Venta})";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                msj = "La entrega se guardó correctamente";
                return msj;
            }
        }
        public string actualizar()
        {
            string msj = "";
            string query = $"update ENTREGA set id_Paqueteria = {id_Paqueteria},id_Venta = {id_Venta} where id = {id}";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "La entrega se actualizó correctamente";
            return msj;
        }
        public string eliminar()
        {
            string msj = "";
            string query = $"delete from ENTREGA where id = {id}";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "La entrega se eliminó correctamente";
            return msj;
        }

    }
}
