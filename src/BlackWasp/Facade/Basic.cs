namespace BlackWasp.Facade
{
    /// <summary>
    /// This class contains a simple set of functions that hides the complexity of the wrapped classes.
    /// </summary>
    public class Facade
    {
        public void PerformAction()
        {
            Class1A c1a = new Class1A();
            Class1B c1b = new Class1B();
            Class2A c2a = new Class2A();
            Class2B c2b = new Class2B();

            int result1a = c1a.Method1A();
            int result1b = c1b.Method1B(result1a);
            int result2a = c2a.Method2A(result1a);
            c2b.Method2B(result1b, result2a);
        }
    }

    /// <summary>
    /// Consider this class and the others below as being poorly-designed or complicated.
    /// </summary>
    public class Class1A
    {
        public int Method1A()
        {
            return 1;
        }
    }

    public class Class1B
    {
        public int Method1B(int param)
        {
            return 2 + param;
        }
    }

    public class Class2A
    {
        public int Method2A(int param)
        {
            return 3 - param;
        }
    }

    public class Class2B
    {
        public int Method2B(int param1, int param2)
        {
            return 4 + param1 + param2;
        }
    }
}
