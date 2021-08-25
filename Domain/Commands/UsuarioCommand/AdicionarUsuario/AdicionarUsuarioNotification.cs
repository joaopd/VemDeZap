using Domain.Entities;
using MediatR;

namespace Domain.Commands.UsuarioCommand.AdicionarUsuario
{
    public class AdicionarUsuarioNotification : INotification
    {
        public Usuario Usuario { get; set; }
    }
}
