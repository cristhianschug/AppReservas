using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppReserva.Models
{
    public class Reserva
    {
        public int ID { get; set; }
        public int IDItemReserva { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataHoraEntrada { get; set; }
        public DateTime DataHoraSaida { get; set; } 
    }
}