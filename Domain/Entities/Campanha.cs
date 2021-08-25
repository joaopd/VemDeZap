using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Campanha : EntidadeBase
    {
        public string Nome { get; private set; }
        public Usuario Usuario { get; private set; }
    }
}
