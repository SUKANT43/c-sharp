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
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ToDo.xaml
    /// </summary>
    public partial class ToDo : UserControl
    {
        List<BluePrint> list = new List<BluePrint>();
        public ToDo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (InputValue.Text == "")
            {
                return;
            }
            else
            {
                list.Add(new BluePrint(InputValue.Text,false));
                InputValue.Text = "";
            }
        }
    }

    public class BluePrint
    {
        string value;
        bool done;

        public BluePrint(string value, bool done)
        {
            this.value = value;
            this.done = done;
        }
    }
}
