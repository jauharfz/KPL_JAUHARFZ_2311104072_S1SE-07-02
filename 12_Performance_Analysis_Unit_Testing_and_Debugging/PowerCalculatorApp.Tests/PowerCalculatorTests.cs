namespace PowerCalculatorApp.Tests;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using jmmodul12_2311104072;

[TestClass]
public class PowerCalculatorTests
{
  private MainForm _calculator;

  [TestInitialize]
  public void Setup()
  {
      _calculator = new MainForm();
  }

  [TestCleanup]
  public void Cleanup()
  {
      _calculator?.Dispose();
  }

  #region Rule i: If b is 0, always return 1 (even if a is 0)

  [TestMethod]
  public void CalculatePowerValue_ExponentZero_ReturnsOne()
  {
      // Arrange & Act & Assert
      Assert.AreEqual(1, _calculator.CalculatePowerValue(5, 0));
      Assert.AreEqual(1, _calculator.CalculatePowerValue(0, 0));
      Assert.AreEqual(1, _calculator.CalculatePowerValue(100, 0));
      Assert.AreEqual(1, _calculator.CalculatePowerValue(-5, 0));
  }

  #endregion

  #region Rule ii: If b is negative, return -1

  [TestMethod]
  public void CalculatePowerValue_NegativeExponent_ReturnsMinusOne()
  {
      // Arrange & Act & Assert
      Assert.AreEqual(-1, _calculator.CalculatePowerValue(2, -1));
      Assert.AreEqual(-1, _calculator.CalculatePowerValue(5, -3));
      Assert.AreEqual(-1, _calculator.CalculatePowerValue(10, -10));
  }

  #endregion

  #region Rule iii: If b > 10 or a > 100, return -2

  [TestMethod]
  public void CalculatePowerValue_ExponentGreaterThanTen_ReturnsMinusTwo()
  {
      // Arrange & Act & Assert
      Assert.AreEqual(-2, _calculator.CalculatePowerValue(2, 11));
      Assert.AreEqual(-2, _calculator.CalculatePowerValue(5, 15));
      Assert.AreEqual(-2, _calculator.CalculatePowerValue(3, 20));
  }

  [TestMethod]
  public void CalculatePowerValue_BaseGreaterThanHundred_ReturnsMinusTwo()
  {
      // Arrange & Act & Assert
      Assert.AreEqual(-2, _calculator.CalculatePowerValue(101, 2));
      Assert.AreEqual(-2, _calculator.CalculatePowerValue(150, 3));
      Assert.AreEqual(-2, _calculator.CalculatePowerValue(200, 1));
  }

  [TestMethod]
  public void CalculatePowerValue_BothOutOfBounds_ReturnsMinusTwo()
  {
      // Arrange & Act & Assert
      Assert.AreEqual(-2, _calculator.CalculatePowerValue(101, 11));
      Assert.AreEqual(-2, _calculator.CalculatePowerValue(150, 20));
  }

  #endregion

  #region Rule iv: If result exceeds max positive integer, return -3

  [TestMethod]
  public void CalculatePowerValue_ResultOverflow_ReturnsMinusThree()
  {
      // These values ACTUALLY cause overflow (tested and verified):
      // long.MaxValue = 9,223,372,036,854,775,807
      
      // 100^10 = 100,000,000,000,000,000,000 > long.MaxValue ✓
      Assert.AreEqual(-3, _calculator.CalculatePowerValue(100, 10));
      
      // 99^10 = 90,438,207,500,880,449,001 > long.MaxValue ✓
      Assert.AreEqual(-3, _calculator.CalculatePowerValue(99, 10));
      
      // 95^10 = 59,873,693,923,837,890,625 > long.MaxValue ✓
      Assert.AreEqual(-3, _calculator.CalculatePowerValue(95, 10));
      
      // 90^10 = 34,867,844,010,000,000,000 > long.MaxValue ✓
      Assert.AreEqual(-3, _calculator.CalculatePowerValue(90, 10));
      
      // 80^10 = 10,737,418,240,000,000,000 > long.MaxValue ✓
      Assert.AreEqual(-3, _calculator.CalculatePowerValue(80, 10));
  }

  [TestMethod]
  public void CalculatePowerValue_ResultNoOverflow_ReturnsCorrectValue()
  {
      // These values do NOT cause overflow (tested and verified):
      
      // 70^10 = 2,824,752,490,000,000,000 < long.MaxValue ✓
      Assert.IsTrue(_calculator.CalculatePowerValue(70, 10) > 0);
      
      // 64^10 = 1,152,921,504,606,846,976 < long.MaxValue ✓
      Assert.AreEqual(1152921504606846976L, _calculator.CalculatePowerValue(64, 10));
      
      // 60^10 = 604,661,760,000,000,000 < long.MaxValue ✓
      Assert.IsTrue(_calculator.CalculatePowerValue(60, 10) > 0);
      
      // 50^10 = 97,656,250,000,000,000 < long.MaxValue ✓
      Assert.IsTrue(_calculator.CalculatePowerValue(50, 10) > 0);
  }

  #endregion

  #region Valid calculations

  [TestMethod]
  public void CalculatePowerValue_ValidInputs_ReturnsCorrectResult()
  {
      // Arrange & Act & Assert
      Assert.AreEqual(1, _calculator.CalculatePowerValue(1, 5));
      Assert.AreEqual(8, _calculator.CalculatePowerValue(2, 3));
      Assert.AreEqual(25, _calculator.CalculatePowerValue(5, 2));
      Assert.AreEqual(81, _calculator.CalculatePowerValue(3, 4));
      Assert.AreEqual(32, _calculator.CalculatePowerValue(2, 5));
      Assert.AreEqual(1000, _calculator.CalculatePowerValue(10, 3));
  }

  [TestMethod]
  public void CalculatePowerValue_PowerOfOne_ReturnsBase()
  {
      // Arrange & Act & Assert
      Assert.AreEqual(5, _calculator.CalculatePowerValue(5, 1));
      Assert.AreEqual(10, _calculator.CalculatePowerValue(10, 1));
      Assert.AreEqual(99, _calculator.CalculatePowerValue(99, 1));
  }

  [TestMethod]
  public void CalculatePowerValue_BaseZero_ReturnsZero()
  {
      // Arrange & Act & Assert
      Assert.AreEqual(0, _calculator.CalculatePowerValue(0, 1));
      Assert.AreEqual(0, _calculator.CalculatePowerValue(0, 5));
      Assert.AreEqual(0, _calculator.CalculatePowerValue(0, 10));
  }

  #endregion

  #region Edge cases

  [TestMethod]
  public void CalculatePowerValue_BoundaryValues_WorksCorrectly()
  {
      // Test boundary values
      Assert.AreEqual(1024, _calculator.CalculatePowerValue(2, 10)); // Should work
      Assert.AreEqual(100, _calculator.CalculatePowerValue(100, 1)); // Should work
      Assert.AreEqual(-2, _calculator.CalculatePowerValue(100, 11)); // Should fail (exponent > 10)
      Assert.AreEqual(-2, _calculator.CalculatePowerValue(101, 1)); // Should fail (base > 100)
  }

  [TestMethod]
  public void CalculatePowerValue_NegativeBase_WorksCorrectly()
  {
      // Test negative base values
      Assert.AreEqual(-8, _calculator.CalculatePowerValue(-2, 3));
      Assert.AreEqual(16, _calculator.CalculatePowerValue(-2, 4));
      Assert.AreEqual(-32, _calculator.CalculatePowerValue(-2, 5));
  }

  [TestMethod]
  public void CalculatePowerValue_OverflowBoundaryTesting()
  {
      // Test the exact boundary between overflow and no overflow
      
      // These should NOT overflow:
      Assert.IsTrue(_calculator.CalculatePowerValue(75, 10) > 0, "75^10 should not overflow");
      Assert.IsTrue(_calculator.CalculatePowerValue(70, 10) > 0, "70^10 should not overflow");
      
      // These SHOULD overflow:
      Assert.AreEqual(-3, _calculator.CalculatePowerValue(80, 10), "80^10 should overflow");
      Assert.AreEqual(-3, _calculator.CalculatePowerValue(85, 10), "85^10 should overflow");
  }

  #endregion
}