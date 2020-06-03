namespace AbstractFactoryExample
{
    class ResizableWindowFactory : IAbstractFactory
    {
        public IAbstractProduct CreateProduct()
        {
            return new FormProduct(true);
        }
    }
}
