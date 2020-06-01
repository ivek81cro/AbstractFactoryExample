using System.Windows.Forms;

namespace AbstractFactoryExample
{
    public interface IAbstractProduct
    {
        Form CreateFormFunction();
    }
}