using Mde.SecretSanta.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mde.SecretSanta.Domain.Services.Interfaces
{
    public interface ISecretSantaService
    {
        List<Person> GetParticipants();
        void AddParticipant(Person person);

    }
}
