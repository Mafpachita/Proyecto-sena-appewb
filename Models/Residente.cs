using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application_Web.Models
{
    public class Residente
    {
        
        public string IdR { get; set; }
        public string Nombres { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Numero_apartamento { get; set; }
        public string Numero_torre { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
