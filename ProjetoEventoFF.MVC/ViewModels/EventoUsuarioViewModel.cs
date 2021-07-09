namespace ProjetoEventoFF.MVC.ViewModels
{
    public class EventoUsuarioViewModel
    {
        public bool Confirmado { get; set; }
        public int UsuarioId { get; set; }
        public UsuarioViewModel Usuario { get; set; }
        public int EventoId { get; set; }
        public EventoViewModel Evento { get; set; }
    }
}