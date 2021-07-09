using ProjetoEventoFF.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoEventoFF.Domain.Interfaces.Services
{
    public interface IEventoUsuarioService : IServiceBase<EventoUsuario>
    {
        IEnumerable<EventoUsuario> BuscarTodos();
        IEnumerable<EventoUsuario> BuscarPorEvento(int eventoId);
    }
}
