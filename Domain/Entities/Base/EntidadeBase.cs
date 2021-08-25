using System;

namespace Domain.Entities.Base
{
    public abstract class EntidadeBase
    {
        public Guid Id { get; set; }

        protected EntidadeBase()
        {
            Id = Guid.NewGuid();
        }
    }
}
