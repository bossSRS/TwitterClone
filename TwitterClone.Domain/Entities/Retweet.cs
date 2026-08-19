using System;

namespace TwitterClone.Domain.Entities
{
    public class Retweet : BaseEntity
    {
        public Guid UserId { get; private set; }
        public Guid TweetId { get; private set; }

        public Retweet(Guid userId, Guid tweetId) : base()
        {
            UserId = userId;
            TweetId = tweetId;
        }
    }
}
