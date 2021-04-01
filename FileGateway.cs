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
        public Queue<AbstractProduct> products = new Queue<AbstractProduct>();
        public Queue<AbstractProduct> GetProducts(string path)
        {
            string fullPath = Path.GetFullPath(path);
            string[] allRows = { };
            string[] allColumns = { };

            Queue<AbstractProduct> aQueueOfProducts = new Queue<AbstractProduct>();

            // Create a temperoary variable to create one employee each time through the loop
            Product aProduct;

            allRows = File.ReadAllLines(fullPath);

            int index = 1;

            while (index < allRows.Length)
            {
                // Split ONE row into an array of information for One Employee
                allColumns = allRows[index].Split(',');

                aProduct = new Product(allColumns[1]);
                products.Enqueue(aProduct);
                index++;
            }
            return products;
        }
        public override string ToString()
        {
            string message = "";
            foreach (AbstractProduct product in products)
            {
                message += product.ToString() + "\n";
            }

            return message;
        }
    }
}
