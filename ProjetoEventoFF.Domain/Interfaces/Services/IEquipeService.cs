using ProjetoEventoFF.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoEventoFF.Domain.Interfaces.Services
{
    public interface IEquipeService : IServiceBase<Equipe>
    {
        IEnumerable<Equipe> BuscarPOrNome(string nome);
    }
}
