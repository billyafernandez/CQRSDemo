using System;

namespace CQRS.Demo.Infrastructure.Framework
{
    public class Event : Message
    {
        public DateTime TimeStamp { get; private set; }

        public Event()
        {
            TimeStamp = DateTime.Now;
            Name = this.GetType().Name;
        }

    }
}