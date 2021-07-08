using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEventoFF.Infra.Data.Repositories
{
    public class UsuarioRepository:RepositoryBase<Usuario>, IUsuarioRepository
    {
        public Usuario BuscarPorId(int id)
        {
            return Db.Usuarios
                .Include("Equipe")
                .FirstOrDefault(u => u.UsuarioId == id);
        }

        public IEnumerable<Usuario> BuscarTodos()
        {
            return Db.Usuarios
                .Include("Equipe").ToList();
        }
    }
}
