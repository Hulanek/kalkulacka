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
    }
}
