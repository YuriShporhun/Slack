using Slack.UI.WPF.Core;
using Slack.UI.WPF.Services.Abstract;
using System;

namespace Slack.UI.WPF.Services.Implementations
{
    public class NavigationService : INavigationService
    {

        private Bindable? currentViewModel;
        public Bindable? CurrentViewModel => currentViewModel;

        public event Action? OnViewModelChanged;

        private readonly IServiceProvider _serviceProvider;

        public NavigationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Navigate(Type viewModel)
        {
            var requestedViewModel = _serviceProvider.GetService(viewModel);
            if (requestedViewModel == null)
            {
                throw new InvalidOperationException(nameof(viewModel));
            }
            currentViewModel = (Bindable)requestedViewModel;
            OnViewModelChanged?.Invoke();
        }
    }
}
