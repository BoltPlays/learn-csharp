namespace ArchieConsole.Dad
{
    public class Learn
    {
        // variable types - https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
        // methods
        // - void - means the method will not return anything, no value is returned by the method
        public static void BooleanTypes()
        {
            // boolean - true or false (also think of this as 0 and 1) (think of as on and off)
            bool isDadEpic = true;
            if (isDadEpic) // condition/expression - will return true or false
            {
                Console.WriteLine("Dad is epic");
            }
            else
            {
                Console.WriteLine("Dad is not epic :(");
            }

            bool nothing = false;
            Console.WriteLine(nothing);
        }

        public static void StringTypes()
        {
            // string - think of them as text values
            string firstName = "Archie";
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine();

            string pizza = "3";
            Console.WriteLine(pizza);
        }

        public static void IntegerTypes()
        {
            // integers - think of them as numbers
            int sleepTime = 200;
            Thread.Sleep(sleepTime);
            Console.WriteLine("Archie is good");
            Console.WriteLine();

            int anything = 4444;
            Console.WriteLine(anything);
        }

        public static void Arrays()
        {
            // arrays - a collection of stuff / a list of things
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
            // position or index       0          1        2      3        4
            Console.WriteLine("Second string in array: " + namesArray[1]);
            Console.WriteLine("Fifth string in array: " + namesArray[4]);
            Console.WriteLine();

            bool[] boolArray = { true, false, true };
        }

        public static void ForEachLoops()
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