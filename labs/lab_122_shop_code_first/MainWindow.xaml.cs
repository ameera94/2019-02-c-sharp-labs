using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Data.Entity;



namespace lab_122_shop_code_first
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Department> departments = new List<Department>();
        List<Product> products = new List<Product>();
        Department departmentSelect;
        //Product productSelect;
        string[] electronics = new string[] { "iPad", "Charger", "Macbook Air", "Keyboard", "Speaker", "Universal Remote" };
        string[] books = new string[] { "Of Mice and Men by John Steinbeck", "Sapiens by Yuval Noah Harari", "The BFG by Roald Dahl", "Mythos by Stephen Fry", "1984 by George Orwell", "American Psycho by Bret Easton Ellis" };
        string[] groceries = new string[] { "Oreos", "Pesto", "Spiced Rum", "Bananas", "Peanut Butter", "Carrot Cake" };
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();


            using (var db = new ShopContext())
            {

                for (int i = 0; i < electronics.Length; i++)
                {
                    var electronic01 = new Product
                    {
                        ProductID = i,
                        ProductName = electronics[i],
                        DepartmentID = 1,
                        Price = (rnd.Next(50, 500) / rnd.Next(1, 10)),
                        Stock = rnd.Next(1, 40)
                    };

                    db.Products.Add(electronic01);
                    db.SaveChanges();
                }


                departments = db.Departments.OrderBy(d => d.DepartmentID).ToList();
                ListBox01.ItemsSource = departments;
                ListBox01.DisplayMemberPath = "DepartmentName";

                //products = db.Products.OrderBy(p => p.ProductID).ToList();
               
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
