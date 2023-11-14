using FreshMvvm;
using Mde.SecretSanta.Domain.Models;
using Mde.SecretSanta.Domain.Services;
using Mde.SecretSanta.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Mde.SecretSanta.ViewModels
{
    public class MainViewModel : FreshBasePageModel
    {
		private readonly ISecretSantaService _secretSantaService;
		private readonly IHelloService _helloService;
		private readonly IInFormerService _informerService;
		private string name;

		public string Name
		{
			get { return name; }
			set 
			{ 
				name = value;
				RaisePropertyChanged(nameof(Name));
			}
		}

		private string helloMessage;

		public string HelloMessage
		{
			get { return helloMessage; }
			set 
			{ 
				helloMessage = value;
				RaisePropertyChanged();
			}
		}


		private ObservableCollection<Person> participants;

		public ObservableCollection<Person> Participants
        {
			get { return participants; }
			set 
			{ 
				participants = value;
				RaisePropertyChanged(nameof(Participants));
			}
		}

		public MainViewModel(
			ISecretSantaService secretSantaService, 
			IHelloService helloService,
			IInFormerService inFormerService)
        {
			_secretSantaService = secretSantaService;
			_helloService = helloService;
			_informerService = inFormerService;
            HelloMessage = _helloService.SayHello();
        }

		public ICommand AddParticipantCommand => new Command(AddParticipant);
		public ICommand NavigateToDetailsCommand => new Command<Person>(async (person) =>
		{
			await CoreMethods.PushPageModel<ParticipantsDetailsViewModel>(person);
		});

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
			RefreshParticipants();
        }

        public async override void ReverseInit(object returnedData)
        {
            base.ReverseInit(returnedData);
			int visitCount = (int)returnedData;
            await CoreMethods.DisplayAlert("You visited details ...", $"{visitCount} time(s)", "I know, right?!");
        }

        private async void AddParticipant()
		{
			if (!string.IsNullOrEmpty(Name)) 
			{
				var participant = new Person() { FullName = Name };
				_secretSantaService.AddParticipant(participant);
                _informerService.InformUser();
                RefreshParticipants();
				
				Name = "";
			}

			else
			{
                await CoreMethods.DisplayAlert("Yo ho ho!", $"Provide the name of a new person!", "Ok");
            }

        }

		private void RefreshParticipants()
		{
            Participants = new ObservableCollection<Person>(_secretSantaService.GetParticipants());
        }
    }
}
