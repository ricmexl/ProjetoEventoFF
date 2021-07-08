using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEventoFF.MVC.ViewModels
{
    public class CalendarioViewModel
    {
        [Key]
        public int CalendarioId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Nome { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public int EquipeId { get; set; }

        public EquipeViewModel Equipe { get; set; }

        public virtual IEnumerable<EventoViewModel> Eventos { get; set; }
    }
}