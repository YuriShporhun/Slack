using Slack.UI.WPF.ViewModels;
using System.Windows;

namespace Slack.UI.WPF.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow(IMainWindowViewModel mainWindowViewModel)
        {
            DataContext = mainWindowViewModel;
            InitializeComponent();
        }
    }
}
