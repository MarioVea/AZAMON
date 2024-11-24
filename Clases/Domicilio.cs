using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZAMON.Clases
{
    internal class Domicilio
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public Domicilio()
        {
            con.ConnectionString = Conexion.conexion;

        }
        public int id { get; set; }
        public string Calle { get; set; }
        public int No_Exterior { get; set; }
        public int No_Interior { get; set; }
        public string Referencias { get; set; }
        public string Colonia { get; set; }
        public string CP { get; set; }


        public string guardar()
        {
            string msj = "";
            string query = $"insert into DOMICILIO values({id},'{Calle}',{No_Exterior},{No_Interior},'{Referencias}','{Colonia}','{CP}')";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "El domicilio se guardó correctamente";
            return msj;
        }
        public string actualizar()
        {
            string msj = "";
            string query = $"update DOMICILIO set Calle = '{Calle}',No_Exterior = {No_Exterior},No_Interior ={No_Interior},Referencias = '{Referencias}',Colonia = '{Colonia}',CP = '{CP}' where id ={id}";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "El domicilio se actualizó correctamente";
            return msj;
        }
        public string eliminar()
        {
            tools t = new tools();
            string msj = "";
            if (t.encontrar("DOMICILIO", id))
            {
                string query = $"delete from DOMICILIO where id = {id}";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                msj = "El domicilio se eliminó correctamente";
                return msj;
            }
            else msj = "El domicilio no se eliminó ya que no existe"; return msj;
        }

    }
}
