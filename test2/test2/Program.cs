

using System;
using test2;
{

    Console.WriteLine("Witam w programie XYZ do oceny Pracowników");
    Console.WriteLine("==========================================");
    Console.WriteLine("Aby zakończyć wprowadzanie ocen i otrzymać statystykę - wprowadź 'q'.");
    Console.WriteLine();
    var employee = new EmployeeInFile("Hubert", "Rzążewski", 'M'); ;
    employee.GradeAdded += EmployeeGradeAdded;

    void EmployeeGradeAdded(object sender, EventArgs args)
    {
        Console.WriteLine("Dodano nową ocenę");
    }

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
        }else if(input == null) 
        {
            Console.WriteLine("Nie wprowadziłes żadnej oceny !");
        }

        try
        {
            employee.AddGrade(input);
            index++;
        }
        catch(Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
    if (index == 1)
    {
        Console.WriteLine("Nie wprowadziłes żadnych ocen, do zobaczenia!");
        
    }

    Console.WriteLine("Statystyka pracownika: ");
    var statistic = employee.GetStatistics();
    Console.WriteLine($"Min: {statistic.Min}");
    Console.WriteLine($"Max: {statistic.Max}");
    Console.WriteLine($"Sum: {statistic.Sum}");
    Console.WriteLine($"Count: {statistic.Count}");
    Console.WriteLine($"Average: {statistic.Average}");
    Console.WriteLine($"Average Letter: {statistic.AverageLetter}");


}
