using ProjetoEventoFF.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoEventoFF.Domain.Interfaces.Repositories
{
    public interface IEventoUsuarioRepository : IRepositoryBase<EventoUsuario>
    {
        IEnumerable<EventoUsuario> BuscarTodos();
        IEnumerable<EventoUsuario> BuscarPorEvento(int eventoId);
    }
}
