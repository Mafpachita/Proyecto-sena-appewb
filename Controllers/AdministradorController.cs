using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application_Web.Data;
using Application_Web.Models;
using System.Web.Http;

namespace Application_Web.Controllers
{
    public class AdministradorController : ApiController
    {
            // GET api/<controller>
            public List<Administrador> Get()
            {
                return AdministradorData.Listar();
            }

            // GET api/<controller>/5
            public List<Administrador> Get(string id)
            {
                return AdministradorData.Obtener(id);
            }

            // POST api/<controller>
            public bool Post([FromBody] Administrador oAdministrador)
            {
                return AdministradorData.RegistrarAdministrador(oAdministrador);
            }

            // PUT api/<controller>/5
            public bool Put([FromBody] Administrador oAdministrador)
            {
                return AdministradorData.ActualizarAdministrador(oAdministrador);
            }

            // DELETE api/<controller>/5
            public bool Delete(string id)
            {
                return AdministradorData.eliminarAdministrador(id);
            }
        
    }
}