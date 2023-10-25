using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.SecretSanta.Domain.Services.Interfaces
{
    public interface IHelloService
    {
        void SetName(string name);
        string SayHello();
    }
}
