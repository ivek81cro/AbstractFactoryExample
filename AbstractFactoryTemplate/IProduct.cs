using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTemplate
{
    interface IProduct<TFactory>
    {
        void Method();
    }
}
