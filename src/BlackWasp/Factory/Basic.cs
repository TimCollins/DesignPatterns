using System;

namespace BlackWasp.Factory
{
    /// <summary>
    /// This is the base class for the different object types that the factory can create.
    /// </summary>
    public abstract class ProductBase
    {
        
    }

    /// <summary>
    /// A subclass of ProductBase which would contain specific functionality in a real example.
    /// </summary>
    public class ConcreteProduct1 : ProductBase
    {
    }

    /// <summary>
    /// A subclass of ProductBase which would contain specific functionality in a real example.
    /// </summary>
    public class ConcreteProduct2 : ProductBase
    {
    }

    /// <summary>
    /// The base class for the actual factory classes that will create new objects.
    /// </summary>
    public abstract class FactoryBase
    {
        public abstract ProductBase FactoryMethod(int type);
    }

    /// <summary>
    /// This inherits the functionality from FactoryBase and overrides the factory method as
    /// required to handle the creation of specific objects or handle an error.
    /// </summary>
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
