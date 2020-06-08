using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTemplate
{
    class StructFactory : IFactory<StructFactory>
    {
        public TProduct Build<TProduct>() where TProduct : IProduct<StructFactory>, new()
        {
            return new TProduct();
        }
    }
}
