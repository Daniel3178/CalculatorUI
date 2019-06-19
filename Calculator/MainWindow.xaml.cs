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

namespace Calculator
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
        int first;
        int second;
        char operation;

    public MainWindow()
    {
      InitializeComponent();
    }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Result.Text += btn.DataContext.ToString();
            Display.Text += btn.DataContext.ToString();
            second = int.Parse(Display.Text);
        }

        private void Divide_Button(object sender, RoutedEventArgs e)
        {
            first = int.Parse(Result.Text);
            operation = '/';
            Result.Text += " ÷ ";
            Display.Clear();
        }

        private void Multiplay_Button(object sender, RoutedEventArgs e)
        {
            first = int.Parse(Display.Text);
            operation = '*';
            Result.Text += " X ";
            Display.Clear();
        }

        private void Minus_Button(object sender, RoutedEventArgs e)
        {
            first = int.Parse(Display.Text);
            operation = '-';
            Result.Text += " - ";
            Display.Clear();
        }

        private void Add_Button(object sender, RoutedEventArgs e)
        {
            first = int.Parse(Display.Text);
            operation = '+';
            Result.Text += " + ";
            Display.Clear();
        }

        private void Result_Button(object sender, RoutedEventArgs e)
        {
            second = int.Parse(Display.Text);
            int result = 0;
            int counter = 0;
            string temp = Result.Text;

            if(operation == '-')
            {
                result = first - second;
            }
            else if(operation == '+')
            {
                result = first + second;
            }
            else if(operation == '/')
            {
                result = first / second;
            }
            else if(operation == '*')
            {
                result = first * second;
            }
            if(Result.Text == " = 0")
            {
                Result.Clear();
                if(counter == 1)
                {
                    FormerData.Clear();
                    counter = 0;
                }
                counter++;
            }

            Result.Text += " = " + result.ToString();
            Display.Text = result.ToString();
        }

        private void Clear_Button(object sender, RoutedEventArgs e)
        {
            FormerData.Text = Result.Text;
            first = 0;
            second = 0;
            operation = ' ';
            Display.Clear();
            Result.Clear();
        }

    }
}
