namespace TwitterClone.Domain.Entities
{
    public interface INotifiable
    {
        void Notify(Notification n);
    }
}
