﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEventoFF.Domain.Entities
{
    public class EventoUsuario
    {
        public bool Confirmado { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int EventoId { get; set; }
        public Evento Evento { get; set; }
    }
}
