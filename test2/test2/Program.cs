

using test2;
{
    var emp = new Employee("Hubert", "Rzazewski");
    emp.AddGrade(1.1F);
    emp.AddGrade(6);
    emp.AddGrade(2);
    var statistics=emp.GetStatistics();
    Console.WriteLine($"Average: {statistics.Average:N4}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");


}