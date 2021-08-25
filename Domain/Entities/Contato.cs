using Domain.Entities.Base;
using System;

namespace Domain.Entities
{
    public class Contato : EntidadeBase
    {
        public string Nome { get; private set; }
        public int Nicho { get; private set; }
        public string Telefone { get; private set; }
        public Usuario Usuario { get; private set; }
    }
}
