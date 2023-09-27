// This is the beginning of C#

namespace Beginning
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("This is my first program");
            
            Console.WriteLine("Type in your name");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("No name was entered");
            }
            else if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("No name was entered");
            }
            else
            {
                Console.WriteLine("Name: " + name);
            }
        }
    }
}