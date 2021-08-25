using prmToolkit.NotificationPattern;
using System.Collections.Generic;

namespace Domain.Commands
{
    public class Response
    {
        public object Data { get; private set; }
        public bool Success { get; private set; }
        public IEnumerable<Notification> Notifications { get; }

        public Response(INotifiable notifiable)
        {
            Success = notifiable.IsValid();
            Notifications = notifiable.Notifications;
        }

        public Response(INotifiable notifiable, object data)
        {
            Success = notifiable.IsValid();
            Data = data;
            Notifications = notifiable.Notifications;
        }
    }
}
