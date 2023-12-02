using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Rol
    {
        private CD_Rol cd_rol = new CD_Rol();

        public List<Rol> Listar()
        {
            return cd_rol.Listar();
        }
    }
}
