using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace ProjetoEventoFF.Domain.Interfaces.Services
{
    public interface IUsuarioService : IRepositoryBase<Usuario>
    {
        IEnumerable<Usuario> ObterUsuariosAntigos(IEnumerable<Usuario> usuarios);
    }
}
