
using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Repositories;
using ProjetoEventoFF.Domain.Interfaces.Services;

namespace ProjetoEventoFF.Domain.Services
{
    public class EventoService : ServiceBase<Evento>, IEventoService
    {
        private readonly IEventoRepository _EventoRepository;

        public EventoService(IEventoRepository eventoRepository)
            :base(eventoRepository)
        {
            _EventoRepository = eventoRepository;
        }
    }
}
