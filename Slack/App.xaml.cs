using Microsoft.Extensions.DependencyInjection;
using Slack.UI.WPF;
using Slack.UI.WPF.Views;
using System.Windows;

namespace Slack;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        Startup startup = new();
        var services = startup.ConfigureServices();
        var mainWindow = services.GetService<MainWindow>();
        mainWindow?.Show();
    }
}

