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

            // question mark here means --> the value of name can be null OR a string
            // an empty string is NOT the same as null
            string? userTypedName = Console.ReadLine();

            // comparison operators: ==, !=, >, <, >=, <=
            // equality operators: ==, !=
            // logical operators: &&, ||, !
            bool hasUserNotEnteredValidName = String.IsNullOrWhiteSpace(userTypedName);
            if (hasUserNotEnteredValidName)
            {
                Console.WriteLine("You didn't enter a value!");
                return;
            }

            Console.WriteLine("Hello " + userTypedName + "!");

            Thread.Sleep(1000);

            Console.WriteLine("How old are you?");

            string? ageString = Console.ReadLine();
            int convertedAge;
            // if the value of ageString is not a valid integer,
            // age will be set to 0 and the TryParse method will return false
            bool isValidNumber = Int32.TryParse(ageString, out convertedAge);
            if (isValidNumber == false)
            {
                Console.WriteLine("You didn't enter a valid number!");
                return;
            }
            if (convertedAge == 1)
            {
                Console.WriteLine("You are " + convertedAge + " year old.");
            }
            else
            {
                Console.WriteLine("You are " + convertedAge + " years old.");
            }

            int answer = Program.addNumbers(1, 3);
        }

        private static int addNumbers(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}