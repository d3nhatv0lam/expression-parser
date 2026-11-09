using System.Globalization;

namespace ExpressionParser.Models;

public static class ExpressionCalculator
{
    public static double Calculate(string expression)
    {
        if (expression == null || string.IsNullOrWhiteSpace(expression))
        {
            throw new ExpressionParseException(0, "Biểu thức rỗng. Vui lòng nhập biểu thức.");
        }

        var parser = new Parser(expression);
        double result = parser.CheckExpression();

        parser.SkipWhitespace();
        if (parser.CurrentPos < expression.Length)
        {
            char leftover = expression[parser.CurrentPos];
            if (leftover == ')')
            {
                throw new ExpressionParseException(parser.CurrentPos, "Thừa dấu ngoặc đóng ')' không có dấu mở tương ứng.");
            }
            throw new ExpressionParseException(parser.CurrentPos, $"Ký tự dư thừa không hợp lệ '{leftover}'.");
        }

        return result;
    }

    public static double CheckExpression(string expression)
    {
        return Calculate(expression);
    }

    public static double CheckTerm(string expression)
    {
        if (expression == null || string.IsNullOrWhiteSpace(expression))
        {
            throw new ExpressionParseException(0, "Số hạng (Term) rỗng.");
        }

        var parser = new Parser(expression);
        double result = parser.CheckTerm();
        parser.SkipWhitespace();
        if (parser.CurrentPos < expression.Length)
        {
            throw new ExpressionParseException(parser.CurrentPos, $"Ký tự dư thừa sau Term: '{expression[parser.CurrentPos]}'.");
        }
        return result;
    }

    public static double CheckFactor(string expression)
    {
        if (expression == null || string.IsNullOrWhiteSpace(expression))
        {
            throw new ExpressionParseException(0, "Thừa số (Factor) rỗng.");
        }

        var parser = new Parser(expression);
        double result = parser.CheckFactor();
        parser.SkipWhitespace();
        if (parser.CurrentPos < expression.Length)
        {
            throw new ExpressionParseException(parser.CurrentPos, $"Ký tự dư thừa sau Factor: '{expression[parser.CurrentPos]}'.");
        }
        return result;
    }

    /// <summary>
    /// E -> T + E | T - E | T 
    /// T -> F * T | F / T | F 
    /// F -> (E) | id | -F | +F
    /// </summary>
    private sealed class Parser
    {
        private readonly string _input;
        private int _currentPos;

        public int CurrentPos => _currentPos;

        public Parser(string input)
        {
            _input = input;
            _currentPos = 0;
        }

        public void SkipWhitespace()
        {
            while (_currentPos < _input.Length && char.IsWhiteSpace(_input[_currentPos]))
            {
                _currentPos++;
            }
        }


        public double CheckExpression()
        {
            double result = CheckTerm();

            while (_currentPos < _input.Length)
            {
                SkipWhitespace();
                if (_currentPos >= _input.Length)
                {
                    break;
                }

                char op = _input[_currentPos];
                if (op != '+' && op != '-')
                {
                    break;
                }

                int opPos = _currentPos;
                _currentPos++;
                SkipWhitespace();

                if (_currentPos >= _input.Length)
                {
                    throw new ExpressionParseException(opPos, $"Toán tử '{op}' ở cuối biểu thức thiếu toán hạng tiếp theo.");
                }

                double result1 = CheckTerm();
                if (op == '+')
                {
                    result += result1;
                }
                else
                {
                    result -= result1;
                }
            }

            return result;
        }


        public double CheckTerm()
        {
            double result = CheckFactor();

            while (_currentPos < _input.Length)
            {
                SkipWhitespace();
                if (_currentPos >= _input.Length)
                {
                    break;
                }

                char op = _input[_currentPos];
                if (op != '*' && op != '/')
                {
                    break;
                }

                int opPos = _currentPos;
                _currentPos++;
                SkipWhitespace();

                if (_currentPos >= _input.Length)
                {
                    throw new ExpressionParseException(opPos, $"Toán tử '{op}' ở cuối biểu thức thiếu toán hạng tiếp theo.");
                }

                double result1 = CheckFactor();
                if (op == '*')
                {
                    result *= result1;
                }
                else
                {
                    if (Math.Abs(result1) < 1e-15)
                    {
                        throw new DivideByZeroException("Không thể thực hiện phép chia cho 0.");
                    }
                    result /= result1;
                }
            }

            return result;
        }

     
        public double CheckFactor()
        {
            SkipWhitespace();
            if (_currentPos >= _input.Length)
            {
                int errorPos = _currentPos > 0 ? _currentPos - 1 : 0;
                throw new ExpressionParseException(errorPos, "Biểu thức kết thúc bất ngờ, thiếu toán hạng.");
            }

            char c = _input[_currentPos];

            // Xử lý dấu ngoặc (E)
            if (c == '(')
            {
                int openParenPos = _currentPos;
                _currentPos++;

                double result = CheckExpression();

                SkipWhitespace();
                if (_currentPos < _input.Length && _input[_currentPos] == ')')
                {
                    _currentPos++;
                    return result;
                }

                throw new ExpressionParseException(openParenPos, "Thiếu dấu ngoặc đóng ')' tương ứng.");
            }


            if (c == '-')
            {
                _currentPos++;
                return -CheckFactor();
            }

            if (c == '+')
            {
                _currentPos++;
                return CheckFactor();
            }

            if (char.IsDigit(c) || c == '.')
            {
                return GetDigits();
            }

            if (c == ')')
            {
                throw new ExpressionParseException(_currentPos, "Thừa dấu ngoặc đóng ')' không hợp lệ.");
            }

            if (c == '*' || c == '/')
            {
                throw new ExpressionParseException(_currentPos, $"Toán tử '{c}' không thể đứng ở vị trí này.");
            }

            throw new ExpressionParseException(_currentPos, $"Ký tự không hợp lệ '{c}'.");
        }


        public double GetDigits()
        {
            int startPos = _currentPos;
            bool hasDot = false;

            while (_currentPos < _input.Length)
            {
                char ch = _input[_currentPos];
                if (char.IsDigit(ch))
                {
                    _currentPos++;
                }
                else if (ch == '.')
                {
                    if (hasDot)
                    {
                        throw new ExpressionParseException(_currentPos, "Số chứa nhiều hơn một dấu chấm thập phân '.'.");
                    }
                    hasDot = true;
                    _currentPos++;
                }
                else
                {
                    break;
                }
            }

            string numStr = _input.Substring(startPos, _currentPos - startPos);
            if (numStr == ".")
            {
                throw new ExpressionParseException(startPos, "Dấu chấm thập phân '.' không có chữ số đi kèm.");
            }

            if (double.TryParse(numStr, NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
            {
                return value;
            }

            throw new ExpressionParseException(startPos, $"Không thể phân giải '{numStr}' thành số hợp lệ.");
        }
    }
}
