using ArchieConsole.Dad;

namespace ArchieConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string argValue in args)
            {
                Console.WriteLine(argValue);
            }

            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Thread.Sleep(3333);
        }
    }
}