using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfgyakorl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*MessageBox.Show(input.Text);
            input.Text = "";*/

            blokk.VerticalAlignment = VerticalAlignment.Top;
            blokk.HorizontalAlignment = HorizontalAlignment.Center;
            //blokk.Margin = new Thickness(10, 5, 10, 5);
            blokk.Background = Brushes.Azure;

            //checkhal.IsChecked = true;

            //kombi.Visibility = Visibility.Collapsed;

            //kombi.Items.Add("!");

            //kombi.Items.Add("semmi");
            //kombi.SelectedIndex = 0;

            kombi.Items.Add("Látható");
            kombi.Items.Add("Rejtett");
            kombi.Items.Add("Összenyomott");

            kombi.SelectedIndex = 0;
        }

        private void MutasdAzUzenetet(object sender, RoutedEventArgs e)
        {
            input.Text = "";
        }

        private void Kiiras(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(box.Text);
        }

        private void ValamiValtozott(object sender, TextChangedEventArgs e)
        {
            Random rnd = new Random();
            int szam = rnd.Next(1, 5);

            switch (szam)
            {
                case 1: input.Background = Brushes.Red; break;
                case 2: input.Background = Brushes.Blue; break;
                case 3: input.Background = Brushes.Yellow; break;
                case 4: input.Background = Brushes.Green; break;
            }

            // = new SolidColorBrush(Color.FromRGB((byte)rand.Next(0,256)(byte)rand.Next(0,256)(byte)rand.Next(0,256)))
        }

        private void alkalmaz(object sender, RoutedEventArgs e)
        {
            if (checkhal.IsChecked == false)
            {
                kombi.Visibility = Visibility.Visible;
            }
            else if (checkhal.IsChecked == true && kombi.SelectedValue.ToString() == "Rejtett")
            {
                kombi.Visibility = Visibility.Hidden;
            }
            else if (checkhal.IsChecked == true && kombi.SelectedValue.ToString() == "Összenyomott")
            {
                kombi.Visibility = Visibility.Collapsed;
            }
        }

        private void valt(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(kombi.SelectedValue.ToString());
            
            alkalmaz(null, null);
        }


    }
}