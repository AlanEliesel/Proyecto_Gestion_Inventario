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
    public class D_Area
    {


        public DataTable Listado_Ar(string cTexto)
        {

            SqlDataReader resultado;

            DataTable tabla = new DataTable();

            SqlConnection sqlcon = new SqlConnection();

            try
            {

                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Listar_Area", sqlcon);
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




        public string Guardar_Ar(int nOpcion, E_Area oArea)// oArea = objeto propiedades
        {

            string Rpsta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {

                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Guardar_Area", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Opcion", SqlDbType.Int).Value = nOpcion;
                comando.Parameters.Add("@nId_Area", SqlDbType.Int).Value = oArea.Id_Area;
                comando.Parameters.Add("@cNombre", SqlDbType.VarChar).Value = oArea.Nombre_Are;
                comando.Parameters.Add("@cDescripcion", SqlDbType.VarChar).Value = oArea.Descripción_Are;
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



        public string Activo_Ar(int nCodigo, bool bEstado_activo)
        {
            string Rpsta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {

                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Activo_Area", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nId_Ar", SqlDbType.Int).Value = nCodigo;
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
