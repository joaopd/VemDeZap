using Domain.Entities.Base;
using Domain.Enum;

namespace Domain.Entities
{
    public class Grupo : EntidadeBase
    {
        public string Nome { get; private set; }
        public Usuario Usuario { get; private set; }
        public EnumNicho Nicho { get; private set; }
    }
}
