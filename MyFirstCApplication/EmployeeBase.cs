namespace MyFirstCApplication
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname, int age, char sex, string position, int seniority)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Sex = sex;
            this.Position = position;
            this.Seniority = seniority;
        }
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public char Sex { get; }
        public string Position { get; }
        public int Seniority { get; }

        public abstract void AddGrade(float grade);
        public abstract void AddGrade(string grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(long grade);
        public abstract void AddGrade(decimal grade);
        public abstract void AddGrade(int grade);

        public abstract Statistics GetStatistics();
    }
}
