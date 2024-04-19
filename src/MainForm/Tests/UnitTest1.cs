using Operace;
namespace Tests
{

    [TestClass]
    public class OperationsTests
    {
        [TestMethod]

        public void AddTest()
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
            Assert.AreEqual(expected, actually, 0, "ADD DOES NOT ADD +");

            //ARRANGE
            num1 = 5;
            num2 = 0;
            expected = 5;
            //ACT
            actually = op.Add(num1, num2);
            //ASSERT
            Assert.AreEqual(expected, actually, 0, "ADD FAILED TEST 0");

            //ARRANGE
            num1 = 5;
            num2 = -3;
            expected = 2;
            //ACT
            actually = op.Add(num1, num2);
            //ASSERT
            Assert.AreEqual(expected, actually, 0, "ADD FAILED TEST -");
        }
        [TestMethod]
        public void SubTest()
        {

            //ARRANGE

            var op = new Operations();
            double num1 = 5;
            double num2 = 3;
            double expected = 2;

            //ACT
            double actually = op.Sub(num1, num2);
            //ASSERT
            Assert.AreEqual(expected, actually, 0, "SUB FAILED TEST +");

            //ARRANGE
            num1 = 5;
            num2 = -3;
            expected = 8;
            //ACT
            actually = op.Sub(num1, num2);
            //ASSERT
            Assert.AreEqual(expected, actually, 0, "SUB FAILED TEST -");

            //ARRANGE
            num1 = 5;
            num2 = 0;
            expected = 5;
            //ACT
            actually = op.Sub(num1, num2);
            //ASSERT
            Assert.AreEqual(expected, actually, 0, "SUB FAILED TEST 0");

        }
        [TestMethod]
        public void DivTest()
        {
            //ASSERT
            var op = new Operations();
            double num1 = 12;
            double num2 = 3;
            double expected = 4;

            //ACT
            double actually = op.Div(num1, num2);
            //ASSERT
            Assert.AreEqual(expected, actually, 0, "DIV FAILED TEST +");

            //ARRANGE
            num1 = 15;
            num2 = -3;
            expected = -5;
            //ACT
            actually = op.Div(num1, num2);
            //ASSERT
            Assert.AreEqual(expected, actually, 0, "DIV FAILED TEST -");
            
            /*
            //ARRANGE
            num1 = 5;
            num2 = 0;
            expected = 0;
            //ACT
            actually = op.Div(num1, num2);
            //ASSERT
            Assert.AreEqual(expected, actually, 0, "DIV FAILED TEST 0");*/
        }
        [TestMethod]
        public void MulTest()
        {

            //ARRANGE

            var op = new Operations();
            double num1 = 5;
            double num2 = 3;
            double expected = 15;

            //ACT
            double actually = op.Mul(num1, num2);
            //ASSERT
            Assert.AreEqual(expected, actually, 0, "MUL FAILED TEST +");

            //ARRANGE
            num1 = 5;
            num2 = -3;
            expected = -15;
            //ACT
            actually = op.Mul(num1, num2);
            //ASSERT
            Assert.AreEqual(expected, actually, 0, "MUL FAILED TEST -");

            //ARRANGE
            num1 = 15;
            num2 = 0.3;
            expected = 4.5;
            //ACT
            actually = op.Mul(num1, num2);
            //ASSERT
            Assert.AreEqual(expected, actually, 0, "MUL FAILED TEST <1");

            //ARRANGE
            num1 = 5;
            num2 = 0;
            expected = 0;
            //ACT
            actually = op.Mul(num1, num2);
            //ASSERT
            Assert.AreEqual(expected, actually, 0, "MUL FAILED TEST 0");



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

            Assert.AreEqual(expected, actually, 0, "EXP FAILED TEST +");

            //ARRANGE
            num1 = 5;
            num2 = 0;
            expected = 1;
            //ACT
            actually = op.Exp(num1, num2);

            //ASSERT
            Assert.AreEqual(expected, actually, 0, "EXP FAILED TEST 0");

            //ARRANGE
            num1 = 5;
            num2 = -3;
            expected = 0.008;
            //ACT
            actually = op.Exp(num1, num2);

            //ASSERT
            Assert.AreEqual(expected, actually, 0, "EXP FAILED TEST -"); 

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

            Assert.AreEqual(expected, actually, 0.001, "SQR FAILED THE TEST +");

            //ARRANGE
            num1 = 1;
            num2 = 5;
            expected = 5;
            //ACT
            actually = op.Sqr(num1, num2);
            //ASSERT
            Assert.AreEqual(expected, actually, 0.001, "SQR FAILED TEST 0");

            //ARRANGE
            num1 = 5;
            num2 = 14;
            expected = 1.695218;
            //ACT
            actually = op.Sqr(num1, num2);
            //ASSERT
            Assert.AreEqual(expected, actually, 0.0001, "SQR FAILED TEST +++");

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

            //ARRANGE
            num1 = 14;
            expected = 87178291200;
            //ACT
            actually = op.Fac(num1);
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

            //ASSERT
            Assert.AreEqual(actually1, actually2, 0, "ABS FAILED TEST +");
            Assert.AreEqual(actually1, expected, 0, "ABS FAILED TEST -");

            //ARRANGE
            num1 = 0;
            expected = 0;
            //ACT
            actually1 = op.Abs(num1);
            //ASSERT
            Assert.AreEqual(expected, actually1, 0, "FAC FAILED THE TEST");


        }
    }
}