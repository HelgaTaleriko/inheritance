using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man1 = new Man("Витя",45);
            Man man2 = new Man("Петя", 56);
            Man man3 = new Man("Колясичек");
            Woman woman1 = new Woman("Марина", 59);
            man3.Greet();
            man1.Greet();
            man1.setAge(66);
            man1.Greet();
            man2.Greet();
            man1.setAge(64);
            woman1.Greet();
            woman1.setAge(59);
            man1.HappyBirthday();
            woman1.HappyBirthday();
            Console.ReadKey();
        }
    }
}
