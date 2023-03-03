namespace MyFirstCApplication.Test
{
    public class TypeTest
    {
        [Test]
        public void ReferenceTypeComparison()
        {
            var employee1 = GetEmployee("Jacek", "Kowalski", 26);
            var employee2 = GetEmployee("Jianna", "Nowak", 39);
            var employee3 = GetEmployee("Paweł", "Nowak", 42);

            Assert.AreNotEqual(employee2, employee3);

        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }

        [Test]
        public void ValueTypeComparison()
        {
            int number1 = 132;
            int number2 = 132;

            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void String_ImmutableTypeComparison()
        {
            string name1 = "Jacek";
            string name2 = "Jacek";

            Assert.AreEqual(name1, name2);

        }
    }
}
