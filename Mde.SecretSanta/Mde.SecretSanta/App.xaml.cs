using FreshMvvm;
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

            MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<MainViewModel>());
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
