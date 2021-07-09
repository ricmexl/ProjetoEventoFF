using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace ProjetoEventoFF.Infra.Data.Context
{
    public class ProjetoEventoFFContext: DbContext        
    {
        public ProjetoEventoFFContext()
            : base("ProjetoEventoFF")
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Calendario> Calendarios { get; set; }
        public DbSet<EventoUsuario> EventoUsuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //remover plural
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); //remover exclusão em cascata um para muitos
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>(); //remover exclusão em cascata muitos para muitos            

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new EquipeConfiguration());
            modelBuilder.Configurations.Add(new EventoConfiguration());
            modelBuilder.Configurations.Add(new CalendarioConfiguration());
            modelBuilder.Configurations.Add(new EventoUsuarioConfiguration());
        }
        
        //Encontrado um problema com a conexão de banco de dados.. correção encontrada no stackoverflow...
        private void FixEfProviderServicesProblem()
        {
            // The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            // for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            // Make sure the provider assembly is available to the running application. 
            // See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }                
            }

            return base.SaveChanges();
        }
    }
}
