using FreshMvvm;
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
