using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\ybrad\OneDrive\Desktop\IT 514\AdapterPatternDemo\Products1.csv";
            FileGateway aGateway = new FileGateway();
            aGateway.GetProducts(path);
            ProductCatalog aCatalog = new ProductCatalog();
            aCatalog.Print(aGateway);
        }
    }
}
