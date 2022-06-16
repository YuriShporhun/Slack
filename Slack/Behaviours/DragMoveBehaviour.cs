using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Input;

namespace Slack.UI.WPF.Behaviours;

public class DragMoveBehavior : Behavior<Window>
{
    protected override void OnAttached()
    {
        AssociatedObject.MouseMove += AssociatedObject_MouseMove;
    }

    protected override void OnDetaching()
    {
        AssociatedObject.MouseMove -= AssociatedObject_MouseMove;
    }

    private void AssociatedObject_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed && sender is Window window)
        {
            window.DragMove();
        }
    }
}
