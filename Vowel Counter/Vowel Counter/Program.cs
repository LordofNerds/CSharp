using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vowel_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the vowel counter ! Please enter your string:");

            String user_input = Console.ReadLine();

            user_input = user_input.ToLower();

            int count = 0;

            char[] cArray = user_input.ToCharArray();

            for(int i = cArray.Length - 1 ; i > -1; i--)
            {
                if( cArray[i] == 'a' || cArray[i] == 'e' || cArray[i] == 'i' || cArray[i] == 'o' || cArray[i] == 'u')
                {
                    count++;
                }
            }

            Console.WriteLine("The string contained " + count.ToString() + " vowels!");

            Console.ReadLine();
                    
        }
    }
}
