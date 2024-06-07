using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace hangman
{
    public partial class Window1 : Window
    {
        public string answer;
        private bool isDragging = false;
        private int index = 0;
        public Window1()
        {
            InitializeComponent();
        }

        private void LetterClick(object sender, RoutedEventArgs e) // обработка выбора букв
        {
            var CLICK = (Button)sender;
            var letter = Convert.ToChar(CLICK.Content);

            CLICK.IsEnabled = false;
            CLICK.Opacity = 0.5;

            StringBuilder sb = new StringBuilder(endBox.Text);
            bool found = false;
            for (int i = 0; i < answer.Length; i++)
            {
                if (letter == answer[i])
                {
                    sb[i] = letter;
                    found = true;
                }
            }
            endBox.Text = sb.ToString();

            if (found)
            {
                CLICK.Background = new SolidColorBrush(Color.FromRgb(193, 240, 219));
            }
            else 
            {
                index++;
                CLICK.Background = new SolidColorBrush(Color.FromRgb(240, 193, 204));
                hangmanImage.Source = new BitmapImage(new Uri($"hangman_animate\\{index}.png", UriKind.RelativeOrAbsolute));
                bloodImage.Source = new BitmapImage(new Uri($"background_animate\\{index}.png", UriKind.RelativeOrAbsolute));
            }

            WinnerCheck();
        }

        private void WinnerCheck() {  // check на победу / поражение user'a
    
            if (index >= 6)
            {
                endMessage.Content = "Вы повешены! Может потом повезет...";
                LastScene();
            }

            if (!endBox.Text.Contains("*"))
            {
                endMessage.Content = "Вы живы! Попробуем еще раз?";
                LastScene();
            }

        }
        
        private async void LastScene() // обработка финальной сцены
        {
            isDragging = true;
            List<Label> labels = new List<Label>() { endLabel, endLabel2, endMessage, endTimer };
            foreach (var S in labels)
                S.Visibility = Visibility.Visible;

            for (int i = 3; i > 0; i--)
            {
                endTimer.Content = i.ToString();
                await Task.Delay(1000);
            }
            BackOnStart();
            isDragging = false;
        }

        private void BackOnStart() {
            var win = new MainWindow() {
                Owner = this,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Width = Width,
                Height = Height,
            };

            index = 0;
            this.Hide();
            win.ShowDialog();
            this.Close();
        }

        private void MoveForm(object sender, MouseButtonEventArgs e)
        {
            if (!isDragging)
                this.DragMove();
        }

        private void MinimizeForm(object sender, MouseButtonEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void CloseForm(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

    }
}
