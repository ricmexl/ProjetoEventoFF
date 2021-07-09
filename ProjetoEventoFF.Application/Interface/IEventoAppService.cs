using ProjetoEventoFF.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoEventoFF.Application.Interface
{
    public interface IEventoAppService : IAppServiceBase<Evento>
    {
        IEnumerable<Evento> BuscarTodos();
        Evento BuscarPorId(int id);
        IEnumerable<Evento> BuscarEventosPorCalendario(int calendarioId);
    }
}
