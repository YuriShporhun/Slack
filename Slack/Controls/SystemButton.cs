using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Slack.UI.WPF.Controls
{
    public enum ButtonTypes
    {
        CloseButton,
        MinimizeButton,
        MaximizeButton
    }

    public class SystemButton : Control
    {
        public ICommand OnClick
        {
            get { return (ICommand)GetValue(ClickProperty); }
            set { SetValue(ClickProperty, value); }
        }

        public static readonly DependencyProperty ClickProperty =
            DependencyProperty.Register("OnClick", typeof(ICommand), typeof(SystemButton), new PropertyMetadata(null));

        public ButtonTypes ButtonType
        {
            get { return (ButtonTypes)GetValue(ButtonTypeProperty); }
            set { SetValue(ButtonTypeProperty, value); }
        }

        public static readonly DependencyProperty ButtonTypeProperty =
            DependencyProperty.Register("ButtonType", typeof(ButtonTypes), typeof(SystemButton), new PropertyMetadata(default(ButtonTypes)));

        static SystemButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SystemButton), new FrameworkPropertyMetadata(typeof(SystemButton)));
        }
    }
}
