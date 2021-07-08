using ProjetoEventoFF.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoEventoFF.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository: IRepositoryBase<Usuario>
    {
        IEnumerable<Usuario> BuscarTodos();

        Usuario BuscarPorId(int id);
    }
}
