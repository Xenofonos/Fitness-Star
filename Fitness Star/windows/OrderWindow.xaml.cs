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
    /// Interaction logic for OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        public OrderWindow()
        {
            InitializeComponent();
            t = 0;
        }

        public static double t;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string t1 = tex1.Text;
            double tt1 = Convert.ToDouble(t1);

            t = tt1 * 0.5 + t;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            string t2 = tex2.Text;
            double tt2 = Convert.ToDouble(t2);
            t = tt2 * 2.2 + t; 
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            string t4 = tex4.Text;
            double tt4 = Convert.ToDouble(t4);
            t = tt4 * 1.5 + t;
        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {
            string t3 = tex3.Text;
            double tt3 = Convert.ToDouble(t3);
            t = tt3 * 1.7 + t;
        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {
            string t5 = tex5.Text;
            double tt5 = Convert.ToDouble(t5);
            t = tt5 * 1.8 + t;
        }

        private void TextBox_TextChanged_5(object sender, TextChangedEventArgs e)
        {
            string t6 = tex6.Text;
            double tt6 = Convert.ToDouble(t6);
            t = tt6 * 1.3 + t;
            
        }


        protected override void OnPreviewTextInput(System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = !AreAllValidNumericChars(e.Text);
            base.OnPreviewTextInput(e);
        }

        private bool AreAllValidNumericChars(string str)
        {
            foreach (char c in str)
            {
                if (!Char.IsNumber(c)) return false;
            }

            return true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("your total is " + t+"euros");
        }


    }

}
