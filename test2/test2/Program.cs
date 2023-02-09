// zadanie domowe dzień 6

using test2;
{
    Employee employee1 = new Employee("Jacek", "Nowak", 44);
    Employee employee2 = new Employee("Edward", "Kowalski", 46);
    Employee employee3 = new Employee("Damian", "Nowy", 23);
    Employee employee4 = new Employee("Radek", "Mocny", 33);

    employee1.AddScore(4);
    employee2.AddScore(2);
    employee3.AddScore(5);
    employee4.AddScore(4);

    employee1.AddScore(6);
    employee2.AddScore(1);
    employee3.AddScore(9);
    employee4.AddScore(7);

    employee1.AddScore(1);
    employee2.AddScore(8);
    employee3.AddScore(10);
    employee4.AddScore(11);

    List<Employee> employees = new List<Employee>()
    {
        employee1,employee2,employee3,employee4

    };
    int maxResult = -1;
    
    foreach(var employee in employees)
    {
        if (employee.Result > maxResult)
        {
        maxResult= employee.Result;
        }
    }
    foreach (var employee in employees)
    {
        if (employee.Result == maxResult)
        {
            Console.WriteLine("Największą liczbę punktów - "+employee.Result+", zdobył "+employee.Name+" "+employee.Surname+" lat "+employee.Age);
        }
    }

}