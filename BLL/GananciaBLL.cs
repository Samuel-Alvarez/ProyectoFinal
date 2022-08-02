using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MyLottoRewards.Data;
using MyLottoRewards.Models;

public class GananciaBLL
    {
        private Contexto _contexto;

        public GananciaBLL(Contexto contexto)
        {
            _contexto = contexto;
        }
        public bool Existe(int Id)
        {
            return _contexto.Ganancia.Any(c => c.GananciaId == Id);
        }
        public bool Guardar(Ganancia ganancia)
        {
            bool paso = false;

            if (!Existe(ganancia.GananciaId))
                paso = Insertar(ganancia);
            else
                paso = Modificar(ganancia);
               return paso;

        }
        private bool Insertar(Ganancia ganancia)
        {
            _contexto.Ganancia.Add(ganancia);
         
            bool insertar = _contexto.SaveChanges() >0;
            _contexto.Entry(ganancia).State = EntityState.Detached;
            return insertar;           
        }
        
         private bool Modificar(Ganancia ganancia)
        {
            var anterior = _contexto.Ganancia
           .Where(c => c.GananciaId == ganancia.GananciaId)
           .Include(c => c.Detalle)
           .AsNoTracking()
           .SingleOrDefault();

            _contexto.Database.ExecuteSqlRaw($"DELETE FROM GananciasDetalle WHERE GananciaId={ganancia.GananciaId};");

            _contexto.Entry(ganancia).State = EntityState.Modified;

            var guardo = _contexto.SaveChanges() > 0;
            _contexto.Entry(ganancia).State = EntityState.Detached;
            return guardo;
        }
       public bool Eliminar(Ganancia ganancia)
        {
            _contexto.Ganancia.Add(ganancia);
        
            _contexto.Entry(ganancia).State = EntityState.Deleted;

            bool elimino = _contexto.SaveChanges() > 0;
            _contexto.Entry(ganancia).State = EntityState.Detached;
               
            return elimino;
        } 

        public Ganancia? Buscar(int ganancia)
        {
            return _contexto.Ganancia
            .Include(c => c.Detalle)
            .Where(c => c.GananciaId == ganancia)
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
        public List<Ganancia> GetList()
        {
            return _contexto.Ganancia.AsNoTracking().ToList();
        }
        public List<Loteria> LotoList()
        {
            return _contexto.Loteria.AsNoTracking().ToList();
        }
        
        public List<TipoJugada> TipoJugadaList()
        {
            return _contexto.TipoJugada.AsNoTracking().ToList();
        }
        public List<Ganancia> GetList(Expression<Func<Ganancia, bool>>criterio)
        {
            List<Ganancia> lista = new List<Ganancia>();

            try
            {
                lista=_contexto.Ganancia
                .Include(t =>t.Detalle)
                .Where(criterio).AsNoTracking()
                .ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
        return lista;
    }
}
