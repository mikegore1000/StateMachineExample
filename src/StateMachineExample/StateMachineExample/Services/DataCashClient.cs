using System;

namespace StateMachineExample.Services
{
    public class DataCashClient
    {
        public Guid Auth()
        {
            return Guid.NewGuid();
        }
    }
}