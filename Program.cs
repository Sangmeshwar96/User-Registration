using System;

namespace UserRegistrationUsingRegex
{
    class Program
    {   

        static void Main(string[] args)
        {
            Console.WriteLine("* Welcome To User Registration Problem *");
            //Console.ReadLine();
            Console.WriteLine("Enter First name :");
            string fname = Console.ReadLine();
            RegexValidation regex = new RegexValidation();
            regex.CheckFirstName(fname);
            Console.WriteLine("Enter Last name :");
            string lname = Console.ReadLine();
            regex.CheckLastName(lname);
            Console.WriteLine("Enter Email id :");
            string email = Console.ReadLine();
            regex.CheckEmail(email);
            Console.WriteLine("Enter Mobile no. :");
            string mobile = Console.ReadLine();
            regex.CheckMobileNo(mobile);
        }
    }
}