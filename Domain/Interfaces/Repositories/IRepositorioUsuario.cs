using Domain.Entities;
using Domain.Interfaces.Repositories.Base;
using System;

namespace Domain.Interfaces.Repositories
{
    public interface IRepositorioUsuario : IRepositorioBase<Usuario, Guid>
    {
    }
}
