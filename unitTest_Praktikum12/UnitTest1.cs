using NUnit.Framework;
using praktikum12;

namespace praktikum12.Tests
{
    [TestFixture]
    public class Testing12Tests
    {
        [Test]
        public void DetermineGrade_WhenScoreIs95_ReturnsA()
        {
            // Arrange
            int score = 95;
            string expected = "A";
            
            // Act
            string actual = Testing12.DetermineGrade(score);
            
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DetermineGrade_WhenScoreIs90_ReturnsA()
        {
            // Arrange
            int score = 90;
            string expected = "A";
            
            // Act
            string actual = Testing12.DetermineGrade(score);
            
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DetermineGrade_WhenScoreIs85_ReturnsB()
        {
            // Arrange
            int score = 85;
            string expected = "B";
            
            // Act
            string actual = Testing12.DetermineGrade(score);
            
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DetermineGrade_WhenScoreIs75_ReturnsC()
        {
            // Arrange
            int score = 75;
            string expected = "C";
            
            // Act
            string actual = Testing12.DetermineGrade(score);
            
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DetermineGrade_WhenScoreIs65_ReturnsD()
        {
            // Arrange
            int score = 65;
            string expected = "D";
            
            // Act
            string actual = Testing12.DetermineGrade(score);
            
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DetermineGrade_WhenScoreIs55_ReturnsE()
        {
            // Arrange
            int score = 55;
            string expected = "E";
            
            // Act
            string actual = Testing12.DetermineGrade(score);
            
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DetermineGrade_WhenScoreIs45_ReturnsF()
        {
            // Arrange
            int score = 45;
            string expected = "F";
            
            // Act
            string actual = Testing12.DetermineGrade(score);
            
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DetermineGrade_WhenScoreIs30_ReturnsF()
        {
            // Arrange
            int score = 30;
            string expected = "F";
            
            // Act
            string actual = Testing12.DetermineGrade(score);
            
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DetermineGrade_WhenScoreIs101_ReturnsWhat()
        {
            int score = 101;
            string actual = Testing12.DetermineGrade(score);
            Assert.IsNull(actual);
        }
    }
}
