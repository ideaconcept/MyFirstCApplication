using MyFirstCApplication;

//Dodanie danych
var employee = new Employee("Jan", "Kowalski", 44);

employee.AddGrade(-3);
employee.AddGrade(5);
employee.AddGrade(102);
employee.AddGrade(5);
employee.AddGrade(4);

var statistics = employee.GetStatistics();

Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Średnia :{statistics.Average:N2}");
