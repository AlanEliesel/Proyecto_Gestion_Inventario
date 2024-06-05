using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Detalle_Transferencia
    {

        public int Id_Detalle_Transferencia { get; set; }
        public int Id_Trasnferencia { get; set; }

        public int Id_Articulos { get; set; }
        public decimal Cantidad_trans { get; set; }


    }
}
