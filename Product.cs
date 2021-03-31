using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternDemo
{
    public class Product : AbstractProduct
    {
        string productName = "";

        public Product(string aProduct)
        {
            this.productName = aProduct;
        }

        public override string ToString()
        {
            return this.productName;
        }
    }
}
