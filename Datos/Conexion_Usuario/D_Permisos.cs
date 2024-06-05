using Entidades.Entidades_Login;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Datos.Conexion_Usuario
{
    public class D_Permisos
    {


        public List<E_Permiso> listar( int idusuario)
        {
            List<E_Permiso> lista = new List<E_Permiso>();

            SqlConnection sqlcon = new SqlConnection();

            using (sqlcon = Conexion.getInstancia().CrearConexion())
            {

                try
                {
                    //StringBuilder esta clase nos permite hacer saltos de linea...

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.IdRol,p.NombreMenu from PERMISO p");
                    query.AppendLine("inner join ROL r on r.IdRol = p.IdRol");
                    query.AppendLine("inner join USUARIO u on u.IdRol = r.IdRol");
                    query.AppendLine("where u.IdUsuario = @idusuario");





                    SqlCommand cmd = new SqlCommand(query.ToString(), sqlcon);
                    cmd.Parameters.AddWithValue("@idusuario", idusuario);
                    cmd.CommandType = CommandType.Text;

                    sqlcon.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {


                            lista.Add(new E_Permiso()
                            {
                                oRol = new E_Rol() { IdRol = Convert.ToInt32(reader["IdRol"])},
                                NombreMenu = reader["NombreMenu"].ToString()
                            });

                        }
                    }


                }
                catch (Exception ex)
                {

                    lista = new List<E_Permiso>();

                }

            }
            return lista;
        }



    }
}
