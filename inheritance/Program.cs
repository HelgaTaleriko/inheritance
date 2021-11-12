using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man1 = new Man("Витя", 45);
            Man man2 = new Man("Оля алкаш", 25);
            Woman woman1 = new Woman("Марина", 78);
            man1.Greet();
            man1.setAge(66);
            man1.Greet();
            man2.Greet();
            man1.setAge(46);
            woman1.Greet();
            woman1.setAge(78);


            // man1.HappyBirthday(); man1.HappyBirthday(); man1.HappyBirthday();
            Console.WriteLine(Man.RETIREMENT_AGE);


            Console.ReadKey();
        }
    }
}
