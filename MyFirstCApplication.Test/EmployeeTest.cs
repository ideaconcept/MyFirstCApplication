namespace MyFirstCApplication.Test
{
    public class EmployeeTest
    {
        [Test]
        public void MaxOfGrades()
        {
            var employee = new Employee("Adam", "Nowak", 38);
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
            var employee = new Employee("Adam", "Nowak", 38);
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
            var employee = new Employee("Adam", "Nowak", 38);
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            var statistics = employee.GetStatistics();
            var result = Math.Round(statistics.Average, 2);
            Assert.That(result, Is.EqualTo(Math.Round(3.33, 2)));
        }
        [Test]
        public void AddNewEmployee()
        {
            var employee = new Employee("Adam", "Nowak", 38);

            var result = employee.Name + employee.Surname + employee.Age;
            Assert.That(result, Is.EqualTo("AdamNowak38"));

        }

    }
}