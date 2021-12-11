namespace ArchieConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // native variable types - https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
            int sleepTime = 3000;
            bool isDadEpic = true;
            char firstCharacter = 'A';

            if (isDadEpic)
            {
                Console.WriteLine("Dad is epic");
            }
            else
            {
                Console.WriteLine("Dad is not epic :(");
            }

            string firstName = "Archie";
            Console.WriteLine("First Name: " + firstName);

            Thread.Sleep(sleepTime);
            Console.WriteLine("Archie is good");
        }
    }
}