namespace ExpressionParser.Models;

public class ExpressionParseException : FormatException
{
    public int Position { get; }
    public string ExpressionMessage { get; }

    public ExpressionParseException(int position, string expressionMessage)
        : base($"Lỗi cú pháp tại vị trí {position + 1}: {expressionMessage}")
    {
        Position = position;
        ExpressionMessage = expressionMessage;
    }
}
