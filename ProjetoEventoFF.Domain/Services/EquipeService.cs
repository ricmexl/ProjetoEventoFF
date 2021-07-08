using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Repositories;
using ProjetoEventoFF.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoEventoFF.Domain.Services
{
    public class EquipeService : ServiceBase<Equipe>, IEquipeService
    {
        private readonly IEquipeRepository _equipeRepository;

        public EquipeService(IEquipeRepository equipeRepository)
            : base(equipeRepository)
        {
            _equipeRepository = equipeRepository;
        }

        public IEnumerable<Equipe> BuscarPOrNome(string nome)
        {
            return _equipeRepository.BuscarPOrNome(nome);
        }
    }
}
