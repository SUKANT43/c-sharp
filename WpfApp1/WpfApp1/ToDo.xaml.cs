using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class ToDo : UserControl
    {
        List<BluePrint> list = new List<BluePrint>();

        public ToDo()
        {
            InitializeComponent();
            OutputValue.ItemsSource = list; // Bind list to ListBox
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputValue.Text))
                return;

            list.Add(new BluePrint(InputValue.Text, false)); // Add new task
            InputValue.Clear(); // Clear input
            OutputValue.Items.Refresh(); // Refresh UI manually
        }
    }

    public class BluePrint
    {
        public string Value { get; set; }
        public bool Done { get; set; }

        public BluePrint(string value, bool done)
        {
            Value = value;
            Done = done;
        }
    }
}
