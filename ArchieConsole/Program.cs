namespace ArchieConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable types - https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
            booleanTypes();
            stringTypes();
            integerTypes();

            arrays();

            forEachLoops();
        }

        private static void booleanTypes()
        {
            // boolean - true or false (also think of this as 0 and 1) (think of as on and off)
            bool isDadEpic = true;
            if (isDadEpic)
            {
                Console.WriteLine("Dad is epic");
            }
            else
            {
                Console.WriteLine("Dad is not epic :(");
            }
        }

        private static void stringTypes()
        {
            // string - think of them as text values
            string firstName = "Archie";
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine();
        }

        private static void integerTypes()
        {
            // integers - think of them as numbers
            int sleepTime = 200;
            Thread.Sleep(sleepTime);
            Console.WriteLine("Archie is good");
            Console.WriteLine();
        }

        private static void arrays()
        {
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

            string[] namesArray = { "Archie", "Charlie", "Dad", "Mum", "Grandad" };
            // position or index        0          1        2      3       4
            Console.WriteLine("Second string in array: " + namesArray[1]);
            Console.WriteLine("Fifth string in array: " + namesArray[4]);
            Console.WriteLine();
        }

        private static void forEachLoops()
        {
            string[] namesArray = { "Archie", "Charlie", "Dad", "Mum", "Grandad" };
            foreach (string name in namesArray)
            {
                Console.WriteLine("name: " + name);
            }

            // 1. create a new array of 3 integers
            // 2. assign the values of all 3 integers
            // 3. write to the console the values of all 3 integers - using a foreach loop

            int[] water = { 1, 52, 634, 23223, 99 };

            foreach (int liquid in water)
            {
                Console.Write(liquid + " ");
            }

            // the new keyword creates a new reference in memory
            string[] dadArray = new string[5];
            string[] archieArray = dadArray; // archieArray is a reference to the same memory location as dadArray

            dadArray[0] = "Cheeeeeeeese";
            Console.WriteLine(archieArray[0]);
            archieArray[1] = "Beans";
            Console.WriteLine(dadArray[1]);
        }
    }
}