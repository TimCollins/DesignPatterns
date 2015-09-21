using System;
using BlackWasp.Factory;

namespace PatternRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory hyundai = new HyundaiCarFactory();
            Car coupe = hyundai.CreateCar("coupe");
            Console.WriteLine(coupe.GetType());

            ConsoleUtils.WaitForEscape();
        }        
    }
}

