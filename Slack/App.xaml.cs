using Microsoft.Extensions.DependencyInjection;
using Slack.UI.WPF;
using Slack.UI.WPF.Core;
using Slack.UI.WPF.Services.Abstract;
using Slack.UI.WPF.ViewModels;
using Slack.UI.WPF.Views;
using System;
using System.Windows;

namespace Slack;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        Startup startup = new();
        var services = startup.ConfigureServices();

        INavigationService? navigationService = services.GetService<INavigationService>();
        navigationService?.Navigate(typeof(IChatWindowViewModel));
        var mainWindow = services.GetService<MainWindow>();
        mainWindow?.Show();
    }
}

