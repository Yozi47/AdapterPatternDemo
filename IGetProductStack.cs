using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternDemo
{
    public interface IGetProductStack
    {
        Stack<AbstractProduct> GetProducts(string path);
    }
}
