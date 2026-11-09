namespace ExpressionParser;

public interface IMainView
{
    event EventHandler CalculationButtonClicked;
    string Expression { get; }
    
    void UpdateResult(string result);
}