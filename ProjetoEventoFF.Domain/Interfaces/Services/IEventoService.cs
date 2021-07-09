using ProjetoEventoFF.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoEventoFF.Domain.Interfaces.Services
{
    public interface IEventoService : IServiceBase<Evento>
    {
        IEnumerable<Evento> BuscarTodos();
        Evento BuscarPorId(int id);

        IEnumerable<Evento> BuscarEventosPorCalendario(int calendarioId);
    }
}
