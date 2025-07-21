using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class IncDec : UserControl
    {
        int count = 0;

        public IncDec()
        {
            InitializeComponent();
        }

        private void Increment(object sender, RoutedEventArgs e)
        {
            count++;
            CounterText.Text = count.ToString();
        }

        private void Decrement(object sender, RoutedEventArgs e)
        {
            if (count < 0)
            {
                CounterText.Text = "Number must be greater than or equal to zero";
                return;
            }
            count--;
            CounterText.Text = count.ToString();
        }
    }
}
