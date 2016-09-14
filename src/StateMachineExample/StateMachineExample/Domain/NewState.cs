using System.Collections.Generic;
using StateMachineExample.Messages;

namespace StateMachineExample.Domain
{
    class NewState : PaymentState
    {
        public NewState()
        {
            Register<CapturePayment>(Handle);
        }

        private IEnumerable<IEvent> Handle(CapturePayment command)
        {
            yield return new PaymentCaptured { Name = command.Name, CardNumber = command.CardNumber };
        }
    }
}