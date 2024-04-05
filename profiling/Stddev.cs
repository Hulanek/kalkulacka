using System;
using System.IO;
using System.Windows.Forms;


namespace Profiling
{
	class Program
	{
        static ulong SquareRoot(ulong N)
        {
            ulong x = (ulong)Math.Pow(2, (int)Math.Ceiling((double)NumBits(N) / 2));
            ulong y;

            while (true)
            {
                y = (x + (N / x)) / 2;
                if (y >= x)
                {
                    return x;
                }
                x = y;
            }
        }

        static int NumBits(ulong n)
        {
            int count = 0;
            while (n > 0)
            {
                n >>= 1;
                count++;
            }
            return count;
        }
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
        static double Sum_square(double[] nums, double n_square)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                double x = nums[i];
                 x *= x;
                x = x - n_square;
                sum += x;
            }
            return sum;
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
                double x_line = (1 / num_length);
                double sum_num = (Program.Sum(numbers));

                x_line = x_line * (Program.Sum(numbers));
                Console.WriteLine(x_line);

                double s_deleni = 1 / (num_length - 1);
                double sum_right = num_length * (x_line * x_line);

                double before_sqrt = s_deleni * (Program.Sum_square(numbers, sum_right));
                Console.WriteLine(Program.Sum_square(numbers, sum_right));
                
                
               



            }
            catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
             
            

        }
	}
}