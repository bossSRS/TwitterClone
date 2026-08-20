using System;

namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity, ILikeable
    {
        private string _content = string.Empty;

        public Guid AuthorId { get; private set; }

        public string Content
        {
            get => _content;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tweet content cannot be empty.");
                if (value.Length > 280)
                    throw new ArgumentException("Tweet cannot exceed 280 characters.");

                _content = value;
            }
        }

        public Tweet(Guid authorId, string content) : base()
        {
            AuthorId = authorId;
            SetContent(content);
        }

        public void SetContent(string content)
        {
            Content = content;
            ModifiedAt = DateTime.UtcNow;
        }

        public bool IsDeleted { get; private set; }

        public void Delete()
        {
            IsDeleted = true;
            ModifiedAt = DateTime.UtcNow;
        }

        public bool CanBeLiked() => !IsDeleted && !string.IsNullOrWhiteSpace(Content);

        public override string Describe() => $"Tweet: {Content}";

        public override string Summarize() => base.Summarize() + $" - Content: {Content}";
    }
}
