namespace MyFirstCApplication.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var employee = new Employee("Adam", "Nowak", 38);
            employee.AddScore(8);
            employee.AddScore(7);

            var result = employee.Result;

            Assert.AreEqual(15, result);

        }
    }
}