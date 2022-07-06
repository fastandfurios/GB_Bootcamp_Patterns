namespace Visitor_pattern
{
    public class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            var employee = element as Employee;

            Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new vacation days: {employee.VacationDays}");
        }
    }
}
