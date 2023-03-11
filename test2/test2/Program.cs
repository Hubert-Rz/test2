

using System;
using test2;
{

    Console.WriteLine("Witam w programie XYZ do oceny Pracowników");
    Console.WriteLine("==========================================");
    Console.WriteLine("Aby zakończyć wprowadzanie ocen i otrzymać statystykę - wprowadź 'q'.");
    Console.WriteLine();
    var employee = new Employee();
    int index = 1;
    while (true)
    {
        if (index == 1)
        {
            Console.WriteLine("Podaj ocenę pracownika:");
        }
        else
        {
            Console.WriteLine("Podaj kolejną ocenę pracownika:");
        }
        var input = Console.ReadLine();
        if (input == "q")
        {
            break;
        }
        employee.AddGrade(input);
        index++;
    }
    if (index == 1)
    {
        Console.WriteLine("Nie wprowadziłes żadnych ocen, do zobaczenia!");
        
    }

    Console.WriteLine("Statystyka pracownika: ");
    var statistic = employee.GetStatistics();
    Console.WriteLine($"Average: {statistic.Average}");
    Console.WriteLine($"Min: {statistic.Min}");
    Console.WriteLine($"Max: {statistic.Max}");


}
