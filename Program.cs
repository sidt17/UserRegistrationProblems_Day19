using System;


namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Valid Email");
            string ValidEmail = Console.ReadLine();
            Pattern pattern = new Pattern();

            if (pattern.ValidateEmail(ValidEmail))
            {
                Console.WriteLine("Email is valid");
            }
           

            else
            {
                Console.WriteLine("Email is not valid");
            }









        }
    }
}