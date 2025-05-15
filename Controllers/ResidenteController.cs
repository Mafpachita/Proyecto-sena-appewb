using System;
using System.Collections.Generic;
using System.Linq;
using Application_Web.Data;
using Application_Web.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Application_Web.Controllers
{
    public class ResidenteController : ApiController
    {
        // GET api/<controller>
        public List<Residente> Get()
        {
            return ResidenteData.Listar();
        }

        // GET api/<controller>/5
        public List<Residente> Get(string id)
        {
            return ResidenteData.Obtener(id);
        }

        // POST api/<controller>
        public bool Post([FromBody] Residente oResidente)
        {
            return ResidenteData.RegistrarResidente(oResidente);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Residente oResidente)
        {
            return ResidenteData.ActualizarResidente(oResidente);
        }

        // DELETE api/<controller>/5
        public bool Delete(string id)
        {
            return ResidenteData.eliminarResidente(id);
        }
    }
}
