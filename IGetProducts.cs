using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternDemo
{
    public interface IGetProducts
    {
        Queue<AbstractProduct> GetProducts(string path);
    }
}
