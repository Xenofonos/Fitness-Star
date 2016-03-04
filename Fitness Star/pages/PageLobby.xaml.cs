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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class PageLobby : Page
    {
        public PageLobby()
        {
            InitializeComponent();
            BG.Source = new BitmapImage(new Uri(@"../Images/lobby.jpg", UriKind.Relative));
            Image2.Source = new BitmapImage(new Uri(@"../Images/ShaunT.png", UriKind.Relative));
        }
        PageTreadmill treadmill = new PageTreadmill();
        PagePool pool = new PagePool();
        PageCafeteria cafeteria = new PageCafeteria();
        windows.Window1 credit = new windows.Window1();
        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            this.NavigationService.Navigate(treadmill);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(pool);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(cafeteria);
        }

        bool lights = false;
        
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var imageDirPath = String.Format(@"../Images/");
            if (lights)
                if (tv)
                    BG.Source = new BitmapImage(new Uri(imageDirPath + "lobby.jpg", UriKind.Relative));
            else
                    BG.Source = new BitmapImage(new Uri(imageDirPath + "lobby3.jpg", UriKind.Relative));
            else if (lights==false)
                if (tv)
                    BG.Source = new BitmapImage(new Uri(imageDirPath + "lobby1.jpg", UriKind.Relative));
                else
                    BG.Source = new BitmapImage(new Uri(imageDirPath + "lobby4.jpg", UriKind.Relative));
            lights = !lights;
        }

        bool tv = true;

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var imageDirPath = String.Format(@"../Images/");
            if (tv)
                if (lights)
                    BG.Source = new BitmapImage(new Uri(imageDirPath + "lobby4.jpg", UriKind.Relative));
                else
                    BG.Source = new BitmapImage(new Uri(imageDirPath + "lobby3.jpg", UriKind.Relative));
            else if(tv==false)
                if (lights)
                    BG.Source = new BitmapImage(new Uri(imageDirPath + "lobby1.jpg", UriKind.Relative));
                else
                    BG.Source = new BitmapImage(new Uri(imageDirPath + "lobby.jpg", UriKind.Relative));
            tv = !tv;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            credit.Show();
            
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Lights.Visibility = System.Windows.Visibility.Visible;
            TV.Visibility = System.Windows.Visibility.Visible;
        }



    }
}
