using System;


namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mobile Number");
            string MobileNumber = (Console.ReadLine());
            Pattern pattern = new Pattern();

            if (pattern.ValidateMobileFormat(MobileNumber))
            {
                Console.WriteLine("Mobile Number is valid");
            }
           

            else
            {
                Console.WriteLine("Please enter a valid Mobile Number. ");
            }









        }
    }
}