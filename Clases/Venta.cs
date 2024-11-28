using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZAMON.Clases
{

    internal class Venta
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public Venta()
        {
            con.ConnectionString = Conexion.conexion;
        }
        //Venta
        public int id { get; set; }
        public int id_Usuario { get; set; }
        public int id_Vendedor { get; set; }
        public int id_MetodoPago { get; set; }
        public int Estado { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        //Detalle
        public int id_Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Importe { get; set; }


        public void guardarventa()
        {
            string query = $"insert into VENTA values ({id},{id_Usuario},{id_Vendedor},{id_MetodoPago},{Estado},'{Fecha}',{Total})";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void guardardetalle()
        {
            string query = $"insert into RENTA_DETALLE values ((select isnull(max(id) +1,0) from VENTA_DETALLE),{id},{id_Producto},{Cantidad},{Importe})";
            SqlCommand cmd = new SqlCommand (query,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
