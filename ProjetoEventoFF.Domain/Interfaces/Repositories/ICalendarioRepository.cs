using ProjetoEventoFF.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoEventoFF.Domain.Interfaces.Repositories
{
    public interface ICalendarioRepository : IRepositoryBase<Calendario>
    {
        IEnumerable<Calendario> BuscarTodos();
        Calendario BuscarPorId(int id);
    }
}
