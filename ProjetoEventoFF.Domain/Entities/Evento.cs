using System;

namespace ProjetoEventoFF.Domain.Entities
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool DiaInteiro { get; set; }
        public bool CampoAberto { get; set; }
        public DateTime DataCadastro { get; set; }
        public int CalendarioId { get; set; }
        public Calendario Calendario { get; set; }

    }
}
