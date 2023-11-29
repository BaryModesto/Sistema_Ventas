using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Capa_Datos
{
    public class CD_Permisos
    {
        public List<Permiso> Listar(int _id_usuario)
        {
            List<Permiso> lista = new List<Permiso>();
            //---
            using (SqlConnection conex = new SqlConnection(Coneccion.cadena))
            {
                try
                {
                    StringBuilder codigo_sql_select = new StringBuilder();
                    codigo_sql_select.AppendLine("select p.id_rol, p.nombre_menu");
                    codigo_sql_select.AppendLine("from PERMISO p");
                    codigo_sql_select.AppendLine("inner join ROL r on r.id_rol = p.id_rol");
                    codigo_sql_select.AppendLine("inner join USUARIO u on u.id_rol = r.id_rol");
                    codigo_sql_select.AppendLine("where u.id_usuario = @_id_usuario;");

                   
                    SqlCommand comando = new SqlCommand(codigo_sql_select.ToString(), conex);
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@_id_usuario", _id_usuario);
                    comando.Connection.Open();
                    SqlDataReader lectura = comando.ExecuteReader();
                    //bool ver = lectura.Read();
                    while (/*ver == true */ lectura.Read())
                    {                        
                        //--
                        lista.Add(
                            new Permiso()
                            {                               
                                obj_rol = new Rol() 
                                { 
                                    id_rol = Convert.ToInt32(lectura["id_rol"] )
                                },
                                nombre_menu = lectura["nombre_menu"].ToString()                               
                            }

                        );
                        //ver = lectura.Read();
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Permiso>();
                }
            }
            return lista;
        }
    }
}
