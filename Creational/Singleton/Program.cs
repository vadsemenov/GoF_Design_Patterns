using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();
            singleton1.AddSingletonLog("Message from singleton1");
            singleton2.AddSingletonLog("Message from singleton2");

            Console.WriteLine(singleton1.GetSingletonLog());

        }
    }
}
