using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Repositories;
using ProjetoEventoFF.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoEventoFF.Domain.Services
{
    public class EventoUsuarioService : ServiceBase<EventoUsuario>, IEventoUsuarioService
    {
        private readonly IEventoUsuarioRepository _eventoUsuarioRepository;

        public EventoUsuarioService(IEventoUsuarioRepository eventoUsuarioRepository)
            : base(eventoUsuarioRepository)
        {
            _eventoUsuarioRepository = eventoUsuarioRepository;
        }

        public IEnumerable<EventoUsuario> BuscarPorEvento(int eventoId)
        {
            return _eventoUsuarioRepository.BuscarPorEvento(eventoId);
        }

        public IEnumerable<EventoUsuario> BuscarTodos()
        {
            return _eventoUsuarioRepository.BuscarTodos();
        }
    }
}
