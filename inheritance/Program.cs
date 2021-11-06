using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man1 = new Man("Витя", 45);
            man1.Greet();

            Console.ReadKey();
        }
    }
}
