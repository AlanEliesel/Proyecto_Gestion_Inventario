using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {


        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion con = null;



        private Conexion()
        {
            this.Base = "Gestíón_Inventario";
            this.Servidor = "DESKTOP-8I8DIUV";
            this.Usuario = "sa";
            this.Clave = "2308";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection cadena = new SqlConnection();


            try
            {
                cadena.ConnectionString = "Server=" + this.Servidor +
                                          ";Database=" + this.Base +
                                          ";User Id=" + this.Usuario +
                                          ";Password=" + this.Clave;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion getInstancia()
        {

            if (con == null)
            {
                con = new Conexion();
            }
            return con;

        }


    }
}
