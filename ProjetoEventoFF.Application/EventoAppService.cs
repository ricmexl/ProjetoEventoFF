using ProjetoEventoFF.Application.Interface;
using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Services;

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
    }
}
