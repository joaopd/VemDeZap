using Domain.Entities.Base;
using Domain.Enum;

namespace Domain.Entities
{
    public class Contato : EntidadeBase
    {
        public string Nome { get; private set; }
        public EnumNicho Nicho { get; private set; }
        public string Telefone { get; private set; }
        public Usuario Usuario { get; private set; }
    }
}
