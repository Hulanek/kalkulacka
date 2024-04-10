using System;
using System.Diagnostics;
using System.IO;

/*@author Jan Hrdina
 *@date 9.04.2024
 *@brief Program pro vypocet vyberove smerodatne odchylky ze vstupniho souboru
 * 
 * */

namespace Odchylka
{
    class Program
    {


        /*@brief Vypocet sumy cisel
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
        /*
         * @brief Vypocet sumy ctverce ze vzroce
         * @param nums[] = pole vstupnich cisel
         * @param deviation = aritmeticky prumer
         * @return Vraci sumu ctverce rozdilu jednotlivych polozek vuci prumeru
         */
        static double Sum_square(double[] nums, double deviation)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                double x = nums[i];

                x = x - deviation;
                x *= x;
                sum += x;
            }
            return sum;
        }
        static double Sum_square2(double[] nums, double deviation)
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

        /* 
         * @brief Vypocet n-te odmocniny
         * @param number = Cislo, ktere chceme odmocnit
         * @param n = cislo, ktere urcuje odmocninu
         * @param epsilon = Cislo, ktere urcuje maximalni chybu vypoctu
         * 
         */
        public static double CalculateNthRoot(double number, int n, double epsilon = 4)
        {
            if (number < 0 && n % 2 == 0)
            {
                throw new ArgumentException("Pro sudý index odmocniny musí být číslo nezáporné.");
            }

            double guess = number / (double)n; // Začínáme od 1/n vstupního čísla

            while (Math.Abs(number - Math.Pow(guess, n)) > epsilon)
            {
                guess = ((n - 1) * guess + number / Math.Pow(guess, n - 1)) / n; // Vylepšená hodnota odhadu
            }

            return guess;
        }
       static Operations operation = new Operations();

        static void Main(string[] args)
        {
            // Kontrola jestli byl zadan argument
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: ./stddev <filename>");
                return;
            }

            string filePath = args[0];

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
                /*
                 *@param num_length = pocet cisel 
                 *@param sum_num = suma cisel 
                 * @param x_line = aritmeticky prumer
                 * @param s_deleni = deleni na leve strane 1/N-1
                 * @param before_sqrt = pred omodcnovanim
                 * @param after_sqrt = po odmocnine
                 */
                double num_length = numbers.Length;
                
                double sum_num = (Program.Sum(numbers));
                double x_line = (1 / num_length) * sum_num;

                
                
                double s_deleni = 1 / (num_length-1);
                

                double before_sqrt = s_deleni * (Program.Sum_square(numbers, x_line));
                double before_sqrt2 = s_deleni * Program.Sum_square2(numbers, x_line);
                double after_sqrt = Program.CalculateNthRoot(before_sqrt, 2);
                Console.WriteLine(after_sqrt);
                Console.WriteLine(Program.CalculateNthRoot(before_sqrt2, 2));
                double cislo = 5000;
                double cislo2 = Program.CalculateNthRoot(cislo, 10);
                Console.WriteLine(cislo2);

              
                Program.operation.Sub(cislo, cislo2);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }



        }
    }
}
