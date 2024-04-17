//hlavička
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* @file Operations.cs
*
* @brief Matematická knihovna
* @author Martin Konečný
*/

namespace MainForm
{
    public class Operations
    {
        /**
        * Funkce pro součet dvou čísel
        * 
        * @param num1 První operand pro operaci - sčítanec
        * @param num2 Druhý operand pro operaci - sčítanec
        * @return Vrací výsledek operace - součet
        */
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        /**
        * Funkce pro rozdíl dvou čísel
        * 
        * @param num1 První operand pro operaci - menšenec
        * @param num2 Druhý operand pro operaci - menšitel
        * @return Vrací výsledek operace - rozdíl
        */
        public double Sub(double num1, double num2)
        {
            return num1 - num2;
        }


        /**
        * Funkce pro rozdíl dvou čísel
        * 
        * @param num1 První operand pro operaci - dělenec
        * @param num2 Druhý operand pro operaci - dělitel
        * @return Vrací výsledek operace - podíl
        */
        public double Div(double num1, double num2)
        {
            return num1 / num2;
        }

        /**
        * Funkce pro součin dvou čísel
        * 
        * @param num1 První operand pro operaci - činitel
        * @param num2 Druhý operand pro operaci - činitel
        * @return Vrací výsledek operace - součin
        */
        public double Mul(double num1, double num2)
        {
            return num1 * num2;
        }
        
        /**
        * Funkce umocňování s přirozenými exponenty
        * 
        * @param num1 První operand pro operaci - základ
        * @param num2 Druhý operand pro operaci - exponent
        * @return Vrací výsledek operace
        */
        public double Exp(double num1, double num2)
        {
            double baseNum = num1;
            if (num2 == 0)
            {
                return 1;
            }
            for (int i = 0; i < num2 - 1; i++)
            {
                num1 *= baseNum;
            }
            return num1;
        }

        /**
        * Funkce obecné odmocniny s přirozenýni exponenty
        * 
        * @param num1 První operand pro operaci - základ
        * @param num2 Druhý operand pro operaci - exponent
        * @return Vrací výsledek operace
        */
        public double Sqr(double num1, double num2, double epsilon = 0.000001)
        {
            double guess = num2 / num1; // Začínáme od 1/n vstupního čísla
            while (Math.Abs(num2 - Math.Pow(guess, num1)) > epsilon)
            {
                guess = ((num1- 1) * guess + num2 / Math.Pow(guess, num1- 1)) / num1; // Vylepšená hodnota odhadu
            }
            return guess;
            
        }

        /**
        * Funkce faktoriálu
        * @param num1 Operand pro operaci - základ
        * @return Vrací výsledek operace
        */
        public double Fac(double num1)
        {
            double facCounter = (double)num1;
            num1 = 1;
            for ( double i = facCounter; i > 0; i--)
            {
                num1 = num1 * i;
            }
            return num1;
        }

        /**
        * Funkce absolutní hodnoty
        * @param num1 Operand pro operaci - základ
        * @return Vrací výsledek operace
        */
        public double Abs(double num1)
        {
            if (num1 < 0)
            {
                num1 = -num1;
            }
            return num1;
        }
    }
}
