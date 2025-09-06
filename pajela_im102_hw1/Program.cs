using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace im102_hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool isLoop = false;
            bool isPal = false;
            int counter = 0;
            string[] inputString = new string[100];
            string[] placeHolderString = new string[100];
            while (!isLoop)
            {
               
                Console.Write("Enter String: ");
                inputString[counter] = Console.ReadLine();
                if (inputString[counter] == "*") 
                {
                isLoop = false;
                }
                char[] tempChars = new char[inputString[counter].Length];
            string placeHolderLower = inputString[counter].ToLower();
               
                for (int i = 0; i <= inputString[counter].Length - 1; i++) 
                {
                    int reverseIndex = placeHolderLower.Length - 1 - i;
                   tempChars[i] = placeHolderLower[reverseIndex];

                }

                for (int i = 0; i <= inputString[counter].Length-1;i++) {
                    placeHolderString[counter] += tempChars[i];
                }

                if (placeHolderString[counter] == inputString[counter].ToLower()) {
                    isPal = true;
                }
                else { 
                
                }
                Console.WriteLine("Original String:     " + "Reversed String:     " + "Palindrome?");
                Console.WriteLine("  " +inputString[counter] + "\t\t\t" + placeHolderString[counter] + "\t\t    " + isPal);
                counter++;
                
            }

            Console.ReadKey();
        }
    }
}
