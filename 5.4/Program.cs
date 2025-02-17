using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4
{
    internal class Program
    {
        // using the data to mage website browsing
        static List<string> customer = new List<string>(); // list of websites
        private static IEnumerable<KeyValuePair<string, double>> name;

        static void Main(string[] args)
        {
            int customer = 0; // user input

            //user gets ask what differnt type of method whould they like to use
            Console.WriteLine("Welcome web browsing  application");
            while (true) // loop
            {

                Console.WriteLine("1. vist New Page\n " +
                   "2. Go Back\n " +
                   "3. View Browsing History\n " +
                   "4. Exit\n");

                Console.WriteLine("Enter your choice:");
                customer = Convert.ToInt32(Console.ReadLine());
                // import of the menu

                switch (customer)
                {
                    case 1:
                        // new page
                        AdduCstomer();
                        break;
                    case 2:
                        // go back
                        NextCustomer();
                        break;
                    case 3:
                        // view browsing
                        ViewQueue();
                        break;
                    case 4:
                        //Exit
                        return; // leave site
                    default:
                        //invaild option
                        Console.WriteLine("Invaild Option");
                        break;
                }



            }
        }
        // enter customer 
        static void AdduCstomer()
        {
            Console.WriteLine("Add Customer:");
            string name = Console.ReadLine();

            customer.Add(name); // add customer to the line
            Console.WriteLine(name + "Customer added successfully");
        }
        static void NextCustomer() // next customer
        {
            Console.WriteLine("Enter to see the next customer:");
            string nextcustomer = Console.ReadLine();
        }
        static void ViewQueue() // view all queue
        {
            Console.WriteLine("Enter name to see the next queue");
            string Queue = Console.ReadLine();
        }
    }
}
