using System;


namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Last Name");
            string LastName = Console.ReadLine();
            Pattern pattern = new Pattern();

            if (pattern.ValidateLastname(LastName))
            {
                Console.WriteLine("Lastname matched");
            }
            else if (LastName.Length < 3)
            {
                Console.WriteLine("Please enter atleast three characters");


            }

            else
            {
                Console.WriteLine("Lastname does not matched");
            }









        }
    }
}