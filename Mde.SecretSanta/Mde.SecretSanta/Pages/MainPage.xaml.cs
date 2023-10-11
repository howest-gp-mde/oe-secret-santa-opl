using Mde.SecretSanta.Domain.Models;
using Mde.SecretSanta.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mde.SecretSanta.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var viewmodel = (MainViewModel)BindingContext;
            var participant = (Person)e.Item;
            viewmodel.NavigateToDetailsCommand.Execute(participant);
        }
    }
}
