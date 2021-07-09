using System;
using System.Collections.Generic;

namespace ProjetoEventoFF.Domain.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Setor { get; set; }
        public string DDD { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public int EquipeId { get; set; }
        public Equipe Equipe { get; set; }
        public IEnumerable<EventoUsuario> EventoUsuarios { get; set; }

        /*
         Regra de negócio da entidade... só minha entidade saber dizer se um usuário é antigo.
         */
        public bool UsuariosAntigos(Usuario usuario)
        {
            return (DateTime.Now.Day - usuario.DataCadastro.Day) > 1 && usuario.Ativo;
        }
    }
}
