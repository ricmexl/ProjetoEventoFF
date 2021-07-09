using ProjetoEventoFF.Application.Interface;
using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoEventoFF.Application
{
    public class EventoAppService :AppServiceBase<Evento>, IEventoAppService
    {
        private readonly IEventoService _eventoService;

        public EventoAppService(IEventoService eventoService)
            :base(eventoService)
        {
            _eventoService = eventoService;
        }

        public IEnumerable<Evento> BuscarEventosPorCalendario(int calendarioId)
        {
            return _eventoService.BuscarEventosPorCalendario(calendarioId);
        }

        public Evento BuscarPorId(int id)
        {
            return _eventoService.BuscarPorId(id);
        }

        public IEnumerable<Evento> BuscarTodos()
        {
            return _eventoService.BuscarTodos();
        }
    }
}
