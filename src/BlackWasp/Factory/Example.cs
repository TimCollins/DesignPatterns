using System;

namespace BlackWasp.Factory
{
    public class Example
    {
        public abstract class Car
        {
        }

        public class HyundaiCoupe : Car
        {
        }

        public class HyundaiI30 : Car
        {
        }

        public class MazdaMX5 : Car
        {
        }

        public class Mazda6 : Car
        {
        }

        public abstract class CarFactory
        {
            public abstract Car CreateCar(string model);
        }

        public class HyundaiCarFactory : CarFactory
        {
            public override Car CreateCar(string model)
            {
                switch (model.ToLower())
                {
                    case "coupe":
                        return new HyundaiCoupe();
                    case "i30":
                        return new HyundaiI30();
                    default:
                        throw new ArgumentException("Invalid model", "model");
                }
            }
        }

        public class MazdaCarFactory : CarFactory
        {
            public override Car CreateCar(string model)
            {
                switch (model.ToLower())
                {
                    case "mx5":
                        return new MazdaMX5();
                    case "6":
                        return new Mazda6();
                    default:
                        throw new ArgumentException("Invalid model", "model");
                }
            }
        }
    }
}
