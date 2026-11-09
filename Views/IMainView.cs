namespace ExpressionParser;

public class ExpressionCalculateEventArgs : EventArgs
{
    public string Expression { get; }

    public ExpressionCalculateEventArgs(string expression)
    {
        Expression = expression;
    }
}

public interface IMainView
{
    event EventHandler<ExpressionCalculateEventArgs>? CalculateRequested;

    void ShowCalculationSuccess(string formattedResult);

    void ShowCalculationError(string expressionMessage, int? errorPosition);
}
