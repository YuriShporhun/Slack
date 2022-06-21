using System.Windows;
using System.Windows.Controls;

namespace Slack.UI.WPF.Controls
{
    public class UserPanel : Control
    {
        static UserPanel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(UserPanel), new FrameworkPropertyMetadata(typeof(UserPanel)));
        }
    }
}
