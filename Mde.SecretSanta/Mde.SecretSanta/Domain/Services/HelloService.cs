using Mde.SecretSanta.Domain.Models;
using Mde.SecretSanta.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.SecretSanta.Domain.Services
{
    public class HelloService : IHelloService
    {
        //not static anymore!
        private string username;
        public string SayHello()
        {
            return $"Hello, {username}";
        }

        public void SetName(string name)
        {
            username = name;
        }
    }
}
