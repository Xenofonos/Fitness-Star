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
using System.Windows.Media.Effects;
using System.Windows.Threading;


namespace Fitness_Star.pages
{
    /// <summary>
    /// Interaction logic for PagePool.xaml
    /// </summary>
    public partial class PagePool : Page
    {
        public PagePool()
        {
            InitializeComponent();
            Image1.Source = new BitmapImage(new Uri(@"../Images/pool.jpg", UriKind.Relative));
        }

        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;
            BlurEffect myBlurEffect = new BlurEffect();
            myBlurEffect.KernelType = KernelType.Gaussian;
            Image1.Effect = myBlurEffect;
            myBlurEffect.Radius = value;
            Temp.Text = (18+value*4) + "°C";
        }
        
        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var imageDirPath = String.Format(@"../Images/");
            var slider2 = sender as Slider;
            double value2 = slider2.Value;
            if (value2 == 0)
                Image1.Source = new BitmapImage(new Uri(imageDirPath + "pool.jpg", UriKind.Relative));
            else if (value2 == 1)
                Image1.Source = new BitmapImage(new Uri(imageDirPath + "pool2.jpg", UriKind.Relative));
            else if (value2 == 2)
                Image1.Source = new BitmapImage(new Uri(imageDirPath + "pool3.jpg", UriKind.Relative));
            else if (value2 == 3)
                Image1.Source = new BitmapImage(new Uri(imageDirPath + "pool4.jpg", UriKind.Relative));
            else if (value2 == 4)
                Image1.Source = new BitmapImage(new Uri(imageDirPath + "pool5.jpg", UriKind.Relative));
        }
        public bool p = false;
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

            if (p)
                MessageBox.Show("There are people in the pool!");
            p = !p; 
        }

        private void restart()
        {
            Random r = new Random();
            int nu = r.Next(0, 20);
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, nu);
            dispatcherTimer.Start();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (p)
                MessageBox.Show("There are people in the pool!");
            p = !p;
            restart();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
        }

    }
}
