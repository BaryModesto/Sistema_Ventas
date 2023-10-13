using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios cd_usuarios =  new CD_Usuarios();
        //--- 
        /*
         * Dentro de la clase  CD_Usuarios, hay un metodo llamado Listar(), el cual accede a la base de datos, y se encarga de devolver una Lista de Usuarios
         * El metodo Listar de esta clase, retorna el contenido del metod anteriormente descrito
         */
        public List<Usuario> Listar()
        {
            return cd_usuarios.Listar();
        }
    }
}
