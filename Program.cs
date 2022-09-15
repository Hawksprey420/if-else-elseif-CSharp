// See https://aka.ms/new-console-template for more information
using System;
namespace CSharpRegistrationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
        
            {
                Console.WriteLine("Seems you're old enough");
            }
            else if (age >=17)
            {
                Console.WriteLine("Seems you need to get permission I guess?");
            }
            else
            {
                Console.WriteLine("You are not old enough");
            }

        }
    }
}
