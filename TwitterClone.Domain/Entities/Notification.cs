using System;

namespace TwitterClone.Domain.Entities
{
    public class Notification : BaseEntity
    {
        public Guid RecipientId { get; private set; }
        public string Type { get; protected set; }
        public bool IsRead { get; protected set; }

        public Notification(Guid recipientId, string type) : base()
        {
            RecipientId = recipientId;
            Type = type;
            IsRead = false;
        }

        public void MarkAsRead()
        {
            IsRead = true;
            ModifiedAt = DateTime.UtcNow;
        }
    }
}
