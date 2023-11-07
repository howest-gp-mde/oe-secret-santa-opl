using Mde.SecretSanta.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.SecretSanta.Domain.Services
{
    public class TimedHelloService : IHelloService
    {
        private readonly ITimeable timeable;
        public TimedHelloService(ITimeable timeable)
        {
            this.timeable = timeable;
        }
        public string SayHello()
        {
            return $"Hello, it is {timeable.GetTime()}";
        }

        public void SetName(string name)
        {
            return;
        }
    }
}
