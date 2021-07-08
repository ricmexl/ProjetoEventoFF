using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Repositories;
using ProjetoEventoFF.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoEventoFF.Domain.Services
{
    public class CalendarioService : ServiceBase<Calendario>, ICalendarioService
    {
        private readonly ICalendarioRepository _calendarioRepository;

        public CalendarioService(ICalendarioRepository calendarioRepository)
            : base(calendarioRepository)
        {
            _calendarioRepository = calendarioRepository;
        }

        public Calendario BuscarPorId(int id)
        {
            return _calendarioRepository.BuscarPorId(id);
        }

        public IEnumerable<Calendario> BuscarTodos()
        {
            return _calendarioRepository.BuscarTodos();
        }
    }
}
