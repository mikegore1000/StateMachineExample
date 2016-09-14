namespace StateMachineExample.Messages
{
    class PaymentCaptured : IEvent
    {
        public string CardNumber { get; set; }
        public string Name { get; set; }
    }
}