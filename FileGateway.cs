using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdapterPatternDemo
{
    public class FileGateway : IGetProducts
    {
        public Stack<AbstractProduct> products = new Stack<AbstractProduct>();
        public Stack<AbstractProduct> GetProducts(string path)
        {
            foreach(string line in File.ReadAllLines(path))
            {
                List<string> listElements = line.Split(',').ToList();
                products.Push(new Product(listElements[1]));
            }
            return products;
        }

        public override string ToString()
        {
            string aString = "";
            foreach(Product product in products)
            {
                aString = aString + product.ToString() + "\n";
            }
            return aString;
        }
    }
}
