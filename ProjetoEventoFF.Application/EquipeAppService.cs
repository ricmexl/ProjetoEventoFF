using ProjetoEventoFF.Application.Interface;
using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEventoFF.Application
{
    public class EquipeAppService : AppServiceBase<Equipe>, IEquipeAppService
    {
        private readonly IEquipeService _equipeService;

        public EquipeAppService(IEquipeService equipeService) 
            : base(equipeService)
        {
            _equipeService = equipeService;
        }

        public IEnumerable<Equipe> BuscarPorNome(string nome)
        {
            return _equipeService.BuscarPOrNome(nome);
        }
    }
}
