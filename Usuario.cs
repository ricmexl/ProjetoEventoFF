using System;

namespace ProjetoEventoFF.Domain.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Setor { get; set; }
        public int DDD { get; set; }
        public int Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
	
