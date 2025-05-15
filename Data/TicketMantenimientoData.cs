using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application_Web.Models;

namespace Application_Web.Data
{
    public class TicketMantenimientoData
    {
        private static List<TicketMantenimiento> tickets = new List<TicketMantenimiento>();
        private static int nextId = 1;

        public static List<TicketMantenimiento> Listar()
        {
            return tickets;
        }

        public static TicketMantenimiento Obtener(int id)
        {
            return tickets.FirstOrDefault(t => t.Id == id);
        }

        public static bool Agregar(TicketMantenimiento ticket)
        {
            ticket.Id = nextId++;
            tickets.Add(ticket);
            return true;
        }

        public static bool Actualizar(TicketMantenimiento ticket)
        {
            var existente = Obtener(ticket.Id);
            if (existente == null) return false;

            existente.Nombre = ticket.Nombre;
            existente.Correo = ticket.Correo;
            existente.Apartamento = ticket.Apartamento;
            existente.Torre = ticket.Torre;
            existente.TipoTicket = ticket.TipoTicket;
            existente.Resumen = ticket.Resumen;
            existente.Detalle = ticket.Detalle;

            return true;
        }

        public static bool Eliminar(int id)
        {
            var ticket = Obtener(id);
            if (ticket == null) return false;

            tickets.Remove(ticket);
            return true;
        }
    }
}