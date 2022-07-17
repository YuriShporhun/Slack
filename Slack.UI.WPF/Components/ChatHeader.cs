using System.Windows;
using System.Windows.Controls;

namespace Slack.UI.WPF.Controls;

public class ChatHeader : Control
{
    static ChatHeader()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(ChatHeader), new FrameworkPropertyMetadata(typeof(ChatHeader)));
    }
}

