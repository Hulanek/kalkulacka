/**************************
* Název projektu: Kalkulačka
* Soubor: Operations.cs
* Autor: Martin Konečný xkonecm00@stud.fit.vutbr.cz
*
* Popis: Matematická knihovna
************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        * @param epsilon Určuje přesnost aproximace
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
    //[TestClass]
    public class OperationsTests
    {
        //[TestMethod]
        public double AddTest()
        {
            //arrange
            var op = new Operations();
            double num1 = 5;
            double num2 = 3;

            double expected = 8;

            //act
            op.Add(num1, num2);

            //assert
            double actually = op.Add(num1, num2);
            Assert.AreEqual(expected, actually, 0, "ADD DOES NOT ADD");
            /*
            if (op.Add(num1, num2) == ocekavano)
            {
                Console.WriteLine("ADD PASSED TEST");
                //return 0;
            }
            else
            {
                Console.WriteLine("ADD TEST FAILED");
            }*/
            return 0;
        }

        public void SubTest()
        {
            //arrange
            var op = new Operations();
            double num1 = 5;
            double num2 = 3;
            double expected = 2;
            //act

            //assert
            double actually = op.Sub(num1, num2);
            Assert.AreEqual(expected, actually, 0, "SUB FAILED TEST");
            /*if (expected == actually) Console.WriteLine();
            else Console.WriteLine();*/
        }
        public void DivTest()
        {
            var op = new Operations();
            double num1 = 12;
            double num2 = 3;
            double expected = 4;

            double actually = op.Div(num1, num2);
            double difference = expected - actually;
            Assert.AreEqual(expected, actually, 0, "DIV FAILED TEST");
            /*if (difference < 0.1) Console.WriteLine();
            else Console.WriteLine(difference);*/

        }
        public void MulTest()
        {
            var op = new Operations();
            double num1 = 5;
            double num2 = 3;
            double expected = 15;

            double actually = op.Mul(num1, num2);

            Assert.AreEqual(expected, actually, 0, "MUL FAILED TEST");

            /* if(expected == actually) Console.WriteLine();
            else Console.WriteLine();*/
        }

        public void ExpTest()
        {
            var op = new Operations();
            //ARRANGE
            double num1 = 5;
            double num2 = 3;
            double expected = 225;
            //ACT
            double actually = op.Exp(num1, num2);
            //ASSERT
            Assert.AreEqual(expected, actually, 0, "EXP FAILED TEST");
        }

        public void SqrTest()
        {
            var op = new Operations();
            //ARRANGE
            double num1 = 27;
            double num2 = 2;
            double expected = 9;
            //ACT
            double actually = op.Sqr(num1, num2);
            //ASSERT
            Assert.AreEqual(expected, actually, 0.1, "SQR FAILED THE TEST");


            /*double difference = expectation - actually;
            if (difference < 0.1) Console.WriteLine();
            else Console.WriteLine();*/
        }
        public void FacTest()
        {
            var op = new Operations();
            //ARRANGE
            double num1 = 5;
            double expected = 15;
            //ACT
            double actually = op.Fac(num1);
            //ASSERT
            Assert.AreEqual(expected, actually, 0, "FAC FAILED THE TEST");

            if (op.Fac(num1) == 15) Console.WriteLine();
            else Console.WriteLine();
        }

        public void AbsTest()
        {
            var op = new Operations();
            //ARRANGE
            double num1 = -5;
            double num2 = 5;
            double expected = 5;
            //ACT
            double actually1 = op.Abs(num1);
            double actually2 = op.Abs(num2);
            Assert.AreEqual(actually1, actually2, 0, "ABS FAILED TEST 1");
            Assert.AreEqual(actually1, expected, 0, "ABS FAILED TEST 2");
            /*
            if(op.Abs(num1) == 5 && op.Abs(num2) == 5) Console.WriteLine();
            else Console.WriteLine();
                       */

        }
    }
}
