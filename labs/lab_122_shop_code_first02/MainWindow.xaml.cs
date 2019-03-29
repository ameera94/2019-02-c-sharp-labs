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
using System.Data.Entity;


namespace lab_122_shop_code_first02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Department> departments = new List<Department>();
        List<Product> products = new List<Product>();
        Department departmentSelect;
        Product productSelect;       
        List<decimal> total = new List<decimal>();
        List<Product> basket = new List<Product>();
        string[] deps = new string[] { "Electronics", "Books", "Groceries" };
        string[] electronics = new string[] { "iPad", "Charger", "Macbook Air", "Keyboard", "Speaker", "Universal Remote" };
        string[] books = new string[] { "Of Mice and Men by John Steinbeck", "Sapiens by Yuval Noah Harari", "The BFG by Roald Dahl", "Mythos by Stephen Fry", "1984 by George Orwell", "American Psycho by Bret Easton Ellis" };
        string[] groceries = new string[] { "Oreos", "Pesto", "Spiced Rum", "Bananas", "Peanut Butter", "Carrot Cake" };
        Random rnd = new Random();
        

        public MainWindow()
        {
            InitializeComponent();

            AddToBasket.IsEnabled = false;
            using (var db = new ShopContext())
            {
                //for (int i = 0; i < deps.Length; i++)
                //{
                //    var department01 = new Department
                //    {
                //        DepartmentID = i,
                //        DepartmentName = deps[i]
                //    };

                //    db.Departments.Add(department01);
                //    db.SaveChanges();
                //}

                //for (int i = 0; i < electronics.Length; i++)
                //{
                //    var electronic01 = new Product
                //    {
                //        ProductID = i,
                //        ProductName = electronics[i],
                //        DepartmentID = 1,
                //        Price = (rnd.Next(50, 500) / rnd.Next(1, 10)),
                //        Stock = rnd.Next(1, 40)
                //    };

                //    db.Products.Add(electronic01);
                //    db.SaveChanges();
                //}

                //for (int i = 0; i < books.Length; i++)
                //{
                //    var book01 = new Product
                //    {
                //        ProductID = i,
                //        ProductName = books[i],
                //        DepartmentID = 2,
                //        Price = (rnd.Next(5, 15) / rnd.Next(1, 2)),
                //        Stock = rnd.Next(1, 40)
                //    };

                //    db.Products.Add(book01);
                //    db.SaveChanges();
                //}

                //for (int i = 0; i < groceries.Length; i++)
                //{
                //    var grocery01 = new Product
                //    {
                //        ProductID = i,
                //        ProductName = groceries[i],
                //        DepartmentID = 3,
                //        Price = (rnd.Next(1, 5) / rnd.Next(1, 5)),
                //        Stock = rnd.Next(1, 80)
                //    };

                //    db.Products.Add(grocery01);
                //    db.SaveChanges();
                //}

                departments = db.Departments.OrderBy(d => d.DepartmentID).ToList();
                ListBox01.ItemsSource = departments;
                ListBox01.DisplayMemberPath = "DepartmentName";

                products = db.Products.OrderBy(p => p.ProductID).ToList();

            }
        }

        private void ListBox01_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            departmentSelect = (Department)ListBox01.SelectedItem;
            using (var db = new ShopContext())
            {
                products = db.Products.Where(p => p.DepartmentID == departmentSelect.DepartmentID).ToList<Product>();
                ListBox02.ItemsSource = products;
                ListBox02.DisplayMemberPath = "ProductName";
            }            

        }

        private void ListBox02_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            productSelect = (Product)ListBox02.SelectedItem;
            List<string> productDetails = new List<string>();
            productDetails.Add($"Product ID: {productSelect.ProductID.ToString()}");
            productDetails.Add($"Product: {productSelect.ProductName}");
            productDetails.Add($"Price: £{productSelect.Price.ToString()}");
            productDetails.Add($"Stock: {productSelect.Stock.ToString()}");
            ListBox04.ItemsSource = productDetails;

            AddToBasket.IsEnabled = true;
        }

        private void AddToBasket_Click(object sender, RoutedEventArgs e)
        {
           
            productSelect = (Product)ListBox02.SelectedItem;
            basket.Add(productSelect);
            ListBox03.ItemsSource = basket;
            ListBox03.DisplayMemberPath = "ProductName";
            total.Add(productSelect.Price);
            decimal totalPrice = total.Sum();
            TotalPrice.Content = $"Total: £{totalPrice}";
            productSelect.Stock -- ;

        }

        private void RemoveFromBasket_Click(object sender, RoutedEventArgs e)
        {
            productSelect = (Product)ListBox03.SelectedItem;
            basket.Remove(productSelect);
            total.Remove(productSelect.Price);
            decimal totalPrice = total.Sum();
            TotalPrice.Content = $"Total: £{totalPrice}";
            productSelect.Stock++ ;
           



        }
    }

    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Product> Products { get; set; }

    }

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int DepartmentID { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

    public class ShopContext : DbContext
    {
        //constructor method: bounce responsibility back up to Entity DbContext to do all the hard work
        public ShopContext() : base() { } //default blank

        //setting up tables for db
        public DbSet<Department> Departments { get; set; }
        public DbSet<Product> Products { get; set; }

    }

}

