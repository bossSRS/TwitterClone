using System;

namespace TwitterClone.Domain.Entities
{
    public sealed class MentionNotification : Notification
    {
        public Guid MentionedById { get; private set; }
        public Guid TweetId { get; private set; }

        public MentionNotification(Guid recipientId, Guid mentionedById, Guid tweetId) 
            : base(recipientId, "Mention")
        {
            MentionedById = mentionedById;
            TweetId = tweetId;
        }

        public override string GetMessage() => $"User {MentionedById} mentioned you";
    }
}
