using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades_Login
{
    public class E_Rol
    {

        public int IdRol { get; set; }

        public string Descripcion { get; set; }

        public string FechaRegistro { get; set; }

        public static implicit operator int(E_Rol v)
        {
            throw new NotImplementedException();
        }
    }
}
