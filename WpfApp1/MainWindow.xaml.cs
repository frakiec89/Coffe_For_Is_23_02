using System.Windows;
// track
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double americanoPrice = 80; // за  0,2
        private double capuchinoPrice = 100; //за  0,2
        private double latePrice = 90; // за  0,2

        public MainWindow()
        {
            InitializeComponent();
            buttonCheck.Click += ButtonCheck_Click;
            rb05.IsChecked = true;
            rbAmericano.IsChecked = true;
        }

        private void ButtonCheck_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = GetName();
                string volumeMessage = "";
                double price = GetPrice(name);
                double volume = GetVolume(out volumeMessage);

                double itog = price * volume;

                string extraMessage = GetExtraMessage();

                MessageBox.Show("Ваш заказ: \n" +
                    $"{name} ({volumeMessage}) \n" +
                    $"{extraMessage} \n" +
                    $"Цена {itog} руб.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetExtraMessage()
        {
            string sahar = "";
            string koriza = "";

            if (checkBoxSahar.IsChecked == true)
                sahar = "добавить сахар";
            else
                sahar = "без сахара";

            if (checkBoxKariza.IsChecked == true)
                koriza = "добавить корицу";
            else
                koriza = "без корицы";

            return $"(дополнительно: {sahar}, {koriza})";
        }

        private double GetVolume(out  string volumeMessage)
        {
            if (rb02.IsChecked == true)
            {
                volumeMessage = "0.2 л.";
                return 1; // в 1 раза дороде  чем  0,2 - тоесть  та же  цена 
            }
               
            if (rb03.IsChecked == true)
            {
                volumeMessage = "0.3 л.";
                return 1.5; // в 1,5 раза дороде  чем  0,2
            }

            if (rb05.IsChecked == true)
            {
                volumeMessage = "0.5 л.";
                return 2; // в 2 раза дороде  чем  0,2
            }

            throw new NotImplementedException("no");
        }

        private double GetPrice(string name)
        {
            switch (name)
            {
                case "Американо": return americanoPrice;
                case "Капучино": return capuchinoPrice;
                case "Латте": return latePrice;
                default:
                    throw new NotImplementedException("no");
            }
        }

        private string GetName()
        {
            if (rbAmericano.IsChecked == true)
                return "Американо";

            if (rbCapuchiino.IsChecked == true)
                return "Капучино";

            if (rbLatte.IsChecked == true)
                return "Латте";

            throw new NotImplementedException("no");
        }
    }
}