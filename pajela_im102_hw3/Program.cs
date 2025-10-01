using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String: ");
            string input = Console.ReadLine();
            Console.WriteLine("");

            var splitInput = input.Split(',');
            for (int i = 0; i < splitInput.Length; i++)
            {
                splitInput[i] = splitInput[i].Trim();
            }

            var placeholder = string.Join("", splitInput);

            List<string> placeholder2 = new List<string>();
            string placeholder3 = "";

            for (int i = 0; i < placeholder.Length; i++)
            {
                char charplaceholder = placeholder[i];

                if (char.IsUpper(charplaceholder) && placeholder3 != "")
                {
                    placeholder2.Add(placeholder3);
                    placeholder3 = "";
                }

                placeholder3 += charplaceholder;
            }

            if (placeholder3 != "")
            {
                placeholder2.Add(placeholder3);
            }

         
            Console.WriteLine("");
            foreach (string word in placeholder2)
            {
                Count(word);
                Console.Write(" "); 
            }

            Console.ReadKey();
        }

     
        static void Count(string word)
        {
            Dictionary<string, int> dick = new Dictionary<string, int>();
            List<string> placeholderString = new List<string>();

            for (int i = 0; i < word.Length; i++)
            {
                string ch = word[i].ToString();
                if (dick.ContainsKey(ch))
                {
                    dick[ch]++;
                }
                else
                {
                    dick[ch] = 1;
                    placeholderString.Add(ch);
                }
            }

            foreach (var character in placeholderString)
            {
                Console.Write($"{character}: {dick[character]} ");
            }
        }
    }
}