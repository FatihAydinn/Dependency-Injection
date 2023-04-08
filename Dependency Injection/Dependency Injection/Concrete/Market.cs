using Dependency_Injection.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection.Concrete
{
    public class Market
    {
        IProduct _product; 
        public Market(IProduct product) 
        {
            _product = product;
        }

        //Market sınıfı, IProduct arabirimine bağımlıdır ve IProduct nesnesi, Market sınıfının yapıcı metoduna enjekte edilir.

        public void Sell()
        {
            _product.Sell();
        }
    }
}
