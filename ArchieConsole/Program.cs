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
            string? name = Console.ReadLine();

            // comparison operators: ==, !=, >, <, >=, <=
            // equality operators: ==, !=
            // logical operators: &&, ||, !
            if (name == null || name == String.Empty) // you can also use this: if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("You didn't enter a value!");
                return;
            }

            Console.WriteLine("Hello " + name + "!");

            Thread.Sleep(1000);

            Console.WriteLine("How old are you?");

            string? ageString = Console.ReadLine();
            int age;
            // if the value of ageString is not a valid integer,
            // age will be set to 0 and the TryParse method will return false
            bool isValidNumber = Int32.TryParse(ageString, out age);
            if (isValidNumber == false)
            {
                Console.WriteLine("You didn't enter a valid number!");
                return;
            }
            if (age == 1)
            {
                Console.WriteLine("You are " + age + " year old.");
            }
            else
            {
                Console.WriteLine("You are " + age + " years old.");
            }
        }
    }
}