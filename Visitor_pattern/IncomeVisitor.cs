namespace Visitor_pattern
{
    public class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            var employee = element as Employee;

            employee.Income *= 1.10;

            Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new income: {employee.Income:C}");
        }
    }
}
