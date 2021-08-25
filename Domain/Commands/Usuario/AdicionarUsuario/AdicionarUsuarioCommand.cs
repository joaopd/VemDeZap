﻿using MediatR;

namespace Domain.Commands.Usuario.AdicionarUsuario
{
    public class AdicionarUsuarioCommand : IRequest<Response>
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
