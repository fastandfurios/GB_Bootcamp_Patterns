namespace Mediator_pattern
{
    public static class MainClass
    {
        public static void Run()
        {
            var cMediator = new ConcreteMediator();

            var colleague1 = new ConcreteColleague1(cMediator);
            var colleague2 = new ConcreteColleague2(cMediator);

            cMediator.Colleague1 = colleague1;
            cMediator.Colleague2 = colleague2;

            colleague1.Send("How are you?");
            colleague2.Send("Fine, thanks");
        }
    }
}
