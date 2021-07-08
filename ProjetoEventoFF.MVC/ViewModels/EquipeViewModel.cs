using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoEventoFF.MVC.ViewModels
{
    public class EquipeViewModel
    {
        [Key]
        public int EquipeId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Nome { get; set; }

        [ScaffoldColumn(false)]
        public string DataCadastro { get; set; }

        public virtual IEnumerable<UsuarioViewModel> Usuarios { get; set; }

    }
}