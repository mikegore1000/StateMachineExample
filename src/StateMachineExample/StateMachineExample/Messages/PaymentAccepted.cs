using System;

namespace StateMachineExample.Messages
{
    class PaymentAccepted : IEvent
    {
        public Guid AuthCode { get; set; }
    }
}