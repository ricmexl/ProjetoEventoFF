using ProjetoEventoFF.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoEventoFF.Infra.Data.EntityConfig
{
    public class EventoConfiguration : EntityTypeConfiguration<Evento>
    {
        public EventoConfiguration()
        {
            HasKey(p => p.EventoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Local)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(500);

            Property(p => p.DiaInteiro)
                .IsRequired();

            Property(p => p.CampoAberto)
                .IsRequired();

            HasRequired(p => p.Calendario)
               .WithMany()
               .HasForeignKey(p => p.CalendarioId);
        }
    }
}
