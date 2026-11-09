using System.Text;

namespace ExpressionParser.Views;

public partial class MainView : Form, IMainView
{
    public event EventHandler<ExpressionCalculateEventArgs>? CalculateRequested;

    private readonly StringBuilder _calcBuffer = new();
    private bool _isKeypadActive = false;

    public MainView()
    {
        InitializeComponent();
        RegisterEventHandlers();
    }

    private void RegisterEventHandlers()
    {
        btnCalculate.Click += (s, e) =>
        {
            TriggerCalculation(txtExpression.Text.Trim(), isKeypad: false);
        };

        txtExpression.KeyDown += (s, e) =>
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TriggerCalculation(txtExpression.Text.Trim(), isKeypad: false);
            }
        };

        // Các nút số và dấu chấm
        btn0.Click += (s, e) => AppendCalcKey("0");
        btn1.Click += (s, e) => AppendCalcKey("1");
        btn2.Click += (s, e) => AppendCalcKey("2");
        btn3.Click += (s, e) => AppendCalcKey("3");
        btn4.Click += (s, e) => AppendCalcKey("4");
        btn5.Click += (s, e) => AppendCalcKey("5");
        btn6.Click += (s, e) => AppendCalcKey("6");
        btn7.Click += (s, e) => AppendCalcKey("7");
        btn8.Click += (s, e) => AppendCalcKey("8");
        btn9.Click += (s, e) => AppendCalcKey("9");
        btnDot.Click += (s, e) => AppendCalcKey(".");

        btnOpenParen.Click += (s, e) => AppendCalcKey("(");
        btnCloseParen.Click += (s, e) => AppendCalcKey(")");

        btnPlus.Click += (s, e) => AppendCalcKey(" + ");
        btnMinus.Click += (s, e) => AppendCalcKey(" - ");
        btnMultiply.Click += (s, e) => AppendCalcKey(" * ");
        btnDivide.Click += (s, e) => AppendCalcKey(" / ");

        // Xóa một ký tự
        btnBackspace.Click += (s, e) =>
        {
            if (_calcBuffer.Length > 0)
            {
                // Nếu ký tự cuối là khoảng trắng, xóa hết khoảng trắng liền kề
                while (_calcBuffer.Length > 0 && _calcBuffer[_calcBuffer.Length - 1] == ' ')
                {
                    _calcBuffer.Length--;
                }
                if (_calcBuffer.Length > 0)
                {
                    _calcBuffer.Length--;
                }
                while (_calcBuffer.Length > 0 && _calcBuffer[_calcBuffer.Length - 1] == ' ')
                {
                    _calcBuffer.Length--;
                }
                txtCalcExpression.Text = _calcBuffer.ToString();
                lblCalcResult.Text = "";
            }
        };

        btnClear.Click += (s, e) =>
        {
            _calcBuffer.Clear();
            txtCalcExpression.Text = "";
            lblCalcResult.Text = "";
        };

        btnEqual.Click += (s, e) =>
        {
            TriggerCalculation(_calcBuffer.ToString().Trim(), isKeypad: true);
        };
    }

    private void AppendCalcKey(string text)
    {
        _calcBuffer.Append(text);
        txtCalcExpression.Text = _calcBuffer.ToString();
        lblCalcResult.Text = "";
    }

    private void TriggerCalculation(string expression, bool isKeypad)
    {
        _isKeypadActive = isKeypad;
        CalculateRequested?.Invoke(this, new ExpressionCalculateEventArgs(expression));
    }

    public void ShowCalculationSuccess(string formattedResult)
    {
        if (_isKeypadActive)
        {
            lblCalcResult.ForeColor = Color.FromArgb(56, 158, 13);
            lblCalcResult.Text = "= " + formattedResult;
        }
        else
        {
            lblResult.ForeColor = Color.FromArgb(56, 158, 13);
            lblResult.Text = formattedResult;
        }
    }

    public void ShowCalculationError(string expressionMessage, int? errorPosition)
    {
        if (_isKeypadActive)
        {
            lblCalcResult.ForeColor = Color.FromArgb(207, 19, 34);
            lblCalcResult.Text = expressionMessage;
        }
        else
        {
            lblResult.ForeColor = Color.FromArgb(207, 19, 34);
            lblResult.Text = expressionMessage;

            if (errorPosition.HasValue && errorPosition.Value >= 0 && errorPosition.Value < txtExpression.Text.Length)
            {
                txtExpression.Select(errorPosition.Value, 1);
                txtExpression.Focus();
            }
        }
    }
}
