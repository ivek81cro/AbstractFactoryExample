using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactoryExample
{
    class ResizableWindowFactory : IAbstractFactory
    {
        public IAbstractProduct CreateProduct()
        {
            return new ConcreteProduct(true);
        }
    }
}
