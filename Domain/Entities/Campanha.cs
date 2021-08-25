using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Campanha: EntidadeBase
    {
        public string Nome { get; private set; }
        public Usuario Usuario { get; private set; }
    }
}
