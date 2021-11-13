using System;

namespace inheritance
{
    class Human
    {
        public Human(string name, int age)
        {
            Name = name;
            setAge(age);
            setIsRetired();
        }
        public int age;
        public string Name { get; set; }

        public bool isRetired;
        public static int RETIREMENT_AGE = 65;
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

        public virtual void Greet()
        {
            Console.WriteLine("Привет ! Меня зовут " + Name + ", мне " + age + " лет. " + (isRetired ? "Я на пенсии" : "Я не на пенсии"));
        }
        public virtual void HappyBirthday()
        {
            setAge(age + 1);
            Console.WriteLine("Привет ! Меня зовут " + Name + ", мне исполнилось " + age + " лет. " + (isRetired ? "Я на пенсии" : "Я не на пенсии"));
        }
    }
}
