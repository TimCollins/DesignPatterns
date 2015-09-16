using System;
using BlackWasp.GenericObjectPool;

namespace PatternRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var pool = new Pool<PooledObject>(o => o.Name = null);

            var obj1 = pool.Get();
            obj1.Name = "First";
            Show(obj1);

            var obj2 = pool.Get();
            obj2.Name = "Second";
            Show(obj2);

            pool.Release(obj1);

            var obj3 = pool.Get();
            // Note that the third object will remember its name from the previous use.
            Show(obj3);

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
