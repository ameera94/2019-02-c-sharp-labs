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

namespace lab_123_northwind_is_back
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Category> categories = new List<Category>();
        List<Product> products = new List<Product>();        
        Category categorySelect;
        Product productSelect;
        List<string> productDetails = new List<string>();
        List<Product> basket = new List<Product>();
        List<decimal?> total = new List<decimal?>();

        public MainWindow()
        {
            
            InitializeComponent();
            
            using (var db = new NorthwindEntities())
            {
                categories = db.Categories.ToList();
                ListBox01.ItemsSource = categories;
                ListBox01.DisplayMemberPath = "CategoryName";

                products = db.Products.OrderBy(p => p.ProductName).ToList();
 
            }
            AddToBasket.IsEnabled = false;
            RemoveFromBasket.IsEnabled = false; 
        }

        private void ListBox01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            categorySelect = (Category)ListBox01.SelectedItem;
            using (var db = new NorthwindEntities())
            {
                products = db.Products.Where(p => p.CategoryID == categorySelect.CategoryID).OrderBy(p => p.ProductName).ToList();
                ListBox02.ItemsSource = null;
                ListBox02.Items.Clear();
                ListBox02.ItemsSource = products;
                ListBox02.DisplayMemberPath = "ProductName";

            }
        }

        private void ListBox02_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            productSelect = (Product)ListBox02.SelectedItem;
            using (var db = new NorthwindEntities())
            {
                if (productSelect != null)
                {
                    var supplierName = db.Suppliers.Where(s => s.SupplierID == productSelect.SupplierID).Select(s => s.CompanyName).FirstOrDefault();
                    productDetails.Clear();
                    productDetails.Add($"Product ID: { productSelect.ProductID.ToString()}");
                    productDetails.Add($"Product Name: { productSelect.ProductName}");
                    productDetails.Add($"Price: £{ productSelect.UnitPrice.ToString()}");
                    productDetails.Add($"Stock: { productSelect.UnitsInStock.ToString()}");
                    productDetails.Add($"Supplier: { supplierName}");

                }
                ListBox04.ItemsSource = null;
                ListBox04.Items.Clear();
                ListBox04.ItemsSource = productDetails;
                AddToBasket.IsEnabled = true;
            }
        }

        private void AddToBasket_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new NorthwindEntities())
            {
                productSelect = (Product)ListBox02.SelectedItem;
                if (productSelect.UnitsInStock > 0)
                {
                    basket.Add(productSelect);
                    ListBox03.ItemsSource = basket;
                    ListBox03.DisplayMemberPath = "ProductName";
                    total.Add(productSelect.UnitPrice);
                    decimal? totalPrice = total.Sum();
                    TotalPrice.Content = $"Total: £{totalPrice}";
                    productSelect.UnitsInStock--;
                }
               
                else
                {
                    MessageBox.Show("This product is out of stock!");
                }

                if (basket.Count > 0)
                {
                    RemoveFromBasket.IsEnabled = true;
                }
            }
        }

        private void RemoveFromBasket_Click(object sender, RoutedEventArgs e)
        {
            productSelect = (Product)ListBox03.SelectedItem;
            basket.Remove(productSelect);
            total.Remove(productSelect.UnitPrice);
            decimal? totalPrice = total.Sum();
            TotalPrice.Content = $"Total: £{totalPrice}";
            productSelect.UnitsInStock++;
            ListBox03.ItemsSource = null;
            ListBox03.ItemsSource = basket;
            if (basket.Count == 0) {
                MessageBox.Show("Basket is empty!");
            }
        }

        private void ListBox03_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            productSelect = (Product)ListBox03.SelectedItem;
            using (var db = new NorthwindEntities())
            {
                if (productSelect != null)
                {
                    var supplierName = db.Suppliers.Where(s => s.SupplierID == productSelect.SupplierID).Select(s => s.CompanyName).FirstOrDefault();
                    productDetails.Clear();
                    productDetails.Add($"Product ID: { productSelect.ProductID.ToString()}");
                    productDetails.Add($"Product Name: { productSelect.ProductName}");
                    productDetails.Add($"Price: £{ productSelect.UnitPrice.ToString()}");
                    productDetails.Add($"Stock: { productSelect.UnitsInStock.ToString()}");
                    productDetails.Add($"Supplier: { supplierName}");

                }
                ListBox04.ItemsSource = null;
                ListBox04.Items.Clear();
                ListBox04.ItemsSource = productDetails;
                AddToBasket.IsEnabled = true;
            }
        }

        private void Checkout_Click(object sender, RoutedEventArgs e)
        {
            Window w1 = new Checkout();
            w1.Visibility = Visibility.Visible;
        }
    }
}
