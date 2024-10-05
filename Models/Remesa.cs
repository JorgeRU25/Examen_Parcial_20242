using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_Parcial_20242.Models
{
    public class Remesa
    {
        public int Id { get; set; }
        public string? NombreRemitente { get; set; }
        public string? NombreDestinatario { get; set; }
        public string? PaisOrigen { get; set; }
        public string? PaisDestino { get; set; }
        public decimal? MontoEnviado { get; set; }
        public string? Moneda { get; set; } // "USD" o "BTC"
        public decimal TasaCambio { get; set; }
        public decimal MontoFinal { get; set; }
        public string? Estado { get; set; } // "Pendiente", "Completada"

    }
}