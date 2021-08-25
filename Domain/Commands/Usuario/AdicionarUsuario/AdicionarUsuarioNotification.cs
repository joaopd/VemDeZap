using MediatR;

namespace Domain.Commands.Usuario.AdicionarUsuario
{
    public class AdicionarUsuarioNotification : INotification
    {
        public Entities.Usuario Usuario { get; set; }
    }
}
