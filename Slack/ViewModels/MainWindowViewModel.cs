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
        private Bindable? _currentViewModel;
        private readonly IServiceProvider _serviceProvider;

        public Bindable? CurrentViewModel 
        { 
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            CurrentViewModel = _serviceProvider.GetService<IChatWindowViewModel>() as Bindable;
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
