using Microsoft.Extensions.DependencyInjection;
using Slack.UI.WPF.ViewModels;
using Slack.UI.WPF.Views;
using System;

namespace Slack.UI.WPF;

public class Startup
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IServiceCollection _serviceCollection;

    public Startup()
    {
        _serviceCollection = new ServiceCollection();
        _ = ConfigureServices();
        _serviceProvider = _serviceCollection.BuildServiceProvider();
    }

    public IServiceProvider ConfigureServices()
    {
        _serviceCollection.AddTransient<IMainWindowViewModel, MainWindowViewModel>();
        _serviceCollection.AddTransient<IChatWindowViewModel, ChatWindowViewModel>();
        _serviceCollection.AddSingleton<MainWindow>();
        return _serviceProvider;
    }
}

