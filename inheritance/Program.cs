using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man1 = new Man("Витя", 45);
            Man man2 = new Man("Оля алкаш", 25);
            man1.Greet();
            man1.setAge(66);
            man1.Greet();
            man2.Greet();
            man1.setAge(46);
            // man1.HappyBirthday(); man1.HappyBirthday(); man1.HappyBirthday();
            Console.WriteLine(Man.RETIREMENT_AGE);


            Console.ReadKey();
        }
    }
}
