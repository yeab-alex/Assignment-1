using System;
namespace Assignment_one
{
    class reverese
    {
        public static void reverse()
        {
            Console.Write("Enter a String : ");
            string mainString = Console.ReadLine();
            string reverseString = string.Empty;
            foreach (char c in mainString)
            {
                reverseString = c + reverseString;
            }
            Console.Write($"Reverse String is : {reverseString} ");
            Console.ReadLine();
        }
    }
}
    
           
