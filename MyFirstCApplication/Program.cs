using MyFirstCApplication;

//Dodanie danych
var employee = new Employee("Jan", "Kowalski", 44);

employee.AddGrade(3);
employee.AddGrade(5);
employee.AddGrade(101);
employee.AddGrade("1,78");
employee.AddGrade("Karolina");
employee.AddGrade('9');
employee.AddGrade(1.69754);

var statistics = employee.GetStatistics();  //Zawiera pętlę ForEach()
var statistics1 = employee.GetStatisticsWithFor();
var statistics2 = employee.GetStatisticsWithDoWhile();
var statistics3 = employee.GetStatisticsWithWhile();



Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Średnia: {statistics.Average:N2}");

Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Średnia: {statistics1.Average:N2}");

Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Średnia: {statistics2.Average:N2}");

Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Średnia: {statistics3.Average:N2}");