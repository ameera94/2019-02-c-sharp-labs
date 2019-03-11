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

namespace lab_117_Entity_tabs
{
    /// <summary>
    /// Interaction logic for WindowAddCustomer.xaml
    /// </summary>
    public partial class WindowAddCustomer : Window
    {

        static List<Customer> customers = new List<Customer>();

        public WindowAddCustomer()
        {
            InitializeComponent();

        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new NorthwindEntities())
            {

                Customer customerToCreate = new Customer
                {
                    CustomerID = CustID.Text,
                    ContactName = CustName.Text,
                    City = CityName.Text,
                    CompanyName = CompName.Text
                };

                db.Customers.Add(customerToCreate);
                db.SaveChanges();
            }
        }

    }
}
