using System;

namespace TwitterClone.Domain.Entities
{
    public sealed class SystemNotification : Notification
    {
        public string Message { get; private set; }

        public SystemNotification(Guid recipientId, string message) 
            : base(recipientId, "System")
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException("System message cannot be empty.");

            Message = message;
        }
    }
}
