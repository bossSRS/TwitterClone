using System;

namespace TwitterClone.Domain.Entities
{
    public sealed class FriendRequestNotification : Notification
    {
        public Guid SenderId { get; private set; }

        public FriendRequestNotification(Guid recipientId, Guid senderId) 
            : base(recipientId, "Friend Request")
        {
            SenderId = senderId;
        }
    }
}
