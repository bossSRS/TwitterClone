using System;

namespace TwitterClone.Domain.Entities
{
    public class Follow : BaseEntity
    {
        public Guid FollowerId { get; private set; }
        public Guid FolloweeId { get; private set; }

        public Follow(Guid followerId, Guid followeeId) : base()
        {
            if (followerId == followeeId)
                throw new ArgumentException("Users cannot follow themselves.");

            FollowerId = followerId;
            FolloweeId = followeeId;
        }
    }
}
