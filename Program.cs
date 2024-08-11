using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace singleton_demo
{
    public class Program
    {

        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance;
            singleton1.DoSomething();

            Singleton singleton2 = Singleton.GetInstance;
            singleton2.DoSomething();

            Console.WriteLine(singleton1.Equals(singleton2));
        }
    }

    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object _lock = new object();

        private Singleton()
        { }

        public static Singleton GetInstance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("hello from singleton");
        }


    }
}