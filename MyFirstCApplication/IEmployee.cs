namespace MyFirstCApplication
{
    public interface IEmployee
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public char Sex { get; }
        public string Position { get; }
        public int Seniority { get; }
        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(double grade);
        void AddGrade(long grade);
        void AddGrade(decimal grade);
        void AddGrade(int grade);
        Statistics GetStatistics();
    }
}
