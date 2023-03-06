using MyFirstCApplication;

var employee = new Employee("Jan", "Kowalski", 44);

Console.WriteLine("Witamy w programie oceny pracowników:");
Console.WriteLine("=====================================");
Console.WriteLine();
Console.WriteLine("Przy wprowadzaniu oceny pracownika należy podać ocenę w zakresie od 1 do 100 lub oznaczenia literowe: A - pomiędzy 80 a 100, B - pomiędzy 60 a 80, C - pomiędzy 40 a 60, C - pomiędzy 20 a 40, D - poniżej 20. Dopuszcza się wprowadzenia małych lub dużych liter z podanego zakresu.");
Console.WriteLine();

while (true)
{
    Console.WriteLine("Wprowadź ocenę pracownika: ");
    var ocena = Console.ReadLine();
    if(ocena == "q")
    {
        break;
    }
    employee.AddGrade(ocena);
 }


var statistics  = employee.GetStatistics();
Console.WriteLine();
Console.WriteLine($"Wynik oceny pracownika: {employee.Name} {employee.Surname}");
Console.WriteLine($"Średnia ocen: {statistics.Average}");
Console.WriteLine($"Ocena: {statistics.AverageLetter}");
Console.WriteLine($"Ocena minimalna: {statistics.Min}");
Console.WriteLine($"Ocena maksymalna: {statistics.Max}");