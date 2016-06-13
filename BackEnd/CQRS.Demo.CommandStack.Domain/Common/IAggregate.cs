using System;
using System.Collections.Generic;

namespace CQRS.Demo.CommandStack.Domain.Common
{
    public interface IAggregate
    {
        Guid Id { get; }
        bool HasPendingChanges { get; }
        IEnumerable<DomainEvent> GetUncommittedEvents();
        void ClearUncommittedEvents(); 
    }
}