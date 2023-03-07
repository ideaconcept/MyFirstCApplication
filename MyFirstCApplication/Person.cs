namespace MyFirstCApplication
{
    public abstract class Person
    {
        public Person(string name, string surname, int age, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public char Sex { get;}
    }
}
