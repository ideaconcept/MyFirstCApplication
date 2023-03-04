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
            employee.AddGrade(101);

            var statistics = employee.GetStatistics();
            var result = statistics.Max;
            Assert.That(result, Is.EqualTo(101));
         }
        [Test]
        public void MinOfGrades()
        {
            var employee = new Employee("Adam", "Nowak", 38);
            employee.AddGrade(8);
            employee.AddGrade(-2);
            employee.AddGrade(-10);

            var statistics = employee.GetStatistics();
            var result = statistics.Min;
            Assert.That(result, Is.EqualTo(-10));
        }
        [Test]
        public void AverageOfGrades()
        {
            var employee = new Employee("Adam", "Nowak", 38);
            employee.AddGrade(8);
            employee.AddGrade(-2);
            employee.AddGrade(-9);

            var statistics = employee.GetStatistics();
            var result = statistics.Average;
            Assert.That(result, Is.EqualTo(-1));
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