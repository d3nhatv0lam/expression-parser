namespace ExpressionParser.Presenters;

public class MainPresenter: IDisposable
{
    private readonly IMainView _view;

    public MainPresenter(IMainView view)
    {
        _view = view;
        _view.CalculationButtonClicked += OnCalculationButtonClicked;
    }

    private void OnCalculationButtonClicked(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        _view.CalculationButtonClicked -= OnCalculationButtonClicked;
    }
}