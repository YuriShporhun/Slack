using System.Windows;
using System.Windows.Controls;

namespace Slack.UI.WPF.Controls
{
    public class WindowHeader : Control
    {
        static WindowHeader()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WindowHeader), new FrameworkPropertyMetadata(typeof(WindowHeader)));
        }
    }
}
