using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyLottoRewards.Models
{
    public class Ganancia
    {
        [Key]
        public int GananciaId { get; set; }
        public int Monto { get; set; }
        public string? NombreLoteria { get; set; }
        public string? TipoJugada { get; set; } 
        public double TotalGanancia { get; set; }
        public double TotalMonto { get; set; }
        public DateTime Fecha { get; set; }
        public string? Loteria { get; set; }

        [ForeignKey("GananciaId")]
        public List<GananciasDetalle> Detalle { get; set; } = new List<GananciasDetalle>();

        public Ganancia()
        {
            Fecha= DateTime.Today;
        }
    }
}