using ProjetoEventoFF.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoEventoFF.Infra.Data.EntityConfig
{
    public class CalendarioConfiguration: EntityTypeConfiguration<Calendario>
    {
        public CalendarioConfiguration()
        {
            HasKey(p => p.CalendarioId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            HasRequired(p => p.Equipe)
               .WithMany()
               .HasForeignKey(p => p.EquipeId);
        }
    }
}
