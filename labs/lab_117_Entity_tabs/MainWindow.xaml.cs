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

namespace lab_117_Entity_tabs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Customer> customers = new List<Customer>();
        Customer customerSelect;
        List<Order> orderList = new List<Order>();
        Order orderSelect;
        List<Order_Detail> productList = new List<Order_Detail>();
        Order_Detail productSelect;
        List<Product> productNames = new List<Product>();


        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                ListBox01.ItemsSource = customers;
                ListBox01.DisplayMemberPath = "ContactName";
            }                 
        }

        private void ListBox01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customerSelect = (Customer)ListBox01.SelectedItem;
            using (var db = new NorthwindEntities())
            {               
                orderList = db.Orders.Where(o => o.CustomerID == customerSelect.CustomerID).ToList<Order>();
                ListBox02.ItemsSource = orderList;
                ListBox02.DisplayMemberPath = "OrderID";
            }
        }

        private void ListBox02_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            orderSelect = (Order)ListBox02.SelectedItem;
            using (var db = new NorthwindEntities())
            {
                productList = db.Order_Details.Where(p => p.OrderID == orderSelect.OrderID).ToList<Order_Detail>();
                ListBox03.ItemsSource = productList;
                ListBox03.DisplayMemberPath = "ProductID";
            }
        }

        private void ListBox03_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            productSelect = (Order_Detail)ListBox03.SelectedItem;
            using (var db = new NorthwindEntities())
            {
                productNames = db.Products.Where(pn => pn.ProductID ==  productSelect.ProductID).ToList<Product>();
                ListBox04.ItemsSource = productNames;
                ListBox04.DisplayMemberPath = "ProductName";
            }
        }

        private void NewWindow_Click(object sender, RoutedEventArgs e)
        {
            Window w2 = new WindowAddCustomer();
            w2.Visibility = Visibility.Visible;
        }

        
    }
}
