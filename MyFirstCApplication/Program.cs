using MyFirstCApplication;

//Dodanie danych
Employee employee1 = new Employee("Jan", "Kowalski", 44);
Employee employee2 = new Employee("Anna", "Nowakowska", 26);
Employee employee3 = new Employee("Piotr", "Kałuża", 62);

employee1.AddScore(9);
employee1.AddScore(5);
employee1.AddScore(10);
employee1.AddScore(5);
employee1.AddScore(4);

employee2.AddScore(10);
employee2.AddScore(8);
employee2.AddScore(5);
employee2.AddScore(4);
employee2.AddScore(7);

employee3.AddScore(10);
employee3.AddScore(7);
employee3.AddScore(9);
employee3.AddScore(4);
employee3.AddScore(10);

//Analiza i podanie wyniku
if (employee1.Result >= employee2.Result && employee1.Result >= employee3.Result)
{
    Console.WriteLine("Osoba o najwyższym wyniku: " + employee1.Name + " " + employee1.Surname + ", lat " + employee1.Age + ", wynik: " + employee1.Result);
}
else
{
    if (employee2.Result >= employee1.Result && employee2.Result >= employee3.Result)
    {
        Console.WriteLine("Osoba o najwyższym wyniku: " + employee2.Name + " " + employee2.Surname + ", lat " + employee2.Age + ", wynik: " + employee2.Result);
    }
    else
    {
        Console.WriteLine("Osoba o najwyższym wyniku: " + employee3.Name + " " + employee3.Surname + ", lat " + employee3.Age + ", wynik: " + employee3.Result);
    }
}