using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Articulo
    {


        public DataTable Listado_A(string cTexto)
        {

            SqlDataReader resultado;

            DataTable tabla = new DataTable();

            SqlConnection sqlcon = new SqlConnection();

            try
            {

                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Listar_Articulo", sqlcon);
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



        public string Guardar_A(int nOpcion, E_Articulo oArti)// oArea = objeto propiedades
        {

            string Rpsta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {

                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Guardar_Articulo", sqlcon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Opcion", SqlDbType.Int).Value = nOpcion;
                comando.Parameters.Add("@nId_Articulo", SqlDbType.Int).Value = oArti.Id_Articulo;
                comando.Parameters.Add("@cNombre", SqlDbType.VarChar).Value = oArti.Nombre_Ar;
                comando.Parameters.Add("@cDescripcion", SqlDbType.VarChar).Value = oArti.Descripción_Ar;
                comando.Parameters.Add("@nId_Categoria", SqlDbType.Int).Value = oArti.Id_Categoria;
                comando.Parameters.Add("@nStock", SqlDbType.Int).Value = oArti.Stock;
                comando.Parameters.Add("@nPrecio", SqlDbType.Int).Value = oArti.Precio;
                comando.Parameters.Add("@nId_Usuario", SqlDbType.Int).Value = oArti.Id_Categoria;
                
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



        public string Activo_A(int nCodigo, bool bEstado_activo)
        {
            string Rpsta = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {

                sqlcon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Activo_Articulo", sqlcon);
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
