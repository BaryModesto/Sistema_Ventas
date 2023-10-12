using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Detalle_Venta
    {
        public int id_detalle_v { set; get; }
        public Venta obj_venta { set; get; }
        public Producto obj_producto { set; get; }        
        public decimal precio_venta { set; get; }
        public int cantidad { set; get; }
        public decimal sub_total { set; get; }
        public List<Detalle_Venta> obj_detalle_v { set; get; }
        public string fecha_registro { set; get; }
    }
}
