using System;
using StateMachineExample.Messages;

namespace StateMachineExample.Domain
{
    class PaymentAggregate
    {
        private PaymentState state = new NewState();

        public string CurrentState => state.GetType().Name;

        public void Handle(IMessage message)
        {
            var events = state.Handle(message);

            foreach (var e in events)
            {
                Apply((dynamic) e);
            }
        }

        private void Apply(PaymentCaptured e)
        {
            Console.WriteLine($"Applying {e}");

            state = new CapturedState();
        }

        private void Apply(AcceptRequested e)
        {
            Console.WriteLine($"Applying {e}");
        }

        private void Apply(PaymentAccepted e)
        {
            Console.WriteLine($"Applying {e}");

            state = new AcceptedState();
        }
    }
}