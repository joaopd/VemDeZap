using System;

namespace Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; private set; }
        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
    }
}
