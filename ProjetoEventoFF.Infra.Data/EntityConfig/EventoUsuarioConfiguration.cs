using ProjetoEventoFF.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoEventoFF.Infra.Data.EntityConfig
{
    public class EventoUsuarioConfiguration : EntityTypeConfiguration<EventoUsuario>
    {
        public EventoUsuarioConfiguration()
        {
            HasKey(p => new { p.EventoId, p.UsuarioId });

            HasRequired(p => p.Usuario)
               .WithMany()
               .HasForeignKey(p => p.UsuarioId);

            HasRequired(p => p.Evento)
               .WithMany()
               .HasForeignKey(p => p.EventoId);
        }
    }
}
