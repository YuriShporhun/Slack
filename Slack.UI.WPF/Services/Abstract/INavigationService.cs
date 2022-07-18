using Slack.UI.WPF.Core;
using System;

namespace Slack.UI.WPF.Services.Abstract;

public interface INavigationService
{
    public Bindable? CurrentViewModel { get; }

    public event Action? OnViewModelChanged;
    public void Navigate(Type viewModel);
}