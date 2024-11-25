using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZAMON.Clases
{
    internal class Usuario
    {
        Conexion Conexion = new Conexion();
        SqlConnection con = new SqlConnection();
        public Usuario()
        {
            con.ConnectionString = Conexion.conexion;
        }
        public int id { get; set; }
        public string Nombre { get; set; }
        public string A_Paterno { get; set; }
        public string A_Materno { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Contrasena { get; set; }
        public int id_Domicilio { get; set; }


        public string guardar()
        {
            tools t = new tools();
            if (t.encontrar("USUARIO",id))
            {
                return(actualizar());
            }
            else
            {
            string msj = "";
            string query = $"insert into USUARIO values({id},'{Nombre}','{A_Paterno}','{A_Materno}',{Edad},'{Email}','{Telefono}','{Contrasena}',{id_Domicilio})";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "El usuario se guardó correctamente";
            return msj;

            }
        }

        public string actualizar()
        {
            string msj = "";
            string query = $"update USUARIO  set Nombre = '{Nombre}',A_Paterno = '{A_Paterno}',A_Materno = '{A_Materno}',Edad ={Edad},Email = '{Email}',Telefono ='{Telefono}',Contrasena = '{Contrasena}',id_Domicilio ='{id_Domicilio}' where id = {id}";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            msj = "El usuario se actualizó correctamente";
            return msj;
        }

        public string eliminar()
        {
            tools t = new tools();
            string msj = "";
            if (t.encontrar("USUARIO",id))
            {
                string query = $"delete from USUARIO where id = {id}";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                msj = "El usuario se eliminó correctamente";
                return msj;
            }
            else msj = "El usuario no se eliminó ya que no existe"; return msj;
        }


    }
}
