using Mde.SecretSanta.Domain.Services.Interfaces;
using Mde.SecretSanta.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mde.SecretSanta.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MockLoginPage : ContentPage
    {
        public MockLoginPage()
        {
            InitializeComponent();
            BindingContext = new MockLoginViewModel();
        }
    }
}