using Dependency_Injection.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection.Concrete
{
//Setter DI
    public class Market2
    {
        public IProduct _product { get; set; }
        public void Sell()
        {
            _product.Sell();
        }
    }
}
