using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Envio
    {
        public Guid Id { get; private set; }
        public Campanha Campanha{ get; private set; }
        public Grupo Grupo{ get; private set; }
        public Contato Contato{ get; private set; }
        public bool Enviado{ get;private set; }
    }
}
