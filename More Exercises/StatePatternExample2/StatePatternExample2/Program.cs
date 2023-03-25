namespace StatePatternExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Carol = new Person();

            Carol.Talk();

            Carol.DrinkCoffee();
            Carol.Talk();

            Carol.DrinkWhiskey();
            Carol.Talk();
        }
    }
}