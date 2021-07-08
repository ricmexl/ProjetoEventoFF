using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEventoFF.Infra.Data.Repositories
{
    public class EquipeRepository : RepositoryBase<Equipe>, IEquipeRepository
    {
        public IEnumerable<Equipe> BuscarPOrNome(string nome)
        {
            return Db.Equipes.Where(p => p.Nome == nome);
        }
    }
}
