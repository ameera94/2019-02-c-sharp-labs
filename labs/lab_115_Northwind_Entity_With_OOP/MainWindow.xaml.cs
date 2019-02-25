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
using System.Diagnostics;


namespace lab_115_Northwind_Entity_With_OOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

        // READ CUSTOMERS AND CAST TO ACTIVECUSTOMERS AND SET ISACTIVE TO TRUE FOR ALL CUSTOMERS
        // CREATE 2 LIST BOXES AND A RADIO BUTTON TO ENABLE/DISABLE OUR ACTIVECUSTOMER
        // CLICK ON CUSTOMER TO SELECT AND DISPLAY ALL DETAILS ON SCREEN (TEXTBLOCK/STACKPANEL/LISTBOX)
        // WHEN YOU CLICK ON ENABLE/DISABLE BUTTON (TOGGLE BUTTON) IT WILL REVERSE THE STATE OF THE CUSTOMER (ISACTIVE)
        // FIRST LISTBOX = ONLY FOR ACTIVE CUSTOMERS 
            // STATE BECOMES INACTIVE ==> REMOVE FROM FIRST LISTBOX
        // SECOND LISTBOX = ONLY FOR INACTIVE CUSTOMERS 
            //INACTIVE STATE: REMOVE FROM FIRST BUT ADD TO SECOND LISTBOX
        // REVERSE PROCESS I.E. WHEN YOU CLICK ON AN INACTIVE CUSTOMER (SECOND LISTBOX) YOU CAN THEN TOGGLE THE STATE BACK TO ENABLED USING THE RADIO OR TOGGLE BUTTON 
            // REMOVED FROM INACTIVE AND ADDED BACK TO THE ACTIVE LIST. 





    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void Initialize()
        {
            Customer c = new Customer();
            //c.DoThis();

        }
    }

    //Interface is like a tool you can use/implement
    interface IDoThis
    {
        void DoThis();
    }

    //Interface is like a tool you can use/implement
    interface IDoThat
    {
        void DoThat();
    }


    //class Customer 
    //class ActiveCustomer : Customer
    class ActiveCustomer: Customer, IDoThis, IDoThat
    {
        public bool IsActive;

        public void DoThis()
        {
            Trace.WriteLine("Customer is doing something");

        }
        public void DoThat()
        {

        }

    }

}
