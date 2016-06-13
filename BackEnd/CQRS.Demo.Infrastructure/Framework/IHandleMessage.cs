namespace CQRS.Demo.Infrastructure.Framework
{
    public interface IHandleMessage<in T>
    {
        void Handle(T message);
    }
}