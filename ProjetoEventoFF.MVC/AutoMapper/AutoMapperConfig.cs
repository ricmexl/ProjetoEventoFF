using AutoMapper;

namespace ProjetoEventoFF.MVC.AutoMapper
{
    public class AutoMapperConfig: Profile
    {
        public static IMapper RegisterMappings()
        {
            var config = new MapperConfiguration(ps =>
            {
                ps.AddProfile(new DomainToViewModelMappingProfile());
                ps.AddProfile(new ViewModelToDomainMappingProfile());
            });
            
            return config.CreateMapper();
        }
    }
}