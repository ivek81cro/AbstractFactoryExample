using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTemplate
{
    class AbstractClassFactory : IFactory<AbstractClassFactory>
    {
        public TProduct Build<TProduct>() where TProduct : IProduct<AbstractClassFactory>, new()
        {
            return new TProduct();
        }
    }
}
