using Microsoft.EntityFrameworkCore;
using MyLottoRewards.Data;
using MyLottoRewards.Models;

public class TicketBLL
    {
        private Contexto _contexto;

        public TicketBLL(Contexto contexto)
        {
            _contexto = contexto;
        }
        public bool Existe(int Id)
        {
            return _contexto.Ticket.Any(c => c.TicketId == Id);
        }
        public bool Guardar(Ticket ticket)
        {
            bool paso = false;

            if (!Existe(ticket.TicketId))
                paso = Insertar(ticket);
            else
                paso = Modificar(ticket);
               return paso;

        }
        private bool Insertar(Ticket ticket)
        {
            _contexto.Ticket.Add(ticket);
         
            bool insertar = _contexto.SaveChanges() >0;
            _contexto.Entry(ticket).State = EntityState.Detached;
            return insertar;           
        }
        
         private bool Modificar(Ticket ticket)
        {
            var anterior = _contexto.Ticket
           .Where(c => c.TicketId == ticket.TicketId)
           .Include(c => c.Detalle)
           .AsNoTracking()
           .SingleOrDefault();

            _contexto.Database.ExecuteSqlRaw($"DELETE FROM TicketsDetalle WHERE TicketId={ticket.TicketId};");

            _contexto.Entry(ticket).State = EntityState.Modified;

            var guardo = _contexto.SaveChanges() > 0;
            _contexto.Entry(ticket).State = EntityState.Detached;
            return guardo;
        }
       public bool Eliminar(Ticket ticket)
        {
            _contexto.Ticket.Add(ticket);
        
            _contexto.Entry(ticket).State = EntityState.Deleted;

            bool elimino = _contexto.SaveChanges() > 0;
            _contexto.Entry(ticket).State = EntityState.Detached;
               
            return elimino;
        } 

        public Ticket? Buscar(int ticket)
        {
            return _contexto.Ticket
            .Include(c => c.Detalle)
            .Where(c => c.TicketId == ticket)
            .AsNoTracking()
            .SingleOrDefault();
        }

        public string GetNombreJugada(int tipo)
        {
            var _tipo = _contexto.TipoJugada
            .Where(t => t.TipoJugadaId ==tipo)
            .AsNoTracking()
            .SingleOrDefault();
            return _tipo.NombreJugada;
        }

        public string GetNombreLoteria(int loteria)
        {
            var _loto = _contexto.Loteria
            .Where(l => l.LoteriaId == loteria)
            .AsNoTracking()
            .SingleOrDefault();
            return _loto.NombreLoteria;
        }
        public List<Ticket> GetList()
        {
            return _contexto.Ticket.AsNoTracking().ToList();
        }
        public List<Loteria> LotoList()
        {
            return _contexto.Loteria.AsNoTracking().ToList();
        }
        
        public List<TipoJugada> TipoJugadaList()
        {
            return _contexto.TipoJugada.AsNoTracking().ToList();
        }
}