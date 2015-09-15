using System;
using BlackWasp.AbstractFactory;

namespace PatternRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            PurchaseFactory spf = new StandardPurchaseFactory();
            ExampleClient standardClient = new ExampleClient(spf);

            Console.WriteLine(standardClient.ClientPackaging.GetType());
            Console.WriteLine(standardClient.ClientDocument.GetType());

            PurchaseFactory dpf = new DelicatePurchaseFactory();
            ExampleClient delicateClient = new ExampleClient(dpf);

            Console.WriteLine(delicateClient.ClientPackaging.GetType());
            Console.WriteLine(delicateClient.ClientDocument.GetType());

            ConsoleUtils.WaitForEscape();
        }
    }
}
