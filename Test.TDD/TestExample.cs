public class Calculator
{
    public int Add(int a, int b)
    {
        return 0;
    }

    public int Subtract(int a, int b)
    {
        return 0;
    }
}

[TestClass]
public class CalculatorTests
{
    #region Add Tests
    [TestMethod]
    public void Add_TwoNumbers_ReturnsSum_OKCase()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Add(3, 5);

        // Assert
        Assert.AreEqual(8, result);
    }

    [TestMethod]
    public void Add_TwoNumbers_ReturnsSum_KOCase()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Add(3, 5);

        // Assert
        Assert.AreNotEqual(16, result);
    }
    #endregion

    #region Substract Tests
    [TestMethod]
    public void Subtract_TwoNumbers_ReturnsDifference_OKCase()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Subtract(10, 4);

        // Assert
        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void Subtract_TwoNumbers_ReturnsDifference_KOCase()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Subtract(10, 4);

        // Assert
        Assert.AreNotEqual(16, result);
    }
    #endregion
}
