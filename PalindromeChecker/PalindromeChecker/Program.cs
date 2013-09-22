using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * A Simple Program Used to See if a string is a Palindrome ( Reads the same Backwards and Forewards )
 */
namespace PalindromeChecker
{
    class Program
    {

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {




            Console.WriteLine("Welcome to the Palindrome Checker. Please insert your String:");
            String user_input = Console.ReadLine();

            String temp_checker = Reverse(user_input);




            if ( temp_checker.Equals(user_input) )
            {
                Console.WriteLine("The string you Entered is a Palindrome! ");
            }
            else
            {
                Console.WriteLine( "The string you Entered is not a Palindrome! " );
            }


            Console.ReadLine();


          

        }
    }
}
