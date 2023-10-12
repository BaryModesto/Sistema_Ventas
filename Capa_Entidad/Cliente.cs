using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Cliente
    {
        public int id_cliente {  get; set; }
        public string documento{ set; get; }
        public string nombre_completo{ set; get; }
        public string correo{ set; get; }
        public string telefono{ set; get; }
        public bool estado { set; get; }
        public string fecha_registro { set; get; }
    }
}
