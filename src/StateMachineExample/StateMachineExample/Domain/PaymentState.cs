using System;
using System.Collections.Generic;
using StateMachineExample.Messages;

namespace StateMachineExample.Domain
{
    abstract class PaymentState
    {
        private readonly Dictionary<Type, Func<IMessage, IEnumerable<IEvent>>> handlers = new Dictionary<Type, Func<IMessage, IEnumerable<IEvent>>>();

        protected void Register<T>(Func<T, IEnumerable<IEvent>> handler)
        {
            handlers.Add(typeof(T), msg => handler((T)msg));
        }

        public IEnumerable<IEvent> Handle(IMessage message)
        {
            Func<IMessage, IEnumerable<IEvent>> handler;

            if (handlers.TryGetValue(message.GetType(), out handler))
            {
                return handler(message);
            }

            Console.WriteLine($"No message handler found for {message}");
            return Array.Empty<IEvent>();
        }
    }
}