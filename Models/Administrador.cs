using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application_Web.Models
{
    public class Administrador
    {
        public string IdA { get; set; }
        public string Nombres { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}