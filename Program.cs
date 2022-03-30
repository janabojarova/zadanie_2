using System;

namespace AgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your birthdate");
            int yearOfBirth = Int16.Parse(Console.ReadLine());
            int result = 2022 - yearOfBirth;
            if (result < 18)
            {
                Console.WriteLine("too young to drive");
            }
            else if (result > 18)
            {
                Console.WriteLine("drive carefully");
            }
            else if (result == 18)
            {
                Console.WriteLine("Congratulations, you may apply for your driving lisence now");
            }
        }
    }
}
