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
    public class D_Transferencia
    {


        public DataTable Listado_Tra(string cTexto)
        {

            SqlDataReader resultado;

            DataTable tabla = new DataTable();

            SqlConnection sqlcon = new SqlConnection();

            try
            {

                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Listar_Trasferencia", sqlcon);
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




        public string Guardar_Transferencia(int nOpcion, E_Transferencia oTra)// oArea = objeto propiedades
        {

            string Rpsta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                
                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Guardar_Transferencia02", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Opcion", SqlDbType.Int).Value = nOpcion;
                comando.Parameters.Add("@nId_Transferencia", SqlDbType.Int).Value = oTra.Id_Trasnferencia;
                comando.Parameters.Add("@nCodigo_Transferencia", SqlDbType.Int).Value = oTra.Codigo_Transferencia;
                comando.Parameters.Add("@nId_Area", SqlDbType.Int).Value = oTra.Id_Area;
                comando.Parameters.Add("@nId_Responsable", SqlDbType.Int).Value = oTra.Id_Responsable;
                comando.Parameters.Add("@nId_Proveedor", SqlDbType.Int).Value = oTra.Id_Proveedor;
                comando.Parameters.Add("@cAlmacen_Origen", SqlDbType.VarChar).Value = oTra.Almacen_Origen;
                comando.Parameters.Add("@cAlmacen_Destino", SqlDbType.VarChar).Value = oTra.Almacen_Destino;
                comando.Parameters.Add("@nIdUsuario", SqlDbType.Int).Value = oTra.oUsuario;
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



        public string Activo_Tra(int nCodigo, bool bEstado_activo)
        {
            string Rpsta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {

                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Activo_Transferencia", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nId_Tra", SqlDbType.Int).Value = nCodigo;
                comando.Parameters.Add("@bEstado_Activo", SqlDbType.Bit).Value = bEstado_activo;
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
