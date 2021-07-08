using ProjetoEventoFF.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoEventoFF.Infra.Data.EntityConfig
{
    public class EquipeConfiguration: EntityTypeConfiguration<Equipe>
    {
        public EquipeConfiguration()
        {
            HasKey(p => p.EquipeId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);            
        } 
    }
}
