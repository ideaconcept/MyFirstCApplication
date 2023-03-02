﻿using MyFirstCApplication;

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
employee3.AddScore(1);

//Analiza i podanie wyniku
Employee TheBestOff = null;

if (employee1.Result >= employee2.Result && employee1.Result >= employee3.Result)
{
    TheBestOff = employee1;
}
else
{
    if (employee2.Result >= employee1.Result && employee2.Result >= employee3.Result)
    {
        TheBestOff = employee2;
    }
    else
    {
        TheBestOff = employee3;
     }
}

Console.WriteLine("Osoba o najwyższym wyniku: " + TheBestOff.Name + " " + TheBestOff.Surname + ", lat " + TheBestOff.Age + ", wynik: " + TheBestOff.Result);