using Dependency_Injection.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection.Concrete
{
//Setter DI
    public class ZProduct : BaseProduct
    {
        public ZProduct() 
        {
            price = 30;
        }
    }
}
