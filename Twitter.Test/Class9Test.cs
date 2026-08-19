using System;
using System.Collections.Generic;
using TwitterClone.Domain.Entities;

namespace Twitter.Test
{
    public class Class9Test
    {
        public void Run()
        {
            var recipientId = Guid.NewGuid();
            var triggerUserId = Guid.NewGuid();
            var tweetId = Guid.NewGuid();
            var commentId = Guid.NewGuid();

            var notifications = new List<Notification>()
            {
                new LikeNotification(recipientId, triggerUserId, tweetId),
                new CommentNotification(recipientId, triggerUserId, commentId),
                new FriendRequestNotification(recipientId, triggerUserId),
                new MentionNotification(recipientId, triggerUserId, tweetId),
                new SystemNotification(recipientId, "System Notification: Unknown Error")
            };

            foreach (var notification in notifications)
            {
                Console.WriteLine(notification.GetMessage());
            }
        }
    }
}
