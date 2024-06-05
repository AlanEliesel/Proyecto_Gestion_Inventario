using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using Datos;


namespace Negocio
{
    public class N_Area 
    {

        public  DataTable Listado_Ar(string valor)
        {

            D_Area area = new D_Area();
            return area.Listado_Ar(valor);

        }

        public  string Guardar_Ar(int Opcion, E_Area ar)
        {

            D_Area area = new D_Area();
            return area.Guardar_Ar(Opcion,ar);

        }

        public  string Activo_Ar(int id_Ar, bool estado)
        {

            D_Area area = new D_Area();
            return area.Activo_Ar(id_Ar,estado);

        }

    }
}
