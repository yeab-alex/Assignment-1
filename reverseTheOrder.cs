using System;
namespace Assignment_one
{
    class revereseTheOrder
    {
        public static void reverseTheOrder()
        {
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();
            
            string reverseWordString = string.Join(" ", originalString
            .Split(' ')
            .Select(x => new String(x.Reverse().ToArray())));

            string WordString = string.Empty;
            foreach (char c in reverseWordString)
            {
                WordString = c + WordString;
            }
            Console.Write($"Reverse Word String is : {WordString} ");
            Console.ReadLine();
        } 
    }
}
    
           
