using System;


namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name");
            string FirstName = Console.ReadLine();
            Pattern pattern = new Pattern();

            if (pattern.Validatefirstname(FirstName))
            {
                Console.WriteLine("Name matched");
            }
            else if (FirstName.Length < 3)
            {
                Console.WriteLine("Please enter atleast three characters");


            }

            else
            {
                Console.WriteLine("Name does not matched");
            }









        }
    }
}