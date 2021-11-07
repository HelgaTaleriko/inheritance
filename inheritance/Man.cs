using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    class Man
    {
        public Man(string name, int age)
        {
            Name = name;
            setAge(age);
        }
        private int age;
        public string Name { get; set; }

        public int getThisAge()
        {
            return this.age;
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int age )
        {
           this.age=age;
        }
        
        public void Greet()
        {
            Console.WriteLine("Привет ! Меня зовут " + Name + ", мне " + age + " лет.");
        }
    }
}
