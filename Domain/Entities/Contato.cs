using System;

namespace Domain.Entities
{
    public class Contato
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public int Nicho { get; private set; }
        public string Telefone { get; private set; }
    }
}
