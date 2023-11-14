using FreshMvvm;
using Mde.SecretSanta.Domain.Services;
using Mde.SecretSanta.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Mde.SecretSanta.ViewModels
{
    public class MockLoginViewModel
    {

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private readonly IHelloService helloService;

        public MockLoginViewModel()
        {
            this.helloService = FreshIOC.Container.Resolve<IHelloService>();
        }

        public ICommand LoginCommand => new Command(() =>
        {
            helloService.SetName(UserName);
            //vibrate using xamarin.essentials <-> dependency service with own implementation
            try
            {
                Vibration.Vibrate();
            }
            catch (FeatureNotSupportedException ex)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
            Application.Current.MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<MainViewModel>());
        });
    }
}
