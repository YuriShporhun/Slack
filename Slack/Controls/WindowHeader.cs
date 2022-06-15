using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Slack.UI.WPF.Controls
{
    public class WindowHeader : Control
    {
        public ICommand CloseCommand
        {
            get { return (ICommand)GetValue(CloseCommandProperty); }
            set { SetValue(CloseCommandProperty, value); }
        }

        public static readonly DependencyProperty CloseCommandProperty =
            DependencyProperty.Register("CloseCommand", typeof(ICommand), typeof(WindowHeader), new PropertyMetadata(null));

        static WindowHeader()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowHeader), new FrameworkPropertyMetadata(typeof(WindowHeader)));
        }
    }
}
