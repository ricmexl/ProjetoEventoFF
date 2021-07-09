using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEventoFF.Infra.Data.Repositories
{
    public class EventoRepository : RepositoryBase<Evento>, IEventoRepository
    {
        public IEnumerable<Evento> BuscarEventosPorCalendario(int calendarioId)
        {
            return Db.Eventos
                .Include("Calendario")
                .Where(u => u.CalendarioId == calendarioId)
                .ToList();
        }

        public Evento BuscarPorId(int id)
        {
            return Db.Eventos
                .Include("Calendario")
                .FirstOrDefault(u => u.EventoId == id);
        }

        public IEnumerable<Evento> BuscarTodos()
        {
            return Db.Eventos
                .Include("Calendario").ToList();
        }
    }
}
