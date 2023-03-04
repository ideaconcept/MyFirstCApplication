using MyFirstCApplication;

//Dodanie danych
var employee1 = new Employee("Jan", "Kowalski", 44);
var employee2 = new Employee("Anna", "Nowakowska", 26);
var employee3 = new Employee("Piotr", "Kałuża", 62);

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

employee3.AddScore(1);
employee3.AddScore(2);
employee3.AddScore(1);
employee3.AddScore(3);
employee3.AddScore(10);

var statistics = employee1.GetStatistics();
statistics.Min
