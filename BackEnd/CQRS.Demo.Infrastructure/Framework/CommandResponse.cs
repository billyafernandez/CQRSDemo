﻿using System;

namespace CQRS.Demo.Infrastructure.Framework
{
    public class CommandResponse
    {
        public static CommandResponse Ok = new CommandResponse {Success = true};
        public static CommandResponse Fail = new CommandResponse { Success = false };

        public CommandResponse(Boolean success = false, int aggregateId = 0)
        {
            Success = success;
            AggregateId = aggregateId;
            Description = String.Empty;
        }

        public Boolean Success { get; private set; }
        public int AggregateId { get; private set; }
        public Guid RequestId { get; set; }
        public string Description { get; set; }
    }
}