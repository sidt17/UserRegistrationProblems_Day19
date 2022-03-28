using System;


namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your password");
            string password = (Console.ReadLine());
            Pattern pattern = new Pattern();

            if (pattern.ValidateMobileFormat(password))
            {
                Console.WriteLine("It is a valid password");
            }
           

            else
            {
                Console.WriteLine("Invalid Password");
            }









        }
    }
}