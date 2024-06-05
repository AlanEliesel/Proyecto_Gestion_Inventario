using Entidades.Entidades_Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Transferencia
    {

        public int Id_Trasnferencia { get; set; }
        public int Codigo_Transferencia { get; set; }
        public int Id_Area { get; set; }
        public int Id_Responsable { get; set; }
        public int Id_Proveedor { get; set; }
        public string Almacen_Origen { get; set; }
        public string Almacen_Destino { get; set; }

        public E_Usuario oUsuario { get; set; }

    }
}
