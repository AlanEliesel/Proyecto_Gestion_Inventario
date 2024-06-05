using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class D_Detalle_Transferencia
    {


        public DataTable Listado_Deta_Tra(string cTexto)
        {

            SqlDataReader resultado;

            DataTable tabla = new DataTable();

            SqlConnection sqlcon = new SqlConnection();

            try
            {

                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Listar_Detalle_Trasferencia", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                sqlcon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
        }




        public string Guardar_Deta_Tra(int nOpcion, E_Detalle_Transferencia oDeta)// oArea = objeto propiedades
        {

            string Rpsta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {

                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Guardar_Detalle_Transferencia", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Opcion", SqlDbType.Int).Value = nOpcion;
                comando.Parameters.Add("@nId_Detalle_Tranferencia", SqlDbType.Int).Value = oDeta.Id_Detalle_Transferencia;
                comando.Parameters.Add("@nId_Transferencia", SqlDbType.Int).Value = oDeta.Id_Trasnferencia;
                comando.Parameters.Add("@nId_Articulo", SqlDbType.Int).Value = oDeta.Id_Articulos;
                comando.Parameters.Add("@nCantidad", SqlDbType.Decimal).Value = oDeta.Cantidad_trans;
                sqlcon.Open();


                Rpsta = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo registrar los datos";

            }
            catch (Exception ex)
            {
                Rpsta = ex.Message;

            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
            }
            return Rpsta;
        }



        public string Activo_Deta_Tra(int nCodigo, bool bEstado_activo, int nId_Arti, decimal Cantidad)
        {
            string Rpsta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {

                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Activo_Detalle_Trasferencia", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nId_Deta_Tra", SqlDbType.Int).Value = nCodigo;
                comando.Parameters.Add("@bEstado_Activo", SqlDbType.Bit).Value = bEstado_activo;
                comando.Parameters.Add("@nId_Articulo", SqlDbType.Int).Value = nId_Arti;
                comando.Parameters.Add("@ncantidad", SqlDbType.Int).Value = Cantidad;
                sqlcon.Open();
                Rpsta = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo cambiar el estado activo del producto";

            }
            catch (Exception ex)
            {
                Rpsta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
            }
            return Rpsta;
        }



        public string Restablecer_Stock_Articulo(int nId_Arti, int Cantidad)
        {
            string Rpsta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {

                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Restablecer_Stock", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nId_Articulo", SqlDbType.Int).Value = nId_Arti;
                comando.Parameters.Add("@nStock_Menos", SqlDbType.Int).Value = Cantidad;
                sqlcon.Open();
                Rpsta = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo cambiar el estado activo del producto";

            }
            catch (Exception ex)
            {
                Rpsta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) { sqlcon.Close(); }
            }
            return Rpsta;
        }

    }
}
