using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEventoFF.Infra.Data.Repositories
{
    public class EventoUsuarioRepository : RepositoryBase<EventoUsuario>, IEventoUsuarioRepository
    {
        public IEnumerable<EventoUsuario> BuscarPorEvento(int eventoId)
        {
            return Db.EventoUsuarios
                .Include("Usuario")
                .Include("Evento")
                .Where(p => p.EventoId == eventoId)
                .ToList();
        }

        public IEnumerable<EventoUsuario> BuscarTodos()
        {
            return Db.EventoUsuarios
                .Include("Usuario")
                .Include("Evento")
                .ToList();
        }
    }
}
