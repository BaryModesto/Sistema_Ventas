using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Usuario
    {
        public int id_usuario { set; get; }
        public string usuario { set; get;}
        public string nombre_completo { set;get; }
        public string correo { set; get;}
        public string clave { set; get; }
        Rol obj_rol { set; get; }
        public bool estado { set; get; }
        public string fecha_registro { set; get; }

    }
}
