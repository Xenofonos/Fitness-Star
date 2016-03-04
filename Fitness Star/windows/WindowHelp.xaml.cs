
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
using System.Windows.Shapes;

namespace Fitness_Star.windows
{
    /// <summary>
    /// Interaction logic for WindowHelp.xaml
    /// </summary>
    public partial class WindowHelp : Window
    {
        public WindowHelp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HelpFrame.Source = new Uri("../pages/LobbyHelp.xaml", UriKind.Relative);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HelpFrame.Source = new Uri("../pages/TreadmillHelp.xaml", UriKind.Relative);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            HelpFrame.Source = new Uri("../pages/CafeteriaHelp.xaml", UriKind.Relative);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            HelpFrame.Source = new Uri("../pages/PoolHelp.xaml", UriKind.Relative);
        }
    }
}