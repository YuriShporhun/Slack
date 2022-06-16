using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Slack.UI.WPF.Controls
{   
    public class DashBoard : Control
    {
        static DashBoard()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DashBoard), new FrameworkPropertyMetadata(typeof(DashBoard)));
        }
    }
}
