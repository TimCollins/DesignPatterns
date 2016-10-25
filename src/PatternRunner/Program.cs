using System;
using BlackWasp.Facade;

namespace PatternRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            StockFacade facade = new StockFacade();
            bool isLow = facade.IsLowStock("ABC123");
            
            Console.WriteLine("Stock is " + (isLow ? "" : "not ") + "low");
            ConsoleUtils.WaitForEscape();
        }        
    }
}