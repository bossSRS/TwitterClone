using System;
using TwitterClone.Domain.Entities;

namespace Twitter.Test
{
    public class Class10Test
    {
        public void Run()
        {
            Console.WriteLine("\n--- Running Class 10: Polymorphism & Interfaces Tests ---");

            // 1. Test ILikeable on Tweet
            Console.WriteLine("\n[Test 1: ILikeable on Tweet]");
            var authorId = Guid.NewGuid();
            var tweet = new Tweet(authorId, "Hello, this is my first tweet! #OOP");
            
            Console.WriteLine($"Tweet content: \"{tweet.Content}\"");
            Console.WriteLine("Processing like on active tweet:");
            ProcessLike(tweet); // Should succeed

            Console.WriteLine("Deleting tweet and processing like:");
            tweet.Delete();
            ProcessLike(tweet); // Should show it cannot be liked

            // 2. Test IFollowable and INotifiable on User
            Console.WriteLine("\n[Test 2: IFollowable and INotifiable on User]");
            var user1 = new User("alice", "alice@example.com");
            var user2 = new User("bob", "bob@example.com");

            Console.WriteLine($"User 1: {user1.Username} (Id: {user1.Id})");
            Console.WriteLine($"User 2: {user2.Username} (Id: {user2.Id})");

            Console.WriteLine("User 1 follows User 2:");
            user1.Follow(user2.Id);
            Console.WriteLine($"User 1 Followers count: {user1.Followers.Count}");
            Console.WriteLine($"Does User 1 follow User 2? {user1.Followers.Contains(user2.Id)}");

            Console.WriteLine("User 1 unfollows User 2:");
            user1.Unfollow(user2.Id);
            Console.WriteLine($"User 1 Followers count: {user1.Followers.Count}");

            Console.WriteLine("Sending notification to User 1:");
            var notification = new LikeNotification(user1.Id, user2.Id, tweet.Id);
            user1.Notify(notification);
            Console.WriteLine($"User 1 Notifications count: {user1.Notifications.Count}");
            Console.WriteLine($"Notification ID received: {user1.Notifications[0]}");
        }

        public static void ProcessLike(ILikeable item)
        {
            if (item.CanBeLiked())
            {
                Console.WriteLine("-> Item liked successfully!");
            }
            else
            {
                Console.WriteLine("-> Item cannot be liked (possibly deleted or empty).");
            }
        }
    }
}
