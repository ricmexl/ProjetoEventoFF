using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Repositories;
using ProjetoEventoFF.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEventoFF.Domain.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
            :base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }        

        public IEnumerable<Usuario> ObterUsuariosAntigos(IEnumerable<Usuario> usuarios)
        {
            return usuarios.Where(c => c.UsuariosAntigos(c));
        }

        public IEnumerable<Usuario> BuscarTodos()
        {
            return _usuarioRepository.BuscarTodos();
        }

        public Usuario BuscarPorId(int id)
        {
            return _usuarioRepository.BuscarPorId(id);
        }
    }
}
