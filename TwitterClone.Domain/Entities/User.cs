using System;

namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity
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

        public User(string username, string email) : base()
        {
            Username = username;
            Email = email;
        }
    }
}
