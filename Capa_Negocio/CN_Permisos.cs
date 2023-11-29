using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Permisos
    {
        private CD_Permisos cd_permisos = new CD_Permisos();
      
        public List<Permiso> Listar(int _usuario)
        {
            return cd_permisos.Listar(_usuario);
        }

    }
}
