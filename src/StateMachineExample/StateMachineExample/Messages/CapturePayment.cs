namespace StateMachineExample.Messages
{
    class CapturePayment : IMessage
    {
        public string CardNumber { get; set; }
        public string Name { get; set; }
    }
}