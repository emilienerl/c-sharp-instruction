﻿using System;

namespace ch02_project1_student_registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration Form");

            Console.WriteLine("Enter first name: ");
            String firstName = Console.ReadLine();

            Console.WriteLine("Enter last name: ");
            String lastName = Console.ReadLine();

            Console.WriteLine("Enter year of birth: ");
            String birthYear = Console.ReadLine();

            Console.WriteLine("Welcome " + firstName +" " + lastName + "!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " + firstName + " " + "* " + birthYear);
        }
    }
}
