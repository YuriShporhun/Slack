using Slack.UI.WPF.Core;
using Slack.UI.WPF.Services.Abstract;

namespace Slack.UI.WPF.Commands
{
    public class NavigateCommand<TViewModel> : CommandBase where  TViewModel : Bindable
    {
        private readonly INavigationService _navigationService;

        public NavigateCommand(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            _navigationService.Navigate(typeof(TViewModel));
        }
    }
}
