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
// track
namespace WpfApp9
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            textBoxA.Focus();
            buttonMath.Click += ButtonMath_Click;
        }


        private void ButtonMath_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxA.Text == "")
            {
                MessageBox.Show("Введите А");
                textBoxA.Focus();     // Установить  фокус 
                labelOtvet.Content = $"Ответ:"; // сбросить ответ  - если был  
                return;
            }

            if (textBoxB.Text == "")
            {
                MessageBox.Show("Введите B");
                textBoxB.Focus();
                labelOtvet.Content = $"Ответ:";
                return;
            }


            double a = 0;
            double b = 0;

            try
            {
                a = Convert.ToDouble(textBoxA.Text);
            }
            catch (Exception ex)
            {
                labelOtvet.Content = $"Ответ:";
                MessageBox.Show(ex.Message);
                textBoxA.Clear();              // очистить лабуду
                textBoxA.Focus();
                labelOtvet.Content = $"Ответ:";
                return;
            }


            try
            {
                b = Convert.ToDouble(textBoxB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBoxB.Clear();
                textBoxB.Focus();
                labelOtvet.Content = $"Ответ:";
                return;
            }

            labelOtvet.Content = $"Ответ: {a + b}";

        }

    }
}
