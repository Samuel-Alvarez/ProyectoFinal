using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLottoRewards.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public DateTime Fecha { get; set; }
        public string? TipoJugada { get; set; }
        public string? Loteria { get; set; }
        public string? NombreLoteria { get; set; } 
        public double TotalMonto { get; set; } 
        public int Monto { get; set; }
        
        [ForeignKey("TicketId")]
        public List<TicketsDetalle> Detalle { get; set; } = new List<TicketsDetalle>();

    }

}