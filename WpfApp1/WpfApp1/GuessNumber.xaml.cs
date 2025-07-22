using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class GuessNumber : UserControl
    {
        int score = 0;
        Random random = new Random();

        public GuessNumber()
        {
            InitializeComponent();
        }

        private void Button_Predict(object sender, RoutedEventArgs e)
        {
            string input = inputNumber.Text.Trim();

            if (!int.TryParse(input, out int userNumber) || userNumber < 1 || userNumber > 5)
            {
                outputNumber.Text = "Enter a number between 1 and 5!";
                return;
            }

            int randomNumber = random.Next(1, 6);

            if (userNumber == randomNumber)
            {
                score++;
            }
            else
            {
                score--;
            }

            if (score >= 5)
            {
                outputNumber.Text = "🎉 You Won!";
                score = 0; 
            }
            else if (score <= -5)
            {
                outputNumber.Text = "❌ You Lose. Try another Game";
                score = 0; 
            }
            else
            {
                outputNumber.Text = $"Your Score: {score} (Random: {randomNumber})";
            }
        }
    }
}
