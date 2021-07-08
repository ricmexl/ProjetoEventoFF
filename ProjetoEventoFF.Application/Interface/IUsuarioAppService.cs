using ProjetoEventoFF.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoEventoFF.Application.Interface
{
    public interface IUsuarioAppService : IAppServiceBase<Usuario>
    {
        IEnumerable<Usuario> ObterUsuariosAntigos();
        IEnumerable<Usuario> BuscarTodos();
        Usuario BuscarPorId(int id);
    }
}
