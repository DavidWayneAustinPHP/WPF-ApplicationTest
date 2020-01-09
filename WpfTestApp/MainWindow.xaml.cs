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

namespace WpfTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>();

        public MainWindow()
        {
            InitializeComponent();

            people.Add(new Person { FirstName = "John", LastName = "Smith", Age = "20", Message = "None" });
            people.Add(new Person { FirstName = "Jo", LastName = "Smith", Age = "20", Message = "None" });
            people.Add(new Person { FirstName = "Jeff", LastName = "Smith", Age = "20", Message = "None" });

            myComboBox.ItemsSource = people;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Enterred data {firstNameText.Text}");
            people.Add(new Person { FirstName = $"{firstNameText.Text}", LastName = $"{lastNameText.Text}", Age = $"{ageText.Text}", Message = $"{messageText.Text}" });

        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Message { get; set; }
    }
}
