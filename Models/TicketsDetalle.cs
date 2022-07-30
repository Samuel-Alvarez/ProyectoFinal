using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLottoRewards.Models
{
   public class TicketsDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int TicketId { get; set; }
        public int LoteriaId { get; set; }
        public int TipoJugadaId { get; set; }
        public double TotalMonto { get; set; }
        public int Monto { get; set; }

    }
 
}