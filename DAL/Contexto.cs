using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyLottoRewards.Models;

namespace MyLottoRewards.Data;

public class Contexto : IdentityDbContext
{
    public DbSet<Ganancia> Ganancia { get; set; }
    public DbSet<Ticket> Ticket { get; set; }
    public DbSet<Loteria> Loteria { get; set; }
    public DbSet<TipoJugada> TipoJugada { get; set; }
    public Contexto(DbContextOptions<Contexto> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Loteria>().HasData(
            new Loteria{
                LoteriaId = 1,
                NombreLoteria ="Quiniela Loteka"
            },
            new Loteria{
                LoteriaId = 2,
                NombreLoteria ="Loteria Nacional"
            },
            new Loteria{
                LoteriaId = 3,
                NombreLoteria ="Quiniela Leidsa"
            },
            new Loteria{
                LoteriaId = 4,
                NombreLoteria ="Quiniela Real"
            },
            new Loteria{
                LoteriaId = 5,
                NombreLoteria ="La Primera"
            }, 
            new Loteria{
                LoteriaId = 6,
                NombreLoteria ="Pega 3 mas"
            }, 
            new Loteria{
                LoteriaId = 7,
                NombreLoteria ="Loto Pool"
            },  
            new Loteria{
                LoteriaId = 8,
                NombreLoteria ="Loto - Loto Mas"
            }, 
            new Loteria{
                LoteriaId = 9,
                NombreLoteria ="Loto Real"
            },
           
            new Loteria{
                LoteriaId = 10,
                NombreLoteria ="Gana Mas"
            }
               
        );

        modelBuilder.Entity<TipoJugada>().HasData(
            new TipoJugada{
                TipoJugadaId = 1,
                NombreJugada ="Pale"
            },
            new TipoJugada{
                TipoJugadaId = 2,
                NombreJugada ="Tripleta"
            },
            new TipoJugada{
                TipoJugadaId = 3,
                NombreJugada ="Quiniela"
            },
            new TipoJugada{
                TipoJugadaId = 4,
                NombreJugada ="Super pale"
            }      
        );
    }
}
