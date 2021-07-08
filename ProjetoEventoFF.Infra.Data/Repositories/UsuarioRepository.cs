﻿using ProjetoEventoFF.Domain.Entities;
using ProjetoEventoFF.Domain.Interfaces;
using ProjetoEventoFF.Domain.Interfaces.Repositories;

namespace ProjetoEventoFF.Infra.Data.Repositories
{
    public class UsuarioRepository:RepositoryBase<Usuario>, IUsuarioRepository
    {
    }
}
