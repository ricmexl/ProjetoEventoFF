using ProjetoEventoFF.Application.Interface;
using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoEventoFF.Application
{
    public class EventoUsuarioAppService : AppServiceBase<EventoUsuario>, IEventoUsuarioAppService
    {
        private readonly IEventoUsuarioAppService _eventoUsuarioAppService;

        public EventoUsuarioAppService(IEventoUsuarioAppService eventoUsuarioAppService)
            :base((IServiceBase<EventoUsuario>)eventoUsuarioAppService) //cast para um erro inexplicável... se tira apresenta erro de conversão, não encontrei explicação ainda.
        {
            _eventoUsuarioAppService = eventoUsuarioAppService;
        }
        public IEnumerable<EventoUsuario> BuscarPorEvento(int eventoId)
        {
            return _eventoUsuarioAppService.BuscarPorEvento(eventoId);
        }

        public IEnumerable<EventoUsuario> BuscarTodos()
        {
            return _eventoUsuarioAppService.BuscarTodos();
        }
    }
}
