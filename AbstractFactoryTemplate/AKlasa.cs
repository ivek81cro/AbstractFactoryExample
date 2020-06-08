using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTemplate
{
    abstract class AKlasa : IProduct<AbstractClassFactory>
    {
        public abstract void Method();
    }
}
