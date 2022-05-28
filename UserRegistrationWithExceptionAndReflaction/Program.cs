﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationWithExceptionAndReflaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Validation validation = new Validation(); // Creating a object of Validation class
            Console.WriteLine("MSTesting");
            Console.WriteLine("\nWelcome to C# User's Information validation using Regular Expression");
        //User First name validation            
        Firstname:
            Console.WriteLine("\nNote : Your first name should start with Capital Letter only and has minimum 3 Character and no space between letters");
            Console.WriteLine("\n\nEnter your first name : ");
            string fName = Console.ReadLine(); //storing first name entered by user in variable
            string checkFirstName = validation.FirstNameValidation(fName); //Calling method to check first name is valid or not with argument
            if(checkFirstName != "Input is valid")//If not valid then ask user to enter first name again
                goto Firstname;

            // User Last name validation
            Lastname:
            Console.WriteLine("\nNote : Your Last name should start with Capital Letter only and has minimum 3 Character and no space between letters");
            Console.WriteLine("\n\nEnter your last name : ");
            string lName = Console.ReadLine(); //storing last name entered by user in variable
            string checkLastName = validation.LastNameValidation(lName); //Calling method to check last name is valid or not with argument
            if (checkLastName == "Input is valid")//If not valid then ask user to enter last name again
                goto Lastname;
        }
    }
}
