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

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void text_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            

                string textToAdd = text.Text;


                if (!string.IsNullOrEmpty(textToAdd))
                {

                    list1.Items.Add(textToAdd);


                    text.Clear();
                }
                else
                {
                    MessageBox.Show("Kérlek írj be valamit a TextBox-ba!");
                }
        }
    }
}