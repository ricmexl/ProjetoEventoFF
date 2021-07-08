using ProjetoEventoFF.Application.Interface;
using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEventoFF.Application
{
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService) 
            : base((IServiceBase<Usuario>)usuarioService)      //cast para um erro inexplicável... se tira apresenta erro de conversão, não encontrei explicação ainda.  
        {
            _usuarioService = usuarioService;
        }

        public Usuario BuscarPorId(int id)
        {
            return _usuarioService.BuscarPorId(id);
        }

        public IEnumerable<Usuario> BuscarTodos()
        {
            return _usuarioService.BuscarTodos();
        }

        public IEnumerable<Usuario> ObterUsuariosAntigos()
        {            
            return _usuarioService.ObterUsuariosAntigos(_usuarioService.GetAll());
        }
    }
}
