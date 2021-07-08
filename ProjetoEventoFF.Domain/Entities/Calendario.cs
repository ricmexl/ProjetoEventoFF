using System;
using System.Collections.Generic;

namespace ProjetoEventoFF.Domain.Entities
{
    public class Calendario
    {
        public int CalendarioId { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public int EquipeId { get; set; }
        public Equipe Equipe { get; set; }
        public virtual IEnumerable<Evento> Eventos { get; set; }
        
    }
}
