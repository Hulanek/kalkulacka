using NUnit.Framework;

namespace KalkulackaTests
{
    public class kalkulatorTest
    {
        private Operations operations = new Operations();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddTest()
        {
            // Arrange
            //Operations operations = new Operations();
            int a = 5;
            int b = 10;

            // Act
            int result = operations.Add(a, b);

            // Assert
            Assert.AreEqual(15, result);
            //Assert.Pass();
        }
    }
}