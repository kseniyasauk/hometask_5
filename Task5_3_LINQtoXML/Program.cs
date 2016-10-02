using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task5_3_LINQtoXML
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithCustomersXml xml = new WorkWithCustomersXml();
            xml.Start();
        }
    }
}
