using Domain.Interfaces.Repositories;
using MediatR;
using prmToolkit.NotificationPattern;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Commands.UsuarioCommand.AdicionarUsuario
{
    public class AdicionarUsuarioCommandHandler : Notifiable, IRequestHandler<AdicionarUsuarioCommand, Response>
    {
        private readonly IRepositorioUsuario _repositorioUsuario;
        private readonly IMediator _mediator;

        public AdicionarUsuarioCommandHandler(IRepositorioUsuario repositorioUsuario, IMediator mediator)
        {
            _repositorioUsuario = repositorioUsuario;
            _mediator = mediator;
        }

        public async Task<Response> Handle(AdicionarUsuarioCommand request, CancellationToken cancellationToken)
        {
            //validar se requst e valido
            if (request == null)
            {
                AddNotification("Request", "Informe os dados do usuario");
                return new Response(this);
            }

            //verificar se usuario existe
            if (_repositorioUsuario.Existe(x => x.Email == request.Email))
            {
                AddNotification("Email", "Email ja cadastrado no sistema");
                return new Response(this);
            }

            Usuario usuario = new Usuario(request.PrimeiroNome,request.UltimoNome,request.Email, request.Senha);
            AddNotifications(usuario);
            if (IsInvalid())
            {
                return new Response(this);
            }

            usuario = _repositorioUsuario.Adicionar(usuario);

            var response = new Response(this, usuario);

            AdicionarUsuarioNotification adicionarUsuarioNotification = new AdicionarUsuarioNotification(usuario);

            await _mediator.Publish(adicionarUsuarioNotification);

            return await Task.FromResult(response);
        }
    }
}
