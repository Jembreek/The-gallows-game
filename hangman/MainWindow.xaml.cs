using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.IO;

namespace hangman
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartClick(object sender, RoutedEventArgs e) // обработка клика "совместной игры"
        {
            if (questionBox.Text != string.Empty && answerBox.Text != string.Empty
                && questionBox.Text != "Ваш вопрос..." && answerBox.Text != "Ваш ответ...") {

                Window1 win = new Window1
                {
                    Owner = this,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    Width = Width,
                    Height = Height,
                };

                win.outQuestion_Label.Text = questionBox.Text;
                win.answer = answerBox.Text.ToUpper();

                for (int i = 0; i < answerBox.Text.Length; i++)
                    win.endBox.Text += "*";

                this.Hide();
                win.ShowDialog();
                this.Close();
            }
        }

        private void StartWithPC(object sender, RoutedEventArgs e) // обработка клика "соло" игры
        {
            Window1 win = new Window1
            {
                Owner = this,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Width = Width,
                Height = Height,
            };

            string[] answerFile = File.ReadAllLines("text_file\\answer.txt");
            string[] questionFile = File.ReadAllLines("text_file\\question.txt");

            var rand = new Random();
            int note_number = rand.Next(questionFile.Length);

            win.outQuestion_Label.Text = questionFile[note_number];
            win.answer = answerFile[note_number].ToUpper();

            for (int i = 0; i < win.answer.Length; i++)
                win.endBox.Text += "*";

            this.Hide();
            win.ShowDialog();
            this.Close();
        }

        private void InputCheck(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^а-яА-Я]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void MoveForm(object sender, MouseButtonEventArgs e)
        {
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
