using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeFactory<ClassFactory> objekt = new TypeFactory<ClassFactory>();
            IProduct<ClassFactory> objProduct = objekt.Create<Klasa>();
            Console.WriteLine(objProduct.GetType());

            Console.ReadKey();
        }
    }
}
