using Mde.SecretSanta.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.SecretSanta.Domain.Services
{
    public class TimestampService : ITimeable
    {
        public string GetTime()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
}
