using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Usuario : EntidadeBase
    {
        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
    }
}
