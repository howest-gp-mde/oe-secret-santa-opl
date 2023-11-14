using Mde.SecretSanta.Domain.Services.Interfaces;
using Mde.SecretSanta.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly:Xamarin.Forms.Dependency(typeof(Mde.SecretSanta.UWP.Services.UwpInformerService))]
namespace Mde.SecretSanta.UWP.Services
{
    public class UwpInformerService : IInFormerService
    {
        public void InformUser()
        {
            throw new NotImplementedException();
        }
    }
}
