using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTemplate
{
    class ClassFactory : IFactory<ClassFactory>
    {
        public TProduct Build<TProduct>() where TProduct : IProduct<ClassFactory>, new()
        {
            return new TProduct();
        }
    }
}
