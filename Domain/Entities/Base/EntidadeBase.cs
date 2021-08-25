using prmToolkit.NotificationPattern;
using System;

namespace Domain.Entities.Base
{
    public abstract class EntidadeBase : Notifiable
    {
        public Guid Id { get; set; }

        protected EntidadeBase()
        {
            Id = Guid.NewGuid();
        }
    }
}
