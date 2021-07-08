using ProjetoEventoFF.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoEventoFF.Domain.Interfaces.Repositories
{
    public interface IEquipeRepository : IRepositoryBase<Equipe>
    {
        IEnumerable<Equipe> BuscarPOrNome(string nome);
    }
}
