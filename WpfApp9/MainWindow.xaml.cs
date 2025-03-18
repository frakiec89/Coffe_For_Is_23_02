using System.Windows;

// track
namespace WpfApp9
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            buttonGo.Click += ButtonGo_Click;
            textBoxName.Focus();
            FontSize = 20;
            Title = "Привет WPF";
        }

        private void ButtonGo_Click(object sender, RoutedEventArgs e)
        {
            string name  = textBoxName.Text;
            
            if(name=="")
            {
                MessageBox.Show("Введите имя!");
                textBoxName.Focus();
                return;
            }
            

            double x = Convert.ToDouble(textBoxName.Text);


            string message = $"Привет {name}";
            labelInfo.Content = message;
        }
    }
}