using System.Collections.Generic;

namespace ProjetoEventoFF.Domain.Entities
{
    public class Equipe
    {
        public int EquipeId { get; set; }
        public string Nome { get; set; }
        public string DataCadastro { get; set; }        
        public virtual IEnumerable<Usuario> Usuarios { get; set; }
    }
}
