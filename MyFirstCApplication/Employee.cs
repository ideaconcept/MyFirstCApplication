namespace MyFirstCApplication
{
    public class Employee
    {
        private List<int> score = new List<int>();
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Result
        {
            get
            {
                return score.Sum();
            }
        }
        public void AddScore(int score)
        {
            this.score.Add(score);
        }
        public void AddGrades(int grade)
        {
            this.grades.Add(grade);
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();



            return statistics;
        }

    }
}