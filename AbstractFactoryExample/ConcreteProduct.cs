using System;
using System.Windows.Forms;

namespace AbstractFactoryExample
{
    class ConcreteProduct : IAbstractProduct
    {
        public ConcreteProduct(bool b) { this.b = b; }
        public Form CreateFormFunction()
        {
            Form f = new FormProduct();
            if(b)
            {
                return f;
            }
            f.FormBorderStyle = FormBorderStyle.FixedSingle;
            f.MinimizeBox = false;
            f.MaximizeBox = false;
            return f;
        }

        bool b;
    }
}