﻿using FreshMvvm;
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

		public MainViewModel()
        {
			_secretSantaService = new InMemorySecretSantaService();
        }

		public ICommand AddParticipantCommand => new Command(AddParticipant);
		public ICommand NavigateToDetailsCommand => new Command<Person>(async (person) =>
		{
			await CoreMethods.PushPageModel<ParticipantsDetailsViewModel>(person);
		});

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            Participants = new ObservableCollection<Person>(_secretSantaService.GetParticipants());
        }

        public async override void ReverseInit(object returnedData)
        {
            base.ReverseInit(returnedData);
			int visitCount = (int)returnedData;
            await CoreMethods.DisplayAlert("You visited details ...", $"{visitCount} time(s)", "I know, right?!");
        }

        private void AddParticipant()
		{
            var participant = new Person() { FullName = Name };
            _secretSantaService.AddParticipant(participant);

			Participants = new ObservableCollection<Person>(_secretSantaService.GetParticipants());
        }
    }
}