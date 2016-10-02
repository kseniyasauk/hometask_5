using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task5_3_LINQtoXML
{
    public class WorkWithCustomersXml
    {
        public  XDocument LoadXml()
        {
            return XDocument.Load(@"D:\Task5\Task5_3_LINQtoXML\Customers.xml");
        }

        public  Dictionary<string,double> GetCustomersWithSumOfOrder(XDocument xd)
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

        public void Start()
        {
            var orders = GetCustomersWithSumOfOrder(LoadXml());
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
        }
    }
}
