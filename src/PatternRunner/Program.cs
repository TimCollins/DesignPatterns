using System;
using BlackWasp.GenericObjectPool;

namespace PatternRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var pool = new Pool<PooledObject>();

            var obj1 = pool.Get();
            obj1.Name = "First";
            Show(obj1);

            var obj2 = pool.Get();
            obj2.Name = "Second";
            Show(obj2);

            var obj3 = pool.Get();
            obj3.Name = "Third";
            Show(obj3);

            ConsoleUtils.WaitForEscape();
        }

        private static void Show(PooledObject o)
        {
            Console.WriteLine("{0} - {1}", o.PermanentId, o.Name);
        }
    }
}
