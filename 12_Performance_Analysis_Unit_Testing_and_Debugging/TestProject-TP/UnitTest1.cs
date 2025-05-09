using NUnit.Framework;
using tpmodul12_2311104072;

namespace TestProject_TP
{
    [TestFixture]
    public class FindNumberSignTests
    {
        private Form1 _form;

        [SetUp]
        public void Setup()
        {
            _form = new Form1();
        }

        [TearDown]
        public void TearDown()
        {
            // Dispose form setelah setiap test selesai
            _form?.Dispose();
        }

        [Test]
        public void FindNumberSign_PositiveNumber_ReturnsPowerOfTwo()
        {
            // Arrange
            int input = 5;
            string expected = "25"; // 5^2 = 25

            // Act
            string result = _form.FindNumberSign(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void FindNumberSign_NegativeNumber_ReturnsPowerOfTwo()
        {
            // Arrange
            int input = -3;
            string expected = "9"; // (-3)^2 = 9

            // Act
            string result = _form.FindNumberSign(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void FindNumberSign_Zero_ReturnsCannotPowerMessage()
        {
            // Arrange
            int input = 0;
            string expected = "Cannot Power 0";

            // Act
            string result = _form.FindNumberSign(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}