using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application_Web.Models
{
    public class TicketMantenimiento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Apartamento { get; set; }
        public string Torre { get; set; }
        public string TipoTicket { get; set; }  
        public string Resumen { get; set; }
        public string Detalle { get; set; }
    }
}