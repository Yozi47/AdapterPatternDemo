using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternDemo
{
    public class ProductCatalog
    {
        public void Print(object gateway)
        {
            Console.WriteLine(gateway.ToString());
            Console.ReadLine();
        }
    }

    //public class NewProductCatalog
    //{
    //    public void Print(IGetProductStack gateway)
    //    {
    //        Console.WriteLine(gateway.ToString());
    //        Console.ReadLine();
    //    }
    //}
}
