using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEventoFF.MVC.ViewModels
{
    public class EventoViewModel
    {
        [Key]
        public int EventoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descrição")]
        [MaxLength(500, ErrorMessage = "Máximo 500 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Preencha o campo Local")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Local { get; set; }

        [Required(ErrorMessage = "Preencha o campo Data de Início")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "Preencha o campo Data de Fim")]
        public DateTime DataFim { get; set; }
       
        public bool DiaInteiro { get; set; }

        public bool CampoAberto { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public int CalendarioId { get; set; }

        public CalendarioViewModel Calendario { get; set; }
        public IEnumerable<EventoUsuarioViewModel> EventoUsuarios { get; set; }
    }
}