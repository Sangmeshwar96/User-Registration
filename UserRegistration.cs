﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingRegex
{
    class RegexValidation
    {
        public void CheckFirstName(string firstname)
        {
            string validateFirstName = "^[A-Z][a-z]{3,20}$";
            try
            {
                if (Regex.IsMatch(firstname, validateFirstName))
                    Console.WriteLine("First Name saved succesfull");
                else
                    Console.WriteLine("Invalid name!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void CheckLastName(string lastname)
        {
           string validateLastName = "^[A-Z][a-z]{3,20}$";
            try
            {
                if (Regex.IsMatch(lastname, validateLastName))
                    Console.WriteLine("Last Name saved succesfull");
                else
                    Console.WriteLine("Invalid name!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void CheckEmail(string email)
        {
            string validateEmail = "^[a-z][a-zA-Z0-9._-]{3,20}@[a-z]{3,10}.(com)$";
            try
            {
                if (Regex.IsMatch(email, validateEmail))
                    Console.WriteLine(" email validate succesfull");
                else
                    Console.WriteLine("Invalid email!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}