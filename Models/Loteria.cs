using System.ComponentModel.DataAnnotations;

namespace MyLottoRewards.Models
{
    public class Loteria
    {
        [Key]
        public int LoteriaId { get; set; }
        public string? NombreLoteria { get; set; }
    }
}