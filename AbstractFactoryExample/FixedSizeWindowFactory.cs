using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    class FixedSizeWindowFactory : IAbstractFactory
    {
        public IAbstractProduct CreateProduct()
        {
            return new ConcreteProduct(false);
        }
    }
}
