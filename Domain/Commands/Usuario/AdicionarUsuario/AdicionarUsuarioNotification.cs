using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands.Usuario.AdicionarUsuario
{
    public class AdicionarUsuarioNotification : INotification
    {
        public Entities.Usuario Usuario { get; set; }
    }
}
