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
    public class D_Categoria
    {

        public DataTable Listado_Ca(string cTexto)
        {

            SqlDataReader resultado;

            DataTable tabla = new DataTable();

            SqlConnection sqlcon = new SqlConnection();

            try
            {

                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Listar_Categoria", sqlcon);
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



        public string Guardar_Ca(int nOpcion,  E_Categoria oCate)// oArea = objeto propiedades
        {

            string Rpsta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {

                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Guardar_Categoria", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Opcion", SqlDbType.Int).Value = nOpcion;
                comando.Parameters.Add("@nId_Categoria", SqlDbType.Int).Value = oCate.Id_Categoria;
                comando.Parameters.Add("@cNombre", SqlDbType.VarChar).Value = oCate.Nombre_Ca;
                comando.Parameters.Add("@cDescripcion", SqlDbType.VarChar).Value = oCate.Descripción_Ca;
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



        public string Activo_Ca(int nCodigo, bool bEstado_activo)
        {
            string Rpsta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {

                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Activo_Categoria", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nId_Ca", SqlDbType.Int).Value = nCodigo;
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
