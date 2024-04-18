using Operace;
namespace Tests
{

    [TestClass]
    public class OperationsTests
    {
        [TestMethod]
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
            return 0;
        }
        [TestMethod]
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

        }
        [TestMethod]
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
        [TestMethod]
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
        [TestMethod]
        public void ExpTest()
        {
            var op = new Operations();
            //ARRANGE
            double num1 = 5;
            double num2 = 3;
            double expected = 125;
            //ACT
            double actually = op.Exp(num1, num2);
            //ASSERT
            Assert.AreEqual(expected, actually, 0, "EXP FAILED TEST");
        }
        [TestMethod]
        public void SqrTest()
        {
            var op = new Operations();
            //ARRANGE
            double num1 = 3;
            double num2 = 27;
            double expected = 3;
            //ACT
            double actually = op.Sqr(num1, num2);
            //ASSERT
            Assert.AreEqual(expected, actually, 0.1, "SQR FAILED THE TEST");
        }
        [TestMethod]
        public void FacTest()
        {
            var op = new Operations();
            //ARRANGE
            double num1 = 5;
            double expected = 120;
            //ACT
            double actually = op.Fac(num1);
            //ASSERT
            Assert.AreEqual(expected, actually, 0, "FAC FAILED THE TEST");

        }
        [TestMethod]
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

        }
    }
}