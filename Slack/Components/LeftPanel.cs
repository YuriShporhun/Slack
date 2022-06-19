using System.Windows;
using System.Windows.Controls.Primitives;

namespace Slack.UI.WPF.Controls;

public class LeftPanel : Selector
{
    static LeftPanel()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(LeftPanel), new FrameworkPropertyMetadata(typeof(LeftPanel)));
    }
}

