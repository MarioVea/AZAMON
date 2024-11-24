using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace AZAMON.Clases
{
    internal class Producto
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public Producto()
        {
            con.ConnectionString = Conexion.conexion;
        }
        public int id { get; set; }
        public int id_Categoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public string guardar()
        {
            string msj = "";
            string query = $"insert into PRODUCTO (id,id_Categoria,Nombre,Descripcion,Precio) values ({id},{id_Categoria},'{Nombre}','{Descripcion}',{Precio})";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "El producto se registró correctamente";
            return msj;
        }

        public string actualizar()
        {
            string msj = "";
            string query = $"update PRODUCTO set id_Categoria = {id_Categoria},Nombre = '{Nombre}',Descripcion = '{Descripcion}',Precio = {Precio} where id = {id}";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "El producto se actualizó correctamente";
            return msj;
        }

        public string eliminar()
        {
            string msj = "";
            string query = $"delete from PRODUCTO where id = {id}";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "El producto se eliminó correctamente";
            return msj;
        }
    }
}
