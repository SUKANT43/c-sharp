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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 0;

        public MainWindow()
        {
            InitializeComponent();

            /* myText.Text = "hello from run time";
             myText.Foreground =Brushes.Red;
             myText.Background = Brushes.Yellow;

             TextBlock run= new TextBlock();
             run.Inlines.Add(new Run("Hello I am from Object")
             {
                 Foreground = Brushes.White
             });

             run.Inlines.Add(new Run(" Hey I am from new Object but same class")
             {
                 Foreground = Brushes.Yellow,
                 Background = Brushes.Red
             });
             MyStackPanel.Children.Add(run);

         }

         private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
         {
             System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
         }

         private void IncDec_Loaded(object sender, RoutedEventArgs e)
         {

         }*/
        }
    }
}