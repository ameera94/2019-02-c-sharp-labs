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

namespace lab_123_northwind_is_back
{
    /// <summary>
    /// Interaction logic for Checkout.xaml
    /// </summary>
    public partial class Checkout : Window
    {

        List<Order> ships = new List<Order>();

        public Checkout()
        {
            InitializeComponent();

            using (var db = new NorthwindEntities())
            {
                ships = db.Orders.OrderBy(o => o.ShipName).ToList();
                Ships.ItemsSource = ships;
                Ships.DisplayMemberPath = "ShipName";
            }
        }
        
        

        private void Ships_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("gj");
        }
    }
}
