using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Entidades;
using Entidades.Entidades_Login;

namespace Datos.Conexion_Usuario
{
    public class D_Usuario
    {

        public List<E_Usuario> listar()
        {
             List<E_Usuario> lista = new List<E_Usuario>();

             SqlConnection sqlcon = new SqlConnection();

            using (sqlcon = Conexion.getInstancia().CrearConexion())
            {

                try
                {

                    string query = "select IdUsuario,Documento,NombreCompleto,Correo,Clave,Estado from USUARIO";


                    SqlCommand cmd = new SqlCommand(query, sqlcon);
                    cmd.CommandType = CommandType.Text;

                    sqlcon.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            lista.Add(new E_Usuario
                            {

                                IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                                Documento = reader["Documento"].ToString(),
                                NombreCompleto = reader["NombreCompleto"].ToString(),
                                Correo = reader["Correo"].ToString(),
                                Clave = reader["Clave"].ToString(),
                                Estado = Convert.ToBoolean(reader["Estado"])

                            });

                        }
                    }


                }catch (Exception ex)
                {

                    lista = new List<E_Usuario>();

                }

            }return lista;
        }


    }
}
