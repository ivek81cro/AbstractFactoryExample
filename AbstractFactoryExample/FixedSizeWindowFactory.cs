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
