using ProjetoEventoFF.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoEventoFF.Domain.Interfaces.Repositories
{
    public interface IEventoRepository : IRepositoryBase<Evento>
    {
        IEnumerable<Evento> BuscarTodos();
        Evento BuscarPorId(int id);
        IEnumerable<Evento> BuscarEventosPorCalendario(int calendarioId);
    }
}
