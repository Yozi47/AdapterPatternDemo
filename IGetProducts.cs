using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternDemo
{
    interface IGetProducts
    {
        Stack<AbstractProduct> GetProducts(string path);
    }
}
