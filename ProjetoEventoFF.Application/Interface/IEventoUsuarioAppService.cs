using ProjetoEventoFF.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoEventoFF.Application.Interface
{
    public interface IEventoUsuarioAppService : IAppServiceBase<EventoUsuario>
    {
        IEnumerable<EventoUsuario> BuscarTodos();
        IEnumerable<EventoUsuario> BuscarPorEvento(int eventoId);
    }
}
