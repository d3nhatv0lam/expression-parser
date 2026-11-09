using ExpressionParser.Models;

namespace ExpressionParser.Tests;

public class ExpressionCalculatorTests
{
    [Theory]
    [InlineData("2 * 3 + 6", 12.0)]
    [InlineData("(2 + 3) * 6", 30.0)]
    [InlineData("2 * (3 + 6)", 18.0)]
    [InlineData("2 * 3 * 4", 24.0)]
    [InlineData("2 + 3 + 4", 9.0)]
    [InlineData("0 + 0", 0.0)]
    [InlineData("123", 123.0)]
    public void Calculate_Grammar1_ReturnsCorrectResult(string expression, double expected)
    {
        double actual = ExpressionCalculator.Calculate(expression);
        Assert.Equal(expected, actual, precision: 6);
    }

    [Theory]
    [InlineData("8 - 3 - 2", 3.0)]
    [InlineData("24 / 4 / 2", 3.0)]
    [InlineData("10 - 4 + 2", 8.0)]
    [InlineData("100 / 5 * 2", 40.0)]
    [InlineData("2 + 3 * 4", 14.0)]
    [InlineData("10 - 6 / 2", 7.0)]
    [InlineData("(10 - 6) / 2", 2.0)]
    [InlineData("((10 - (2 + 3)) * 4) / 2", 10.0)]
    [InlineData("10 - 2 * 3 + 4 / 2", 6.0)]
    public void Calculate_Grammar2_FourBasicOperators_ReturnsCorrectResult(string expression, double expected)
    {
        double actual = ExpressionCalculator.Calculate(expression);
        Assert.Equal(expected, actual, precision: 6);
    }

    [Theory]
    [InlineData("3.5 + 2.5", 6.0)]
    [InlineData("7.5 / 2.5", 3.0)]
    [InlineData("10 / 4", 2.5)]
    [InlineData("0.25 * 4", 1.0)]
    public void Calculate_DecimalNumbers_ReturnsCorrectResult(string expression, double expected)
    {
        double actual = ExpressionCalculator.Calculate(expression);
        Assert.Equal(expected, actual, precision: 6);
    }

    [Theory]
    [InlineData("-5 + 3", -2.0)]
    [InlineData("+7 * 2", 14.0)]
    [InlineData("-(3 + 2)", -5.0)]
    [InlineData("2 * (-3)", -6.0)]
    [InlineData("-(-10)", 10.0)]
    public void Calculate_UnaryOperators_ReturnsCorrectResult(string expression, double expected)
    {
        double actual = ExpressionCalculator.Calculate(expression);
        Assert.Equal(expected, actual, precision: 6);
    }

    [Theory]
    [InlineData("   2   *   ( 3   +  6 )  / 4  ", 4.5)]
    [InlineData("\t 10 \n - 4 \r\n ", 6.0)]
    public void Calculate_WithVariousWhitespace_ReturnsCorrectResult(string expression, double expected)
    {
        double actual = ExpressionCalculator.Calculate(expression);
        Assert.Equal(expected, actual, precision: 6);
    }

    [Fact]
    public void CheckTerm_ValidTerm_ReturnsCorrectResult()
    {
        Assert.Equal(24.0, ExpressionCalculator.CheckTerm("2 * 3 * 4"), precision: 6);
        Assert.Equal(5.0, ExpressionCalculator.CheckTerm("20 / 4"), precision: 6);
    }

    [Fact]
    public void CheckFactor_ValidFactor_ReturnsCorrectResult()
    {
        Assert.Equal(42.0, ExpressionCalculator.CheckFactor("42"), precision: 6);
        Assert.Equal(7.0, ExpressionCalculator.CheckFactor("(3 + 4)"), precision: 6);
    }

    [Theory]
    [InlineData("10 / 0")]
    [InlineData("5 / (3 - 3)")]
    [InlineData("5 / (-3 + 3)")]
    public void Calculate_DivideByZero_ThrowsDivideByZeroException(string expression)
    {
        Assert.Throws<DivideByZeroException>(() => ExpressionCalculator.Calculate(expression));
    }

    [Theory]
    // Ngoại lệ lỗi cú pháp
    [InlineData("", "Biểu thức rỗng", 0)]
    [InlineData("5 +", "ở cuối biểu thức thiếu toán hạng", 2)]
    [InlineData("2 * / 3", "không thể đứng ở vị trí này", 4)]
    [InlineData("(2 + 3", "Thiếu dấu ngoặc đóng", 0)]
    [InlineData("2 + 3)", "Thừa dấu ngoặc đóng", 5)]
    [InlineData("2 + a", "Ký tự không hợp lệ", 4)]
    [InlineData("3.14.15", "nhiều hơn một dấu chấm", 4)]
    public void Calculate_InvalidSyntax_ThrowsExpressionParseException(string expression, string expectedErrorMessagePart, int expectedPosition)
    {
        var ex = Assert.Throws<ExpressionParseException>(() => ExpressionCalculator.Calculate(expression));
        Assert.Contains(expectedErrorMessagePart, ex.Message);
        Assert.Equal(expectedPosition, ex.Position);
    }
}
