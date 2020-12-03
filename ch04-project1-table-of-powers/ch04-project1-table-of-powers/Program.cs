using System;

namespace ch04_project1_table_of_powers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Squares and Cubes table");

            String choice = "y";
            while (choice.Equals("y"))
            {

                Console.Write("Enter a integer: ");
                int n = int.Parse(Console.ReadLine());

                

                Console.WriteLine("Number       Square         Cube");

                
            }

            Console.Write("Continue? ");
            choice = Console.ReadLine();
        }
    }
}
