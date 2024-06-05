using Datos.Conexion_Usuario;
using Entidades.Entidades_Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Permisos
    {

        private D_Permisos objd_permiso = new D_Permisos();

        public List<E_Permiso> listar(int Idusuario)
        {

            return objd_permiso.listar(Idusuario);

        }

    }
}
