using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;

using Datos.Conexion_Usuario;
using Entidades.Entidades_Login;

namespace Negocio
{
    public class N_Usuario
    {

        private D_Usuario objd_usuario = new D_Usuario();

        public List<E_Usuario> listar()
        {

            return objd_usuario.listar();

        }

    }
}
