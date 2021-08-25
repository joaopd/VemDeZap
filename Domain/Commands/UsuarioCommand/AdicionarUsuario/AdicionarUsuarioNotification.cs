using Domain.Entities;
using MediatR;

namespace Domain.Commands.UsuarioCommand.AdicionarUsuario
{
    public class AdicionarUsuarioNotification : INotification
    {
        public AdicionarUsuarioNotification(Usuario usuario)
        {
            Usuario = usuario;
        }

        public Usuario Usuario { get; set; }
    }
}
