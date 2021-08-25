using Domain.Entities.Base;
using System;

namespace Domain.Entities
{
    public class Envio : EntidadeBase
    {
        public Campanha Campanha { get; private set; }
        public Grupo Grupo { get; private set; }
        public Contato Contato { get; private set; }
        public bool Enviado { get; private set; }
    }
}
