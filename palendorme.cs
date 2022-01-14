using System;
namespace Assignment_one
{
    class Palendrome{
        public static void palendrome(){
              Console.Write("Enter a string to Check Palindrome : ");
            string name = Console.ReadLine();
            string reverse = string.Empty;

            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }

            if (name == reverse)
            {
                Console.WriteLine($"{name} is Palindrome");
            }
            else
            {
                Console.WriteLine($"{name} is not Palindrome");
            }
            Console.ReadKey();
        }
    }
}