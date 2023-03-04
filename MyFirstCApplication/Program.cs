using MyFirstCApplication;

//Dodanie danych
var employee = new Employee("Jan", "Kowalski", 44);

employee.AddGrade(3);
employee.AddGrade(5);
employee.AddGrade(101);
employee.AddGrade("1,78");
employee.AddGrade("Karolina");

var statistics = employee.GetStatistics();

Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Średnia: {statistics.Average:N2}");
