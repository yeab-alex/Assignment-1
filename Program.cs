using System;
namespace Assignment_one
{
     class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("press 1 to reverse a string");
            System.Console.WriteLine("press 2 to find if the given string is a palindrome or not");
            System.Console.WriteLine("press 3 to reverse the order of words in a given string");
            System.Console.WriteLine("press 4 to count the occurrence of each character in a string");
            System.Console.WriteLine("press 5 to find all possible substrings of a given string");
            System.Console.WriteLine("press 6 to Find the second largest integer in an array using only one loop");
            System.Console.WriteLine("press 7 to Convert a two-dimensional array to a one-dimensional array");
            System.Console.WriteLine("press 8 to find the angle between hour and minute hands of a clock at any given time");
            System.Console.Write("choose a number: ");
            string input = Console.ReadLine();
            if (input == "1"){
                reverese.reverse();
            }
            else if (input == "2"){
                Palendrome.palendrome();
            }
            else if (input == "3"){
                revereseTheOrder.reverseTheOrder();
            }
            else if (input == "4"){
                Count.ocurrance();
            }
            else if (input == "5"){
                Possible.substring();
            }
            else if (input == "6"){
                LargestIntiger.secoundLargest();
            }
            else if (input == "7"){
                Dimension.dimension();
            }
            else if (input == "8"){
                Angle.angleOfTime();
            }
            else{
                System.Console.WriteLine("cose the correce number");
            }
            
        }
    }
}