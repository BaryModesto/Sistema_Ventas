using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Proveedor
    {
        public int id_proveedor { set; get; }
        public string documento { set; get; }
        public string razon_social{ set; get; }
        public string correo{ set; get; }
        public string telefono{ set; get; }
        public bool estado { set; get; }
        public string fecha_registro { set; get; }
    }
}
