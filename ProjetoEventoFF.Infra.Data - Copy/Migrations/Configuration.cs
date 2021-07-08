namespace ProjetoEventoFF.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.ProjetoEventoFFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.ProjetoEventoFFContext context)
        {
            
        }
    }
}
