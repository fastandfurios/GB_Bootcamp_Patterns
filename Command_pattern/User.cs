namespace Command_pattern
{
    public class User
    {
        private readonly Calculator _calculator = new();
        private List<Command> _commands = new();
        private int _current = 0;

        public void Redo(int levels)
        {
            Console.WriteLine($"\n---- Redo {levels} ");

            for (int i = 0; i < levels; i++)
            {
                if(_current < _commands.Count - 1)
                    _commands[_current++].Execute();
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine($"\n---- Undo {levels} ");

            for (int i = 0; i < levels; i++)
            {
                if(_current > 0)
                    _commands[--_current].UnExecute();
            }
        }

        public void Compute(char @operator, int operand)
        {
            Command command = new CalculatorCommand(_calculator, @operator, operand);
            command.Execute();

            _commands.Add(command);
            _current++;
        }
    }
}
