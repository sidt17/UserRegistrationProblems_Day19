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

            if (pattern.ValidatePassword(password))
            {
                Console.WriteLine("It's valid password");
            }
            else if (password.Length<8)
            {
                Console.WriteLine("Please enter atleast 8 characters");
            }


            else
            {
                Console.WriteLine("It's not a valid password");
            }









        }
    }
}