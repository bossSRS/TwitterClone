using System;

namespace TwitterClone.Domain.Entities
{
    public sealed class CommentNotification : Notification
    {
        public Guid CommentId { get; private set; }
        public Guid CommenterId { get; private set; }

        public CommentNotification(Guid recipientId, Guid commenterId, Guid commentId) 
            : base(recipientId, "Comment")
        {
            CommenterId = commenterId;
            CommentId = commentId;
        }

        public override string GetMessage() => $"User {CommenterId} commented on your tweet";
    }
}
