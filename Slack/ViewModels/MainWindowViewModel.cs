using Slack.UI.WPF.Commands.MainWindow;
using Slack.UI.WPF.Core;
using Slack.UI.WPF.Services.Abstract;
using System;
using System.Windows.Input;

namespace Slack.UI.WPF.ViewModels
{
    public interface IMainWindowViewModel { }
    public class MainWindowViewModel : Bindable, IMainWindowViewModel
    {
        private readonly INavigationService _navigationService;
        public Bindable? CurrentViewModel => _navigationService.CurrentViewModel;

        public MainWindowViewModel(INavigationService navigationService)
        {
            CloseWindowCommand = new CloseWindowCommand();
            _navigationService = navigationService;
            _navigationService.OnViewModelChanged += OnViewModelChanged;
        }

        private void OnViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        public ICommand CloseWindowCommand { get; set; }
    }
}
