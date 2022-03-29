using System;


namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Email");
            string EmailSample = (Console.ReadLine());
            Pattern pattern = new Pattern();

            if (pattern.ValidateEmailSample(EmailSample))
            {
                Console.WriteLine("It's valid Email");
            }
           


            else
            {
                Console.WriteLine("It's not a valid Email");
            }









        }
    }
}