//By: Anuj

using System;

namespace Animal_Bird
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            Console.WriteLine("cat: ");
            cat.walk();
            Bird hawk = new Bird();
            Console.WriteLine("hawk: ");
            hawk.walk();
            hawk.fly();
        }
    }
}
