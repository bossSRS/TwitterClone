using System;
using System.Collections.Generic;

namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity, IFollowable, INotifiable
    {
        private string _username = string.Empty;
        private string _email = string.Empty;

        public string Username
        {
            get => _username;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Username cannot be empty.");
                _username = value;
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                    throw new ArgumentException("Invalid email address.");
                _email = value;
            }
        }

        public List<Guid> Followers { get; private set; } = new();
        public List<Guid> Notifications { get; private set; } = new();

        public User(string username, string email) : base()
        {
            Username = username;
            Email = email;
        }

        public void Follow(Guid id) => Followers.Add(id);

        public void Unfollow(Guid id) => Followers.Remove(id);

        public void Notify(Notification n) => Notifications.Add(n.Id);
    }
}
