using ProjetoEventoFF.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoEventoFF.Application.Interface
{
    public interface ICalendarioAppService : IAppServiceBase<Calendario>
    {
        IEnumerable<Calendario> BuscarTodos();
        Calendario BuscarPorId(int id);
    }
}
