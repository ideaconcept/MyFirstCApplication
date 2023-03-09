using MyFirstCApplication;
using System;

var supervisor = new EmployeeInFile("Jan", "Kowalski", 44, 'M', "Dyrektor", 12);
var employee = new EmployeeInMemory("Patrycja", "Nowak", 27, 'K', "Programistka C#", 4);

supervisor.GradeAdded += EmployeeGradeAdded;
employee.GradeAdded += EmployeeGradeAdded;

static void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Dodano nową ocenę pracownika.\n");
    Console.ResetColor();
}

Console.WriteLine("Witamy w programie oceny pracowników:");
Console.WriteLine("=====================================\n");
Console.WriteLine("Wybierz jedną z poniższych opcji lub X aby zakończyć prace programu:");
Console.WriteLine("1. Kierownik (In file)");
Console.WriteLine("2. Pracownik (In memory)");
Console.WriteLine("X. Zakończ pracę programu\n");


while (true)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Twój wybór: ");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Magenta;
    var choice = Console.ReadLine();
    Console.ResetColor();

    if (choice == "1")
    {
        Console.WriteLine("\nPrzy wprowadzaniu oceny kierownika należy podać:\n- punktację w zakresie od 7 do 100 lub\n- oceny od 1 do 6, które mają następujące wartości:\n  - 1 - 0 punktów,\n  - 2 - 20 punktów,\n  - 3 - 40 punktów,\n  - 4 - 60 punktów,\n  - 5 - 80 punktów,\n  - 6 - 100 punktów.\n  Wskazaną ocenę można pomniejszyć lub powiększyć o 5 punktów wpisując przy ocenie plus (+) lub minus (-), np: 1+ lub -6.\n");
 
        while (true)
        {
            Console.WriteLine("Wprowadź ocenę dla kierownika lub q aby zakończyć wprowadzanie danych i wyliczyć wynik: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ocena: ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            var ocena = Console.ReadLine();
            Console.ResetColor();
            ocena = ocena.Replace(".", ",");

            if (ocena == "q")
            {
                break;
            }

            try
            {
                supervisor.AddGrade(ocena);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Wystąpił błąd: {e.Message}");
                Console.ResetColor();
            }
        }

        var statistics = supervisor.GetStatistics();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"\nWynik oceny pracownika: {supervisor.Name} {supervisor.Surname}");
        Console.WriteLine($"Średnia ocen: {statistics.Average}");
        Console.WriteLine($"Ocena: {statistics.AverageLetter}");
        Console.WriteLine($"Ocena minimalna: {statistics.Min}");
        Console.WriteLine($"Ocena maksymalna: {statistics.Max}");
        Console.ResetColor();
        Environment.Exit(0);
    }
    else if (choice == "2")
    {
        Console.WriteLine("\nPrzy wprowadzaniu oceny pracownika należy podać ocenę w zakresie od 1 do 100 lub oznaczenia literowe:\n A - pomiędzy 80 a 100,\n B - pomiędzy 60 a 80,\n C - pomiędzy 40 a 60,\n C - pomiędzy 20 a 40,\n D - poniżej 20.\n Dopuszcza się wprowadzenia małych lub dużych liter z podanego zakresu.\n");

        while (true)
        {
            Console.WriteLine("Wprowadź ocenę pracownika lub q aby zakończyć wprowadzanie danych i wyliczyć wynik: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ocena: ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            var ocena = Console.ReadLine();
            Console.ResetColor();
            ocena = ocena.Replace(".", ",");

            if (ocena == "q")
            {
                break;
            }

            try
            {
                employee.AddGrade(ocena);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Wystąpił błąd: {e.Message}");
            }
        }

        var statistics = employee.GetStatistics();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"\nWynik oceny pracownika: {employee.Name} {employee.Surname}");
        Console.WriteLine($"Średnia ocen: {statistics.Average}");
        Console.WriteLine($"Ocena: {statistics.AverageLetter}");
        Console.WriteLine($"Ocena minimalna: {statistics.Min}");
        Console.WriteLine($"Ocena maksymalna: {statistics.Max}");
        Console.ResetColor();
        Environment.Exit(0);
    }
    else if (choice == "x" || choice == "X")
    {
        Environment.Exit(0);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Wprowadzono złą wartość. Wybierz: 1, 2 lub q\n");
        Console.ResetColor();
    }

}
