using CQRS.Demo.CommandStack.Domain.Common;

namespace CQRS.Demo.Infrastructure.Framework.Repositories
{
    public interface IRepository
    {
        //TEntity Get(TKey id);
        //void Save(TEntity entity);
        //void Delete(TEntity entity);

        T GetById<T>(int id) where T : IAggregate;

        CommandResponse CreateTweetFromRequest<T>(T item) where T : class, IAggregate;
        //CommandResponse Update(int bookingId, int hour, int length, string name);

    }
}