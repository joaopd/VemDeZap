using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Grupo
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public int Nicho { get; private set; }
    }
}
