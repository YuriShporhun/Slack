using Microsoft.Extensions.DependencyInjection;
using Slack.UI.WPF.Core;
using System;

namespace Slack.UI.WPF.ViewModels
{
    public interface IMainWindowViewModel { }
    public class MainWindowViewModel : Bindable, IMainWindowViewModel
    {
        Bindable? CurrentViewModel;
        private readonly IServiceProvider _serviceProvider;
        public MainWindowViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            CurrentViewModel = _serviceProvider.GetService<IPeopleWindowViewModel>() as Bindable;
        }
    }
}
