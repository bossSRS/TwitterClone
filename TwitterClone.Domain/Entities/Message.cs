using System;

namespace TwitterClone.Domain.Entities
{
    public class Message : BaseEntity
    {
        public Guid SenderId { get; private set; }
        public Guid ReceiverId { get; private set; }
        public string Content { get; private set; }

        public Message(Guid senderId, Guid receiverId, string content) : base()
        {
            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Message content cannot be empty.");

            SenderId = senderId;
            ReceiverId = receiverId;
            Content = content;
        }
    }
}
