using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTemplate
{
    class Klasa : IProduct<ClassFactory>
    {
        public Klasa() { }
        public void Method() {}
    }
}
