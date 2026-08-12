using System;

namespace TwitterClone.Domain.Entities
{
    public sealed class LikeNotification : Notification
    {
        public Guid LikedById { get; private set; }
        public Guid TweetId { get; private set; }

        public LikeNotification(Guid recipientId, Guid likedById, Guid tweetId) 
            : base(recipientId, "Like")
        {
            LikedById = likedById;
            TweetId = tweetId;
        }
    }
}
