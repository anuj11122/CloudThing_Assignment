using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Bird
{
    public class Animal
    {
       public void walk()
        {
            Console.WriteLine("I can walk");
        }
    }
    public class Bird : Animal
    {
        public void fly()
        {
            Console.WriteLine("I can fly");
        }
    }
}
