using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{ 
    public class Permiso
    {
       public int id_permiso { set;get; }
        public Rol obj_rol{  set;get; }
        public string nombre_menu {  set;get; }
        public string fecha_registro { set; get; }
    }
}
