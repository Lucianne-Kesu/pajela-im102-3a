using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pajela_im102_3a_seatwork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String: ");
            string numInput = "";
            numInput = Console.ReadLine();
            string[] splitInput = numInput.Split(' ');

            //for (int i = 0; i < splitInput.Length; i++) 
            //{
            //    if (splitInput[i] == " ") 
            //    {
            //        Console.Write("Test");
            //    }
            //}
            int counter = 1;
            foreach (string str in numInput.Split(' '))
            {
                if (string.IsNullOrWhiteSpace(str))
                {
                    
                    continue;
                   
                }
                else
                {

                    Console.Write($"{counter}. {str} \t");
                    Console.WriteLine(primeCompositeChecker(int.Parse(str)) == true ? "Composite" : "Prime");
                   
                }
                counter+=1;
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Enter Currency in ($): ");
           string dollar = Console.ReadLine();
            string[] dollarSplit = dollar.Split(',');
            double yen = 0;
            double peso = 0;
            
            Console.WriteLine("Dollar($)\tPhil Peso(P)\tJpn Yen(Y)");
            for (int i = 0; i < dollarSplit.Length; i++)
            {

                var Converted = curencyConverter(double.Parse(dollarSplit[i]));
                Console.WriteLine($"{dollarSplit[i]}\t\t{Converted.dollarToPeso}\t\t{Converted.dollarToYen}");
            }
            Console.ReadKey();
        }
        static bool primeCompositeChecker(int numberForChecking)
        {
            int counter = 2;
            int factorCounter = 0;
            int squareRootOfNumber = (int)Math.Ceiling(Math.Sqrt(numberForChecking));
            for (int i = 1; i < squareRootOfNumber; i++)
            {
                if (numberForChecking % counter == 0)
                {
                    factorCounter += 2;
                }
                if (squareRootOfNumber * squareRootOfNumber == numberForChecking)
                {
                    factorCounter++;
                };
            }
            if (numberForChecking < 2 || factorCounter < 2)
            {
                return false;
            }
            else if (factorCounter > 2)
            {
                return true;
            }
            return true;
        }

        static (double dollarToPeso,double dollarToYen) curencyConverter(double dollar) {
            double Peso = 0;
            double Yen = 0;
            Peso = dollar * 57.17;
            Yen = dollar * 146.67;
            return (Peso, Yen);
        }

    }
}
