using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Rol
    {
        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();
            //---
            using (SqlConnection conex = new SqlConnection(Coneccion.cadena))
            {
                try
                {
                    StringBuilder codigo_sql_select = new StringBuilder();
                    codigo_sql_select.AppendLine("select id_rol,descripcion from  rol");
                   
                    SqlCommand comando = new SqlCommand(codigo_sql_select.ToString(), conex);
                    comando.CommandType = CommandType.Text;                    
                    comando.Connection.Open();
                    SqlDataReader lectura = comando.ExecuteReader();
                    //bool ver = lectura.Read();
                    while (/*ver == true */ lectura.Read())
                    {
                        //--
                        lista.Add(
                            new Rol()
                            {
                                id_rol = Convert.ToInt32(lectura["id_rol"]),
                                descripcion = lectura["descripcion"].ToString()                               
                            }
                        );
                        //ver = lectura.Read();
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Rol>();
                }
            }
            return lista;
        }
    }
}
