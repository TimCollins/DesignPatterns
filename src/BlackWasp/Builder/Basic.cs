namespace BlackWasp.Builder
{
    /// <summary>
    /// This class controls the generation of the final object.
    /// </summary>
    public class Director
    {
        public void Construct(Builder builder)
        {            
        }
    }

    /// <summary>
    /// The complex object that is to be created by the Builder pattern.
    /// </summary>
    public class Product
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Part3 { get; set; }
    }

    /// <summary>
    /// The base class for all of the steps that must be taken to create an instance of the Product
    /// class.
    /// </summary>
    public abstract class Builder
    {
        public abstract void BuildPart1();
        public abstract void BuildPart2();
        public abstract void BuildPart3();
        public abstract Product GetProduct();
    }

    /// <summary>
    /// The implementation of the Builder base class which contains the functionality required to
    /// actually create an instance of the Product class.
    /// </summary>
    public class ConcreteBuilder : Builder
    {
        private readonly Product _product = new Product();

        public override void BuildPart1()
        {
            _product.Part1 = "Part 1";
        }

        public override void BuildPart2()
        {
            _product.Part2 = "Part 2";
        }

        public override void BuildPart3()
        {
            _product.Part3 = "Part 3";
        }

        public override Product GetProduct()
        {
            return _product;
        }
    }
}
