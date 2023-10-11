using FreshMvvm;
using Mde.SecretSanta.Domain.Models;
using System;

namespace Mde.SecretSanta.ViewModels
{
    public class ParticipantsDetailsViewModel : FreshBasePageModel
    {
        private static int PageCount = 0;

		private string participantName;

		public string ParticipantName
		{
			get { return participantName; }
			set 
			{ 
				participantName = value;
				RaisePropertyChanged();
			}
		}

        public override void Init(object initData)
        {
            base.Init(initData);

			ParticipantName = ((Person)initData).FullName;
        }

        protected override void ViewIsDisappearing(object sender, EventArgs e)
        {
            base.ViewIsDisappearing(sender, e);
            CoreMethods.PopPageModel(++PageCount);
        }

    }
}
