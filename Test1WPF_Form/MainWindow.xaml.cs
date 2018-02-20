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

namespace Test1WPF_Form
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class ViewModel
        {
            public List<Customer> Data { get; set; }
            public ViewModel()
            {
                Data = Customer.GetCustomers();
            }
        }

        public class Customer
        {
            public string Name { get; set; }
            public string City { get; set; }
            public bool IsOccupied { get; set; }
            public int Visits { get; set; }
            public DateTime? Birthday { get; set; }

            public static List<Customer> GetCustomers()
            {
                List<Customer> people = new List<Customer>();
                people.Add(new Customer() { Name = "Gregory S. Price", City = "Huntington", Visits = 4, Birthday = new DateTime(1980, 1, 1) });
                people.Add(new Customer() { Name = "Irma R. Marshall", City = "Hong Kong", Visits = 2, Birthday = new DateTime(1966, 4, 15) });
                people.Add(new Customer() { Name = "John C. Powell", City = "Luogosano", Visits = 6, Birthday = new DateTime(1982, 3, 11) });
                people.Add(new Customer() { Name = "Christian P. Laclair", City = "Clifton", Visits = 11, Birthday = new DateTime(1977, 12, 5) });
                people.Add(new Customer() { Name = "Karen J. Kelly", City = "Madrid", Visits = 8, Birthday = new DateTime(1956, 9, 5) });
                return people;
            }
        }
    }
}
