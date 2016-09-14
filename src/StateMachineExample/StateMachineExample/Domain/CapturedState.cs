using System.Collections.Generic;
using StateMachineExample.Messages;

namespace StateMachineExample.Domain
{
    class CapturedState : PaymentState
    {
        public CapturedState()
        {
            Register<AcceptPayment>(Handle);
            Register<DataCashAccepted>(Handle);
        }

        private IEnumerable<IEvent> Handle(AcceptPayment command)
        {
            yield return new AcceptRequested();
        }

        private IEnumerable<IEvent> Handle(DataCashAccepted @event)
        {
            yield return new PaymentAccepted { AuthCode = @event.AuthCode };
        }
    }
}