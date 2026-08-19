using System;

namespace TwitterClone.Domain.Entities
{
    public abstract class Notification : BaseEntity
    {
        public Guid RecipientId { get; protected set; }
        public string Type { get; protected set; }
        public bool IsRead { get; private set; }

        protected Notification(Guid recipientId, string type) : base()
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

        public abstract string GetMessage();
    }
}
