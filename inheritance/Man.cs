namespace inheritance
{
    class Man : Human
    {
        public Man(string name, int age) : base(name, age)
        {

        }
        public override void Greet()
        {
            System.Console.WriteLine("Привет! Я мужчина, меня зовут " + Name + ", мне " + age + " лет. " + (isRetired ? "Я на пенсии" : "Я не на пенсии"));
        }
        public override void HappyBirthday()
        {
            setAge(age + 1);
            System.Console.WriteLine("Привет!Я мужчина, меня зовут " + Name + ", мне исполнилось " + age + " лет. " + (isRetired ? "Я на пенсии" : "Я не на пенсии"));
        }
    }
}
