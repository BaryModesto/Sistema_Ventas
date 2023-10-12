using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Detalle_Compra
    {
        public int id_detalle_c { set; get; }
        public Compra obj_compra { set; get; }
        public Producto obj_producto { set; get; }
        public decimal precio_compra { set; get; }
        public decimal precio_venta { set; get; }
        public int cantidad {  set; get; }
        public decimal monto_total { set; get; }
        public string fecha_registro { set; get; }

    }
}
