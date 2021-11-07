using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man1 = new Man("Витя", 45);
            Console.WriteLine(man1.Name);
            Console.WriteLine(man1.getThisAge());
            Man man2 = new Man("Оля алкаш", 25);
            Console.WriteLine(man2.Name);
            Console.WriteLine(man2.getThisAge());
            man2.Greet();
            man2.setAge(26);
            man2.Greet();
            man1.Greet();
            man1.setAge(46);
            Console.WriteLine(man1.getAge());
            Console.WriteLine(man1.getThisAge());


            Console.ReadKey();
        }
    }
}
