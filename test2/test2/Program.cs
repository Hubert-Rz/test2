

using test2;
{
    var emp = new Employee("Hubert", "Rzazewski");
    emp.AddGrade(19.1);
    emp.AddGrade("4000");
    emp.AddGrade("Hubert");
    emp.AddGrade(0.987);
    emp.AddGrade(6);
    emp.AddGrade(2);
    emp.AddGrade('1');
    emp.AddGrade('x');
    //var statistics = emp.GetStatistics();
    var statistics1 = emp.GetStatisticsWithForEach();
    var statistics2 = emp.GetStatisticsWithFor();
    var statistics3 = emp.GetStatisticsWithDoWhile();
    var statistics4 = emp.GetStatisticsWithWhile();

    Console.WriteLine("----------------GetStatisticsWithForEach----------------");
    Console.WriteLine($"Average: {statistics1.Average:N2}");
    Console.WriteLine($"Min: {statistics1.Min}");
    Console.WriteLine($"Max: {statistics1.Max}");
    Console.WriteLine("-----------------GetStatisticsWithFor---------------");
    Console.WriteLine($"Average: {statistics2.Average:N2}");
    Console.WriteLine($"Min: {statistics2.Min}");
    Console.WriteLine($"Max: {statistics2.Max}");
    Console.WriteLine("----------------GetStatisticsWithDoWhile----------------");
    Console.WriteLine($"Average: {statistics3.Average:N2}");
    Console.WriteLine($"Min: {statistics3.Min}");
    Console.WriteLine($"Max: {statistics3.Max}");
    Console.WriteLine("----------------GetStatisticsWithWhile----------------");
    Console.WriteLine($"Average: {statistics4.Average:N2}");
    Console.WriteLine($"Min: {statistics4.Min}");
    Console.WriteLine($"Max: {statistics4.Max}");


}