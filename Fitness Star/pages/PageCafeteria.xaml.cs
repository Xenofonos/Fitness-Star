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

namespace Fitness_Star.pages
{
    /// <summary>
    /// Interaction logic for PageCafeteria.xaml
    /// </summary>
    public partial class PageCafeteria : Page
    {
        public PageCafeteria()
        {
            InitializeComponent(); 
            Image1.Source = new BitmapImage(new Uri(@"../Images/cafeteria.jpg", UriKind.Relative));
            Image2.Source = new BitmapImage(new Uri(@"../Images/ShaunT.png", UriKind.Relative));
            
        }
        windows.OrderWindow order = new windows.OrderWindow();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            order.Show();
        }
    }
}
