using ProjetoEventoFF.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoEventoFF.Domain.Interfaces.Services
{
    public interface ICalendarioService : IServiceBase<Calendario>
    {
        IEnumerable<Calendario> BuscarTodos();
        Calendario BuscarPorId(int id);
    }
}
