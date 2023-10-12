using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Venta
    {
        public int id_venta { set; get; }
        public Usuario obj_usuario { set; get; }        
        public string tipo_documento { set; get; }
        public string numero_documento { set; get; }
        public string documento_cliente { set; get; }
        public string nombre_cliente { set; get; }
        public decimal monto_pago { set; get; }
        public decimal monto_cambio { set; get; }
        public decimal monto_total { set; get; }
        public string fecha_registro { set; get; }
    }
}
