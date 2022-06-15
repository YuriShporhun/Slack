using Microsoft.Extensions.DependencyInjection;
using Slack.UI.WPF.Core;
using System;
using System.Windows;
using System.Windows.Input;

namespace Slack.UI.WPF.ViewModels
{
    public interface IMainWindowViewModel { }
    public class MainWindowViewModel : Bindable, IMainWindowViewModel
    {
        public Bindable? CurrentViewModel { get; set; }

        private readonly IServiceProvider _serviceProvider;
        public MainWindowViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            CurrentViewModel = _serviceProvider.GetService<IPeopleWindowViewModel>() as Bindable;
            InitCommands();
        }

        public ICommand? CloseWindowCommand { get; set; }

        private void InitCommands()
        {
            CloseWindowCommand = new RelayCommand(CloseWindowCommandExecute, CloseWindowCommandCanExecute); 
        }

        private void CloseWindowCommandExecute(object obj)
        {
            Application.Current.MainWindow.Close();
        }

        private bool CloseWindowCommandCanExecute(object obj)
        {
            return true;
        }
    }
}
