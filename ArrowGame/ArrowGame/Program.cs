//By: Anuj

using System;

namespace ArrowGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int enemy = r.Next(1, 100);
            Console.WriteLine("Enemies: Hey Gamer! we are " + enemy);

            int arrow = r.Next(1, 300);
            Console.WriteLine("Avtar: Let's see who wins becasuse I have also " + arrow + " arraow");

            if (arrow >= (3 * enemy))
                Console.WriteLine("Avtar: And this time I am going to kill you all");
            else
                Console.WriteLine("Enemies: Still You are gonna die");
        }
    }
}
