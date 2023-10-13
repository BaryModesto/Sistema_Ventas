using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using System.Data;

namespace Capa_Datos
{
    public class CD_Usuarios
    {

        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            //---
            using (SqlConnection conex = new SqlConnection(Coneccion.cadena)) 
            {
                try
                {
                    string codigo_sql_select = "select id_usuario,documento,nombre_completo,correo,clave,estado from usuario";
                    SqlCommand comando = new SqlCommand(codigo_sql_select, conex);
                    comando.CommandType = CommandType.Text;
                    comando.Connection.Open();
                    SqlDataReader lectura = comando.ExecuteReader();
                    
                    while (lectura.Read())
                    {
                        /*
                        Usuario temp = new Usuario();
                        temp.id_usuario = Convert.ToInt32(lectura["id_usuario"]);
                        temp.documento = lectura["documento"].ToString();
                        temp.nombre_completo= lectura["nombre_completo"].ToString();
                        temp.correo = lectura["correo"].ToString();
                        temp.clave = lectura["clave"].ToString();
                        temp.estado = Convert.ToBoolean(lectura["estado"]);
                        lista.Add(temp);
                        */
                        //--
                        lista.Add(
                            new Usuario()
                            {
                                id_usuario = Convert.ToInt32(lectura["id_usuario"]),
                                documento = lectura["documento"].ToString(),
                                nombre_completo = lectura["nombre_completo"].ToString(),
                                correo = lectura["correo"].ToString(),
                                clave = lectura["clave"].ToString(),
                                estado = Convert.ToBoolean(lectura["estado"])
                            }

                        );
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                    throw;
                }
            }
            return lista;
        }
    }
}
