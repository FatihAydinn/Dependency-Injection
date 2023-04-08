using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection.Abstract
{
    public abstract class BaseProduct : IProduct
    {
        protected double price;
        public void Sell()
        {
            Console.WriteLine("Price: "+price+"\tSold.");
        }
    }
}
