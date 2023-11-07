using FreshMvvm;
using Mde.SecretSanta.Domain.Services;
using Mde.SecretSanta.Domain.Services.Interfaces;
using Mde.SecretSanta.Pages;
using Mde.SecretSanta.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mde.SecretSanta
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            FreshIOC.Container.Register<ISecretSantaService, InMemorySecretSantaService>();
            FreshIOC.Container.Register<IHelloService, TimedHelloService>();
            //FreshIOC.Container.Register<ITimeable, TimestampService>();
            FreshIOC.Container.Register<IHelloService, HelloService>().AsSingleton(); 

            MainPage = new MockLoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
