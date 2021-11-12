using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    class Woman
    {
        public Woman(string name, int age)
        {
            Name = name;
            setAge(age);
            setIsRetired();
        }
        private int age;
        public string Name { get; set; }

        private bool isRetired;
        public static int RETIREMENT_AGE = 60;
        public bool getIsRetired()
        {
            return isRetired;
        }
        public void setIsRetired()
        {
            isRetired = (age >= RETIREMENT_AGE) ? true : false;
        }


        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            this.age = age;
            setIsRetired();
        }

        public void Greet()
        {
            //setAge(age + 1);
            Console.WriteLine("Привет ! Меня зовут " + Name + ", мне " + age + " лет. " + (isRetired ? "Я на пенсии" : "Я не на пенсии"));
        }
    }
}
