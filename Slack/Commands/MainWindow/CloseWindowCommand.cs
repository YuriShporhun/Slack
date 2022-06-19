using Slack.UI.WPF.Core;
using System.Windows;

namespace Slack.UI.WPF.Commands.MainWindow
{
    public class CloseWindowCommand : CommandBase
    {
        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            Application.Current.MainWindow.Close();
        }
    }
}
