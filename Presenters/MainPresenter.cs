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
        string expr = e.Expression;
        Console.WriteLine($"[INFO] Yêu cầu tính toán biểu thức: '{expr}'");

        if (string.IsNullOrWhiteSpace(expr))
        {
            _view.ShowCalculationError("Vui lòng nhập biểu thức số học!", null);
            return;
        }

        try
        {
            double result = ExpressionCalculator.Calculate(expr);
            string formattedResult = result.ToString("G15", CultureInfo.InvariantCulture);

            Console.WriteLine($"[SUCCESS] Biểu thức '{expr}' = {formattedResult}");
            _view.ShowCalculationSuccess(formattedResult);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"[ERROR DivideByZero] {ex.Message}");
            Console.WriteLine(ex.StackTrace);

            _view.ShowCalculationError("Lỗi toán học: Không thể chia cho 0!", null);
        }
        catch (ExpressionParseException ex)
        {
            Console.WriteLine($"[ERROR Syntax at pos {ex.Position}] {ex.Message}");
            Console.WriteLine(ex.StackTrace);

            _view.ShowCalculationError($"Lỗi cú pháp tại vị trí {ex.Position + 1}: {ex.ExpressionMessage}", ex.Position);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[ERROR Unexpected] {ex.Message}");
            Console.WriteLine(ex.StackTrace);

            _view.ShowCalculationError("Biểu thức không hợp lệ. Vui lòng kiểm tra lại!", null);
        }
    }

    public void Dispose()
    {
        _view.CalculateRequested -= OnCalculateRequested;
    }
}
