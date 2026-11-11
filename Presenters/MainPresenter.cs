using System.Globalization;
using ExpressionParser.Models;

namespace ExpressionParser.Presenters;

public class MainPresenter : IDisposable
{
    private readonly IMainView _view;

    public MainPresenter(IMainView view)
    {
        _view = view ?? throw new ArgumentNullException(nameof(view));
        _view.CalculateRequested += OnCalculateRequested;
    }

    private void OnCalculateRequested(object? sender, ExpressionCalculateEventArgs e)
    {
        var expr = e.Expression;

        if (string.IsNullOrWhiteSpace(expr))
        {
            _view.ShowCalculationError("Vui lòng nhập biểu thức số học!", null);
            return;
        }

        try
        {
            var result = ExpressionCalculator.Calculate(expr);
            var formattedResult = result.ToString("G15", CultureInfo.InvariantCulture);

            _view.ShowCalculationSuccess(formattedResult);
        }
        catch (DivideByZeroException)
        {
            _view.ShowCalculationError("Lỗi toán học: Không thể chia cho 0!", null);
        }
        catch (ExpressionParseException ex)
        {
            var nonSpacePos = CountNonWhitespaceCharacters(expr, ex.Position);
            var locationText = nonSpacePos > 0 ? $"tại ký tự thứ {nonSpacePos}: " : "";

            _view.ShowCalculationError($"Lỗi cú pháp {locationText}{ex.ExpressionMessage}", ex.Position);
        }
        catch (Exception)
        {
            _view.ShowCalculationError("Biểu thức không hợp lệ. Vui lòng kiểm tra lại!", null);
        }
    }

    private static int CountNonWhitespaceCharacters(string text, int upToIndex)
    {
        int count = 0;
        for (int i = 0; i <= upToIndex && i < text.Length; i++)
        {
            if (!char.IsWhiteSpace(text[i]))
            {
                count++;
            }
        }
        return count;
    }

    public void Dispose()
    {
        _view.CalculateRequested -= OnCalculateRequested;
    }
}
