using System.Windows;
using System.Windows.Controls;

namespace Slack.UI.WPF.Controls;

public class DashBoard : Control
{
    static DashBoard()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(DashBoard), new FrameworkPropertyMetadata(typeof(DashBoard)));
    }
}