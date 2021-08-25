using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Commands.Usuario.AdicionarUsuario
{
    public class AdicionarUsuarioCommandHandler : IRequestHandler<AdicionarUsuarioCommand, Response>
    {
        public Task<Response> Handle(AdicionarUsuarioCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
