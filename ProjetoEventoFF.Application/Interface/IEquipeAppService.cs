using ProjetoEventoFF.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoEventoFF.Application.Interface
{
    public interface IEquipeAppService : IAppServiceBase<Equipe>
    {
        IEnumerable<Equipe> BuscarPorNome(string nome);
    }
}
