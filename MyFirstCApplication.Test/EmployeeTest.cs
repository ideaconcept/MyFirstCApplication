namespace MyFirstCApplication.Test
{
    public class Tests
    {
        [Test]
        public void AddingRatings()
        {
            var employee = new Employee("Adam", "Nowak", 38);
            employee.AddScore(8);
            employee.AddScore(7);

            var result = employee.Result;

            Assert.AreEqual(15, result);

        }
        [Test]
        public void AddingRatingsWithANegativeRating()
        {
            var employee = new Employee("Adam", "Nowak", 38);
            employee.AddScore(8);
            employee.AddScore(-2);
            employee.AddScore(-10);

            var result = employee.Result;

            Assert.AreEqual(-4, result);

        }
        [Test]
        public void AddNewEmployee()
        {
            var employee = new Employee("Adam", "Nowak", 38);


            var result = employee.Name + employee.Surname + employee.Age;

            Assert.AreEqual("AdamNowak38", result);

        }

    }
}