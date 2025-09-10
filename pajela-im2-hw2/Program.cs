using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pajela_im2_hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<double>> doubleNumbers = new List<List<double>>() /*{ new List<double> {}, new List<double> { } }*/;

            Console.Write("Enter Row: ");
            int rowAgain = int.Parse(Console.ReadLine());
            Console.Write("Enter Column: ");
            int columnAgain = int.Parse(Console.ReadLine());
            double sum = 0;
            double average = 0;
          
            for (int i = 0; i < rowAgain; i++)
            {
                List<double> placeholderRow = new List<double>();
                Console.WriteLine($"Enter Row {i + 1}: ");


                for (int j = 0; j < columnAgain; j++)
                {
                    Console.Write("Enter Number " + (j + 1) + ": ");
                    double placeholder = double.Parse(Console.ReadLine());
                    placeholderRow.Add(placeholder);
                    sum += placeholder;

                }
                doubleNumbers.Add(placeholderRow);
               
            }
            Console.WriteLine("The numbers are::");
            for (int i = 0; i < doubleNumbers.Count; i++)
            {
             

                for (int j = 0; j < doubleNumbers[i].Count; j++)
                {

                    Console.Write(doubleNumbers[i][j].ToString("0.0#") + " ");

                }
                Console.WriteLine();
            }

            Console.Write($"Sum:{sum.ToString("0.0#")} \t");
            average = sum / (rowAgain + columnAgain);
            Console.WriteLine($"average:{average.ToString("0.0#")}");




            Console.ReadKey();
        }
    }
}
