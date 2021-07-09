
using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Repositories;
using ProjetoEventoFF.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoEventoFF.Domain.Services
{
    public class EventoService : ServiceBase<Evento>, IEventoService
    {
        private readonly IEventoRepository _eventoRepository;

        public EventoService(IEventoRepository eventoRepository)
            :base(eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        public IEnumerable<Evento> BuscarEventosPorCalendario(int calendarioId)
        {
            return _eventoRepository.BuscarEventosPorCalendario(calendarioId);
        }

        public Evento BuscarPorId(int id)
        {
            return _eventoRepository.BuscarPorId(id);
        }

        public IEnumerable<Evento> BuscarTodos()
        {
            return _eventoRepository.BuscarTodos();
        }
    }
}
