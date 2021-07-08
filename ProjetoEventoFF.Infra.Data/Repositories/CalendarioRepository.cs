using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEventoFF.Infra.Data.Repositories
{
    public class CalendarioRepository : RepositoryBase<Calendario>, ICalendarioRepository
    {
        public Calendario BuscarPorId(int id)
        {
            return Db.Calendarios
                .Include("Equipe")
                .FirstOrDefault(u => u.CalendarioId == id);
        }

        public IEnumerable<Calendario> BuscarTodos()
        {
            return Db.Calendarios
                .Include("Equipe").ToList();
        }
    }
}
