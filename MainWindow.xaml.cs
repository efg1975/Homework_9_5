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

namespace Homework_9_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        static string ReverseWords(string text)
        {
            string[] words = SplitText(text);
            string sortText = SortWords(words);
            return sortText;
        }

        static string SortWords(string[] text)
        {
            Array.Reverse(text);
            string text1 = string.Join(" ", text);
            return text1;
        }
        public static string[] SplitText(string text)
        {
            string[] words = text.Split(' ');
            return words;
        }

        private void Words_Click(object sender, RoutedEventArgs e)
        {
            ListWords.Items.Clear();
            foreach (var item in SplitText(UserStringWords.Text))
            {
                ListWords.Items.Add(item);
            }
        }

        private void Reverse_Click(object sender, RoutedEventArgs e)
        {
            ReverseString.Content = ReverseWords(UserStringString.Text);
        }
    }
}

    

