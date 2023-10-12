using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Compra
    {
        public int id_compra { set; get; }
        public Usuario obj_usuario { set; get; }
        public Proveedor obj_proveedor { set; get; }
        public string tipo_documento { set; get; }
        public string numero_documento { set; get; }
        public decimal monto_total {  set; get; }
        public string fecha_registro { set; get; }
        
    }
}
