using Entidades.Entidades_Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Articulo
    {


        public int Id_Articulo { get; set; }
        public string Nombre_Ar { get; set; }
        public string Descripción_Ar { get; set; }

        public int Id_Categoria { get; set; }

        public int Stock { get; set; }

        public Decimal Precio { get; set; }

        public E_Usuario oUsuario { get; set; }

    }
}
