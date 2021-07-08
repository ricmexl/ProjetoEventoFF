using AutoMapper;
using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.MVC.ViewModels;

namespace ProjetoEventoFF.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<Equipe, EquipeViewModel>();
            CreateMap<Calendario, CalendarioViewModel>();
            CreateMap<Evento, EventoViewModel>();
        }
        
    }
}