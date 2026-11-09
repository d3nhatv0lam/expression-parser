namespace ExpressionParser;

public partial class MainView : Form, IMainView
{
    public string Expression { get; }
    
    public MainView()
    {
        InitializeComponent();
    }

    public event EventHandler? CalculationButtonClicked;

    public void UpdateResult(string result)
    {
        throw new NotImplementedException();
    }
}