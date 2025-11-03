
namespace DomainPrimitives
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("John", "Mang", "020599-1777", 18);
            //Person person2 = new Person("wooop", "dooop", "889900-1234", 101);

            Console.WriteLine(person1.GetFirstName());
            Console.WriteLine(person1.GetLastName());
            Console.WriteLine(person1.GetCPR());
            Console.WriteLine(person1.GetAge());

        }
    }

}