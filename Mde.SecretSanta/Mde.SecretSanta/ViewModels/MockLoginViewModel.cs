using FreshMvvm;
using Mde.SecretSanta.Domain.Services;
using Mde.SecretSanta.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
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
            helloService = new HelloService();
        }

        public ICommand LoginCommand => new Command(() =>
        {
            helloService.SetName(UserName);
            Application.Current.MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<MainViewModel>());
        });
    }
}
