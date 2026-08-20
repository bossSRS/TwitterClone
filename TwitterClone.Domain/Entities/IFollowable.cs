using System;

namespace TwitterClone.Domain.Entities
{
    public interface IFollowable
    {
        void Follow(Guid id);
        void Unfollow(Guid id);
    }
}
