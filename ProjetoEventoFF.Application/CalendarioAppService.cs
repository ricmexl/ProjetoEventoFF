using ProjetoEventoFF.Application.Interface;
using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoEventoFF.Application
{
    public class CalendarioAppService : AppServiceBase<Calendario>, ICalendarioAppService
    {
       
        private readonly ICalendarioService _calendarioService;

        public CalendarioAppService(ICalendarioService calendarioService) 
            : base(calendarioService)
        {
            _calendarioService = calendarioService;
        }

        public Calendario BuscarPorId(int id)
        {
            return _calendarioService.BuscarPorId(id);
        }

        public IEnumerable<Calendario> BuscarTodos()
        {
            return _calendarioService.BuscarTodos();
        }
    }
}
