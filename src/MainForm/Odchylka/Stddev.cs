using System;
using System.Diagnostics;
using System.IO;
using Operace;



/**
 * @author Jan Hrdina
 *@date 9.04.2024
 *@brief Program pro vypocet vyberove smerodatne odchylky ze vstupniho souboru
 * 
 */
namespace Odchylka
{
    class Stddev
    {


        /** Vypocet sumy cisel
         *@param nums = pole double cisel
         *@return Vraci sumu cisel
         */
        static double Sum(double[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                double x = nums[i];
                sum += x;
            }
            return sum;
        }
        /**
         * Vypocet sumy ctverce ze vzroce
         * @param nums[] = pole vstupnich cisel
         * @param deviation = aritmeticky prumer
         * @return Vraci sumu ctverce rozdilu jednotlivych polozek vuci prumeru
         */
        static double Sum_square(double[] nums, double deviation)
        {
            deviation *= deviation;
            double sum_length = nums.Length;
            double sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                double x = nums[i];
                x *= x;
                sum += x;
            }
            return sum - (sum_length*deviation);
        }
  
         
        static void Main(string[] args)
        {
            // Kontrola jestli byl zadan argument
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: ./stddev <filename>");
                return;
            }

            string filePath = args[0];
            Operations operation = new Operations();

            try
            {
                // Precteni celeho kontentu
                string fileContent = File.ReadAllText(filePath);

                // Rozdeleni obsahu, jestlize byla pouzita mezera,tabulator nebo konec radku
                string[] numberStrings = fileContent.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                // Prevedeni stringu na cislo
                double[] numbers = new double[numberStrings.Length];
                for (int i = 0; i < numberStrings.Length; i++)
                {
                    if (double.TryParse(numberStrings[i], out double number))
                    {
                        numbers[i] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid number format: {numberStrings[i]}");
                        
                    }
                }
                
                double num_length = numbers.Length;
                double sum_num = (Stddev.Sum(numbers));
                double x_line = operation.Mul(operation.Div(1, num_length), sum_num);
                double s_deleni = operation.Div(1, operation.Sub(num_length, 1));
               
                double before_sqrt = s_deleni * Stddev.Sum_square(numbers, x_line);
                double after_sqrt = operation.Sqr(2,before_sqrt);
                Console.WriteLine(after_sqrt);
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
