using Mde.SecretSanta.Domain.Services.Interfaces;
using Mde.SecretSanta.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

[assembly:Xamarin.Forms.Dependency(typeof(Mde.SecretSanta.UWP.Services.UwpInformerService))]
namespace Mde.SecretSanta.UWP.Services
{
    public class UwpInformerService : IInFormerService
    {
        public async void InformUser()
        {
            var element = new MediaElement();
            var folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync("Sounds");
            var file = await folder.GetFileAsync("bell.wav");
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            element.SetSource(stream, "");
            element.Play();
        }
    }
}
