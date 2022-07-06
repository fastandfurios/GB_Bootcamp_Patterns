using Visitor_pattern.EmployeesExample;

namespace Visitor_pattern
{
    public static class MainClass
    {
        public static void Run()
        {
            var employees = new Employees();
            employees.Attach(new Clerk());
            employees.Attach(new Director());
            employees.Attach(new President());

            employees.Accept(new IncomeVisitor());
            employees.Accept(new VacationVisitor());
        }
    }
}
