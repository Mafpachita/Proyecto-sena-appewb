using Application_Web.Models;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Application_Web.Data
{
    public class ResidenteData
    {
        public static bool RegistrarResidente(Residente oResidente)
        {
            oResidente.FechaIngreso = DateTime.Now;
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE USP_INSERTAR_RESIDENTE '" + oResidente.IdR + "','" + oResidente.Nombres + "','" + oResidente.Telefono + "','" + oResidente.Correo + "', '" + oResidente.Numero_apartamento + "','" + oResidente.Numero_torre+ "'";

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

        public static bool ActualizarResidente(Residente oResidente)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE USP_ACTUALIZAR_RESIDENTE '" + oResidente.IdR + "','" + oResidente.Nombres + "','" + oResidente.Telefono + "','" + oResidente.Correo + "', '" + oResidente.Numero_apartamento + "','" + oResidente.Numero_torre + "'";

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

        public static bool eliminarResidente(string id)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE USP_ELIMINAR_RESIDENTE '" + id + "'";

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

        public static List<Residente> Listar()
        {
            List<Residente> oListaResidente = new List<Residente>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE USP_LISTAR_RESIDENTES";

            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaResidente.Add(new Residente()
                    {
                        IdR = Convert.ToString(dr["IdR"]),
                        Nombres = dr["Nombres"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Numero_torre = dr["Numero_torre"].ToString(),
                        Numero_apartamento = dr["Numero_apartamento"].ToString(),
                        FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"].ToString())

                    });

                }
                return oListaResidente;

            }
            else { return oListaResidente; }
        }

        public static List<Residente> Obtener(string id)
        {
            List<Residente> oListaResidente = new List<Residente>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE  USP_CONSULTAR_RESIDENTE '" + id + "'";

            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaResidente.Add(new Residente()
                    {
                        IdR = Convert.ToString(dr["IdR"]),
                        Nombres = dr["Nombres"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Numero_torre = dr["Numero_torre"].ToString(),
                        Numero_apartamento = dr["Numero_apartamento"].ToString(),
                        FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"].ToString())
                    });
                }
                return oListaResidente;
            }
            else
            {
                return oListaResidente;
            }
        }
    }
}