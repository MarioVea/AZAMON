using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZAMON.Clases
{
    internal class MetodoPago
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public MetodoPago()
        {
            con.ConnectionString = Conexion.conexion;
        }
        public int id { get; set; }
        public int id_Usuario { get; set; }
        public int Tipo { get; set; }
        public string Numero_Tarjeta { get; set; }
        public string CVV { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
        public string Titular { get; set; }
        public string  Nombre_Tarjeta { get; set; }


        public string guardar()
        {
            tools t = new tools();
            if (t.encontrar("METODO_PAGO", id))
            {
                return (actualizar());
            }
            else
            {
                string msj = "";
                string query = $"insert into METODO_PAGO values({id},{id_Usuario},{Tipo},'{Numero_Tarjeta}','{CVV}','{Fecha_Vencimiento}','{Titular}','{Nombre_Tarjeta}')";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                msj = "El metodo de pago se guardó correctamente";
                return msj;

            }
        }
        public string actualizar()
        {
            string msj = "";
            string query = $"update METODO_PAGO set  id_Usuario = {id_Usuario}, Tipo = {Tipo},Numero_Tarjeta = '{Numero_Tarjeta}',CVV = '{CVV}',Fecha_Vencimiento = '{Fecha_Vencimiento}',Titular = '{Titular}' where id ={id}";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "El metodo de pago se actualizó correctamente";
            return msj;
        }
        public string eliminar()
        {
            tools t = new tools();
            string msj = "";
            if (t.encontrar("METODO_PAGO", id))
            {
                string query = $"delete from METODO_PAGO where id = {id}";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                msj = "El metodo de pago se eliminó correctamente";
                return msj;
            }
            else msj = "El metodo de pago no se eliminó ya que no existe"; return msj;
        }
    }
}
