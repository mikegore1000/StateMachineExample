using System;

namespace StateMachineExample.Messages
{
    class DataCashAccepted : IEvent
    {
        public Guid AuthCode { get; set; }
    }
}