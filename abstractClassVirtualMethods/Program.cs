using System;

namespace abstractClassVirtualMethods
{
    public abstract class AbstractClass
    {
        public virtual void AbstractClassMethod()
        {
            Console.WriteLine("Default Implementation");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SomeClass sc = new SomeClass();
            sc.AbstractClassMethod();
            AnotherClass ac = new AnotherClass();
            ac.AbstractClassMethod();
        }
    }

    public class SomeClass : AbstractClass { }

    public class AnotherClass : AbstractClass
    {
        public override void AbstractClassMethod()
        {
            Console.WriteLine("New Implementation");
        }
    }
}
