﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration!");

            var user = new User();
           // AskFirstName(user);
           // AskLastName(user);
            AskEmail(user);


        }

        public static void AskFirstName(User user)
        {
            Console.Write("Enter First Name :");
            var firstName = Console.ReadLine();
            if (user.ValidateFirstName(firstName))
                user.firstName = firstName;
            else
                Console.WriteLine("Invalid first name. " +
                    "It should have minimum 3 letters and only first letter as capital");
        }
        public static void AskLastName(User user)
        {
            Console.Write("Enter Last Name :");
            var lastName = Console.ReadLine();
            if (user.ValidateLastName(lastName))
                user.lastName = lastName;
            else
                Console.WriteLine("Invalid Last name. " +
                    "It should have minimum 3 letters and only first letter as capital");
        }

        public static void AskEmail(User user)
        {
            Console.Write("Enter Email :");
            var email = Console.ReadLine();
            if (user.ValidateEmail(email))
                user.email = email;
            else
                Console.WriteLine("Invalid email. " +
                    "It should be in the correct format E.g. abc.xyz@bl.co.in");
        }
    }
}
