using EasyBuilder;

namespace Builder_pattern
{
    public static class MainClass
    {
        public static void Run()
        {
            var director = new Director();
            director.SetBuilder(new LightIndustrialUnitBuilder());

            var industrialUnit = director.BuildIndustrialUnit();

            Console.WriteLine(industrialUnit);

            director.SetBuilder(new HeavyIndustrialUnitBuilder());
            Console.WriteLine(director.BuildIndustrialUnit());

            var report = new Report
                    .Builder("Отчёт за III квартал 2021 года")
                .SetTitle("Закупка")
                .SetContent("Реализовано успешно.")
                .SetTable("Таблица цен")
                .SetPageNumber(1)
                .Build();

            Console.WriteLine(report);
        }
    }
}
