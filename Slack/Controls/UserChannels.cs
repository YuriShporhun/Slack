using System.Windows;
using System.Windows.Controls;

namespace Slack.UI.WPF.Controls
{
    public class UserChannels : Control
    {
        static UserChannels()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(UserChannels), new FrameworkPropertyMetadata(typeof(UserChannels)));
        }
    }
}
