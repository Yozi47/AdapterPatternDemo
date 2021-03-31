using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternDemo
{
    public class ProductCatalog
    {
        public void Print(FileGateway products)
        {
            Console.WriteLine(products.ToString());
            Console.ReadLine();
        }
    }
}
