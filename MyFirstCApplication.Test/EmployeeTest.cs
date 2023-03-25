namespace MyFirstCApplication.Test
{
    public class EmployeeTest
    {
        [Test]
        public void MaxOfGrades()
        {
            var employee = new EmployeeInFile("Patrycja", "Nowak", 27, 'K', "Programistka C#", 4);
            employee.AddGrade(8);
            employee.AddGrade(7);
            employee.AddGrade(99);

            var statistics = employee.GetStatistics();
            var result = statistics.Max;
            Assert.That(result, Is.EqualTo(99));
         }
        [Test]
        public void MinOfGrades()
        {
            var employee = new EmployeeInFile("Patrycja", "Nowak", 27, 'K', "Programistka C#", 4);
            employee.AddGrade(8);
            employee.AddGrade(20);
            employee.AddGrade(82);

            var statistics = employee.GetStatistics();
            var result = statistics.Min;
            Assert.That(result, Is.EqualTo(8));
        }
        [Test]
        public void AverageOfGrades()
        {
            var employee = new EmployeeInFile("Patrycja", "Nowak", 27, 'K', "Programistka C#", 4);
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            var statistics = employee.GetStatistics();
            var result = Math.Round(statistics.Average, 2);
            Assert.That(result, Is.EqualTo(Math.Round(3.33, 2)));
        }

        [Test]
        public void AddGradeString()
        {
            var employee = new EmployeeInFile("Patrycja", "Nowak", 27, 'K', "Programistka C#", 4);
            employee.AddGrade("100");
            employee.AddGrade("20");

            var statistics = employee.GetStatistics();
            var result = Math.Round(statistics.Average, 2);
            Assert.That(result, Is.EqualTo(Math.Round(60.00, 2)));
        }

        [Test]
        public void AddGradeLetterSmallBig()
        {
            var employee = new EmployeeInFile("Patrycja", "Nowak", 27, 'K', "Programistka C#", 4);
            employee.AddGrade("A");
            employee.AddGrade("b");

            var statistics = employee.GetStatistics();
            var result = Math.Round(statistics.Average, 2);
            Assert.That(result, Is.EqualTo(Math.Round(90.00, 2)));
        }

        [Test]
        public void AddGradeChar()
        {
            var employee = new EmployeeInFile("Patrycja", "Nowak", 27, 'K', "Programistka C#", 4);
            employee.AddGrade('B');

            var statistics = employee.GetStatistics();
            var result = Math.Round(statistics.Average, 2);
            Assert.That(result, Is.EqualTo(Math.Round(80.00, 2)));
        }

        [Test]
        public void AddNewEmployee()
        {
            var employee = new EmployeeInFile("Patrycja", "Nowak", 27, 'K', "Programistka C#", 4);

            var result = employee.Name + employee.Surname + employee.Age;
            Assert.That(result, Is.EqualTo("AdamNowak38"));
        }

    }
}