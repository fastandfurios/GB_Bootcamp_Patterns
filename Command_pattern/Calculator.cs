namespace Command_pattern;

public class Calculator
{
    private int _curr = 0;

    public void Operation(char @operator, int operand)
    {
        _curr = @operator switch
        {
            '+' => _curr + operand,
            '-' => _curr - operand,
            '*' => _curr * operand,
            '/' => _curr / operand,
            _ => throw new NotImplementedException()
        };

        Console.WriteLine($"Current value = {_curr, 3} (following {@operator} {operand})");
    }
}