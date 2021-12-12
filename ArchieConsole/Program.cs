namespace ArchieConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // native variable types - https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types

            bool isDadEpic = true;
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
            Console.WriteLine();

            int sleepTime = 200;
            Thread.Sleep(sleepTime);
            Console.WriteLine("Archie is good");
            Console.WriteLine();

            // arrays
            int[] numbers = new int[5];
            numbers[0] = 12;
            Console.WriteLine("First value in numbers array " + numbers[0]);
            Console.WriteLine("Second value in numbers array " + numbers[1]);
            Console.WriteLine("Third value in numbers array " + numbers[2]);
            Console.WriteLine();

            string[] food = new string[5];
            food[0] = "Pizza";
            food[1] = "Hot Sauce";
            Console.WriteLine("First value in names array " + food[0]);
            Console.WriteLine(food[1]);

            string[] stringArray = { "Archie", "Charlie", "Dad", "Mum", "Cheese" };
            // position or index        0          1        2      3       4
            Console.WriteLine("Second string in array: " + stringArray[1]);
            Console.WriteLine("Fifth string in array: " + stringArray[4]);
            Console.WriteLine();
        }
    }
}