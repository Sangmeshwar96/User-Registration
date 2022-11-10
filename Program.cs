using System;

namespace UserRegistrationUsingRegex
{
    class Program
    {   

        static void Main(string[] args)
        {
            Console.WriteLine("* Welcome To User Registration Problem *");
            Console.ReadLine();
            Console.WriteLine("Enter First name :");
            string fname = Console.ReadLine();
            RegexValidation regex = new RegexValidation();
            regex.CheckFirstName(fname);
        }
    }
}