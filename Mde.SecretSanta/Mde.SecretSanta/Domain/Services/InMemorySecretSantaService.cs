using Mde.SecretSanta.Domain.Models;
using Mde.SecretSanta.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.SecretSanta.Domain.Services
{
    public class InMemorySecretSantaService : ISecretSantaService
    {
        private readonly List<Person> participants = new List<Person>
        {
            new Person { FullName = "Maxim Lesy" },
            new Person { FullName = "Siegfried Derdeyn" }
        };
        public void AddParticipant(Person person)
        {
            participants.Add(person);
        }

        public List<Person> GetParticipants()
        {
            return participants;
        }
    }
}
