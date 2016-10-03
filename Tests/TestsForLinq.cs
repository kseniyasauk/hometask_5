using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5_3_LINQtoXML;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class TestsForLinq
    {
        static WorkWithCustomersXml xml;

        [TestInitialize]
        public void TestInitialize()
        {
            xml = new WorkWithCustomersXml();
        }

        [TestMethod]
        public  void TstBigOrders()
        {
            var orders = xml.GetCustomersWithSumOfOrder(xml.LoadXml());
            var bigOrders = orders.Where(el => el.Value > 25000.0).ToList();
            //foreach (var bigOrder in bigOrders)
            //{
            //    Console.WriteLine(bigOrder);
            //}
            //Console.WriteLine($"Total: {bigOrders.Count}");
            Assert.AreEqual(12, bigOrders.Count);
        }

        [TestMethod]
        public void TstGroupCountries()
        {
            var countries = xml.GroupCustomersByCountries(xml.LoadXml());
            var groupCustomers = countries.OrderBy(el => el.Value).ToList();
            
            //Assert.AreEqual(true, groupCustomers);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            xml = null;
        }

        
    }
}
