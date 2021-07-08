using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Repositories;

namespace ProjetoEventoFF.Infra.Data.Repositories
{
    public class EventoRepository : RepositoryBase<Evento>, IEventoRepository
    {
    }
}
