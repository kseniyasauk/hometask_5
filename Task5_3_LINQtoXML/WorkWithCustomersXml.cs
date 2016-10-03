using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.SqlServer.Server;

namespace Task5_3_LINQtoXML
{
    public class WorkWithCustomersXml
    {
        public  XDocument LoadXml()
        {
            return XDocument.Load(@"D:\Task5\Task5_3_LINQtoXML\Customers.xml");
        }

        public Dictionary<string, double> GetCustomersWithSumOfOrder(XDocument xd)
        {
            Dictionary<string, double> dictionary = new Dictionary<string, double>();

            var customers = xd.Elements()
                .First()
                .Elements();
            foreach (var customer in customers)
            {
                double totalSum = 0;

                var orders = customer
                    .Elements()
                    .Last()
                    .Elements();

                foreach (var order in orders)
                {
                    string value = order
                        .Elements()
                        .Last()
                        .Value;
                    string replace = value.Replace(".", ",");
                    totalSum += double.Parse(replace);
                }
                string id = customer
                    .Elements()
                    .First()
                    .Value;


                dictionary.Add(id,totalSum);
                
            }
            return dictionary;
        }

        public Dictionary<string, string> GroupCustomersByCountries(XDocument xd)
        {
            Dictionary<string,string> countries = new Dictionary<string, string>();
            var customers = xd.Elements()
                .First()
                .Elements();
            foreach (var customer in customers)
            {
                var customerAttributes = customer
                    .Elements();
                foreach (var attr in customerAttributes)
                {
                    if (!attr.Name.LocalName.Equals("country")) continue;
                    string id = customer
                        .Elements()
                        .First()
                        .Value;
                    countries.Add(id, attr.Value);
                    break;
                }
            }
            return countries;
        }

        public Dictionary<string, List<double>> GetMaxOrders(XDocument xd)
        {
            Dictionary<string, List<double>> dictionary = new Dictionary<string, List<double>>();
            List<double> cost = new List<double>();

            var customers = xd.Elements()
                .First()
                .Elements();
            foreach (var customer in customers)
            {
                var orders = customer
                    .Elements()
                    .Last()
                    .Elements();

                string id = customer
                    .Elements()
                    .First()
                    .Value;

                foreach (var order in orders)
                {
                    string value = order
                        .Elements()
                        .Last()
                        .Value;
                    string replace = value.Replace(".", ",");

                    cost.Add(double.Parse(replace));
                }
                dictionary.Add(id, cost);
            }
            return dictionary;
        }

        public Dictionary<string, List<DateTime>> GetOrderdate(XDocument xd)
        {
            Dictionary<string, List<DateTime>> dictionary = new Dictionary<string, List<DateTime>>();
            

            var customers = xd.Elements()
                .First()
                .Elements();
            foreach (var customer in customers)
            {
               var orders = customer
                    .Elements()
                    .Last()
                    .Elements();
                string id = customer
                    .Elements()
                    .First()
                    .Value;

                var orderDate = new List<DateTime>();

                foreach (var order in orders)
                {
                    var attributes = order
                        .Elements();
                    foreach (var attr in attributes)
                    {
                        if (!attr.Name.LocalName.Equals("orderdate")) continue;

                        IFormatProvider culture = CultureInfo.CurrentCulture.DateTimeFormat;

                        orderDate.Add(DateTime.ParseExact(attr.Value, "yyyy-MM-ddThh:mm:ss", culture));
                    }
                    
                    
                }
                dictionary.Add(id, orderDate);
                //if(orderDate.Count != 0) { orderDate = null;}
                orderDate = null;
            }
            return dictionary;
        }


        public void Start()
        {
            XDocument xmlDoc = LoadXml();

            var orders = GetCustomersWithSumOfOrder(xmlDoc);
            var countries = GroupCustomersByCountries(xmlDoc);
            var maxOrders = GetMaxOrders(xmlDoc);
            var orderDates = GetOrderdate(xmlDoc);

            var bigOrders = orders.Where(el => el.Value > 1000.0).ToList();
            foreach (var bigOrder in bigOrders)
            {
                Console.WriteLine(bigOrder);
            }

            Console.WriteLine($"Total: {bigOrders.Count}");

            bigOrders = orders.Where(el => el.Value > 5000.0).ToList();
            foreach (var bigOrder in bigOrders)
            {
                Console.WriteLine(bigOrder);
            }

            Console.WriteLine($"Total: {bigOrders.Count}");

            bigOrders = orders.Where(el => el.Value > 3000.0).ToList();
            foreach (var bigOrder in bigOrders)
            {
                Console.WriteLine(bigOrder);
            }

            Console.WriteLine($"Total: {bigOrders.Count}");

            bigOrders = orders.Where(el => el.Value > 10000.0).ToList();
            foreach (var bigOrder in bigOrders)
            {
                Console.WriteLine(bigOrder);
            }

            Console.WriteLine($"Total: {bigOrders.Count}");

            bigOrders = orders.Where(el => el.Value > 25000.0).ToList();
            foreach (var bigOrder in bigOrders)
            {
                Console.WriteLine(bigOrder);
            }

            Console.WriteLine($"Total: {bigOrders.Count}");

            var groupCountries = countries.GroupBy(el => el.Value, el => el.Key);
            foreach (var group in groupCountries)
            {
                Console.WriteLine($"Country:    {group.Key}");
                foreach (var customer in group)
                {
                    Console.WriteLine($"{customer}");
                }
                
            }

            foreach (var maxOrder in maxOrders)
            {
                var max = maxOrder
                    .Value
                    .Where(el => el > 16000.0)
                    .ToList();
                Console.WriteLine($"Customer: {maxOrder.Key}");
                foreach (var elem in max)
                {
                    Console.Write($"has {elem}, ");
                }
                Console.WriteLine();

                }

            foreach (var orderDate in orderDates)
            {
                if (orderDate.Value.Count != 0)
                {
                    Console.WriteLine($"Customer:{orderDate.Key} : orderdate --- {orderDate.Value.Min()}");
                }

            }

            var orderedCustomers = countries.OrderBy(el => el.Value).ToList();
            foreach (var customer in orderedCustomers)
            {
                Console.WriteLine($"{customer.Value} : customer --- {customer.Key}");
            }
        }

    }
}
