using System.ComponentModel.DataAnnotations;

namespace MyLottoRewards.Models
{  
    public class TipoJugada
    {   
        [Key]
        public int TipoJugadaId { get; set; }
        public string? NombreJugada { get; set; }
    }
}