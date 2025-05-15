using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Application_Web.Models;

namespace Application_Web.Data
{
    public class AdministradorData
    {
        public static bool RegistrarAdministrador(Administrador oAdministrador)
        {
            oAdministrador.FechaIngreso = DateTime.Now;
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "USP_INSERTAR_ADMINISTRADOR '" + oAdministrador.IdA + "','" + oAdministrador.Nombres + "','" + oAdministrador.Telefono + "','" + oAdministrador.Correo + "'";

            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }

        public static bool ActualizarAdministrador(Administrador oAdministrador)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "USP_ACTUALIZAR_ADMINISTRADOR '" + oAdministrador.IdA + "','" + oAdministrador.Nombres + "','" + oAdministrador.Telefono + "','" + oAdministrador.Correo + "'";

            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }

        public static bool eliminarAdministrador(string id)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "USP_ELIMINAR_ADMINISTRADOR '" + id + "'";

            if (!objEst.EjecutarSentencia(sentencia, false))
            {
                objEst = null;
                return false;
            }
            else
            {
                objEst = null;
                return true;
            }
        }

        public static List<Administrador> Listar()
        {
            List<Administrador> oListaAdministrador = new List<Administrador>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "USP_LISTAR_ADMINISTRADORES";

            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaAdministrador.Add(new Administrador()
                    {
                        IdA = Convert.ToString(dr["IdA"]),
                        Nombres = dr["Nombres"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"].ToString())

                    });

                }
                return oListaAdministrador;

            }
            else { return oListaAdministrador; }
        }

        public static List<Administrador> Obtener(string id)
        {
            List<Administrador> oListaAdministrador = new List<Administrador>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "USP_CONSULTAR_ADMINISTRADOR '" + id + "'";

            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaAdministrador.Add(new Administrador()
                    {
                        IdA = Convert.ToString(dr["IdA"]),
                        Nombres = dr["Nombres"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"].ToString())
                    });
                }
                return oListaAdministrador;
            }
            else
            {
                return oListaAdministrador;
            }
        }
    }
}
