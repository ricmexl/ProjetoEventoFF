using ProjetoEventoFF.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoEventoFF.Infra.Data.EntityConfig
{
    public class UsuarioConfiguration: EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(p => p.UsuarioId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Apelido)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.Setor)
                .IsRequired()
                .HasMaxLength(50);

            Property(p => p.DDD)
                .IsRequired()
                .HasMaxLength(2);

            Property(p => p.Telefone)
                .IsRequired()
                .HasMaxLength(9);

            HasRequired(p => p.Equipe)
                .WithMany()
                .HasForeignKey(p => p.EquipeId);


        }
    }
}
