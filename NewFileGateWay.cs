using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdapterPatternDemo
{
    public class NewFileGateWay : IGetProductStack
    {
        Stack<AbstractProduct> products = new Stack<AbstractProduct>();
        FileGateway lastGateWay = null;
        public NewFileGateWay(FileGateway oldFileGateWay)
        {
            this.lastGateWay = oldFileGateWay;
        }
        public Stack<AbstractProduct> GetProducts(string path)
        {
            foreach(AbstractProduct aProduct in lastGateWay.GetProducts(path))
            {
                products.Push(aProduct);
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
