using System;

namespace BlackWasp.Factory
{
    public abstract class ProductBase
    {
        
    }

    public class ConcreteProduct1 : ProductBase
    {
    }

    public class ConcreteProduct2 : ProductBase
    {
    }

    public abstract class FactoryBase
    {
        public abstract ProductBase FactoryMethod(int type);
    }

    public class ConcreteFactory : FactoryBase
    {
        public override ProductBase FactoryMethod(int type)
        {
            switch (type)
            {
                case 1:
                    return new ConcreteProduct1();
                case 2:
                    return new ConcreteProduct2();
                default:
                    throw new ArgumentException("Invalid type", "type");
            }
        }
    }
}
