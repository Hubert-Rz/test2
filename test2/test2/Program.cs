

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
    var statistics=emp.GetStatistics();
    Console.WriteLine($"Average: {statistics.Average:N2}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");


}