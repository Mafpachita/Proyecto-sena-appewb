using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Application_Web.Data;
using Application_Web.Models;

namespace Application_Web.Controllers
{
    [RoutePrefix("api/TicketMantenimiento")]
    public class TicketMantenimientoController : ApiController
    {
        [HttpGet]
        [Route("")]
        public List<TicketMantenimiento> Get()
        {
            return TicketMantenimientoData.Listar();
        }

        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var ticket = TicketMantenimientoData.Obtener(id);
            if (ticket == null)
                return NotFound();

            return Ok(ticket);
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Post([FromBody] TicketMantenimiento ticket)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            TicketMantenimientoData.Agregar(ticket);
            return Ok();
        }

        [HttpPut]
        [Route("")]
        public IHttpActionResult Put([FromBody] TicketMantenimiento ticket)
        {
            var actualizado = TicketMantenimientoData.Actualizar(ticket);
            if (!actualizado)
                return NotFound();

            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            var eliminado = TicketMantenimientoData.Eliminar(id);
            if (!eliminado)
                return NotFound();

            return Ok();
        }
    }
}