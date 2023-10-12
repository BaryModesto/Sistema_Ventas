using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Producto
    {
        public int id_producto{ get; set; }
        public string codigo{ get; set; }
        public string nombre{ set; get; }
        public string descripcion{ set; get; }
        public Categoria obj_categoria { get; set; }
        public int stock{ set; get; }
        public decimal precio_compra{ set; get; }
        public decimal precio_venta { set; get; }
        public bool estado { set; get; }
        public string fecha_registro { set; get; }
    }
}
