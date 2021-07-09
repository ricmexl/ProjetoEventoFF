using AutoMapper;
using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.MVC.ViewModels;

namespace ProjetoEventoFF.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<UsuarioViewModel, Usuario>();
            CreateMap<EquipeViewModel, Equipe>();
            CreateMap<CalendarioViewModel, Calendario>();
            CreateMap<EventoViewModel, Evento>();
            CreateMap<EventoUsuarioViewModel, EventoUsuario>();
        }
    }
}